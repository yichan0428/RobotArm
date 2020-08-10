using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;

using WindowsFormsTCP_Client;

namespace wGeneralClient
{
    //==================================================================
    //	Before use
    //
    //  1.This class is reference Microsoft [Asynchronous client] sample code
    //  The web site address below
    //  https://msdn.microsoft.com/zh-tw/library/bew39x2a(v=vs.110).aspx
    //
    //  2. You have to using the UI namespace, for updata data or status to forms.
    //     ex: using WindowsFormsTCP_Client;
    //
    //  3. When forms forms_load, you have put frm object to this class..
    //     Example below
    //
    //    public void InitialClientObject()
    //    {
    //        GeneralClient.ClientUpdataUI(this);
    //    }
    //  
    //  4. In forms class, you have build two delegate function, one for updata recive data,
    //     another for updata lost communication status 
    //
    //     *Updata recive data example below
    //
    //    public delegate void UIOperationInfomationUpdataUI(string strReviceData);
    //    public void UIMonitorOperationToDoUpdataUI(string strReviceData)
    //    {
    //        if (this.InvokeRequired)
    //        {
    //            UIOperationInfomationUpdataUI myUpdateOperationUpdataUI = new UIOperationInfomationUpdataUI(UIMonitorOperationToDoUpdataUI);
    //            this.Invoke(myUpdateOperationUpdataUI, strReviceData);
    //        }
    //        else
    //        {
    //            ReciveData(strReviceData);
    //        }
    //   }//Revice Data
    //
    //     *Updata lost communicaion example below
    //
    //    public delegate void UIOperationInfomationUpdataUI_ConnectionStatus(bool bIsConnection);
    //    public void UIMonitorOperationToDoUpdataUI_ConnectionStatus(bool bIsConnection)
    //    {
    //        if (this.InvokeRequired)
    //        {
    //            UIOperationInfomationUpdataUI_ConnectionStatus myUpdateOperationUpdataUI_ConnectionStatus = new UIOperationInfomationUpdataUI_ConnectionStatus(UIMonitorOperationToDoUpdataUI_ConnectionStatus);
    //            this.Invoke(myUpdateOperationUpdataUI_ConnectionStatus, bIsConnection);
    //        }
    //        else
    //        {
    //            Button_Client_Connect.Text = "Connect";
    //            Disconnect();
    //        }
    //    }//Lost connection with server
    //
    //==================================================================

    // State object for receiving data from remote device.
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 256;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }

    class GeneralClient // AsynchronousClient 
    {
        private static bool bIsConnected = false;

        //==================================================================
        //	Purpose:  The response from the remote device.
        //==================================================================
        private static String m_Response = String.Empty;
        
        //==================================================================
        //	Purpose:  The response from the remote device.
        //==================================================================
        private static String m_Remote_Response = String.Empty;
        
        //==================================================================
        //	Purpose:  Create a TCP/IP socket.
        //==================================================================
        private static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        // ManualResetEvent instances signal completion.
        private static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static ManualResetEvent sendDone = new ManualResetEvent(false);
        private static ManualResetEvent receiveDone = new ManualResetEvent(false);


        //==================================================================
        //	Function: ClientUpdataUI
        //	Purpose:  This function is used for let UI call build delegate function    
        //==================================================================
        private static WindowsFormsClient frm;
        public static void ClientUpdataUI(object ofrm)
        {
            frm = (WindowsFormsClient)ofrm;            
        }

        //==================================================================
        //	Function: UpdataReviceDataToUI
        //	Purpose:  This function is used for delegate function, and it is for send revice data to forms(UI)
        //==================================================================
        public static void UpdataReviceDataToUI(string strReviceData)
        {
            if(strReviceData != "")
                frm.UIMonitorOperationToDoUpdataUI(strReviceData);
        }

        //==================================================================
        //	Function: UpdataConnectionStatusToUI
        //	Purpose:  This function is used for delegate function, and it is for updata lost communication status to forms(UI)
        //==================================================================
        public static void UpdataConnectionStatusToUI(bool bIsConnectioned)
        {
            frm.UIMonitorOperationToDoUpdataUI_ConnectionStatus(bIsConnectioned);
        }
        
        //==================================================================
        //	Function: ClientConnect
        //	Purpose:  This function is used to connect remote device..
        //==================================================================
        public static void ClientConnect(string strIP, int iPort)
        {
            bIsConnected = false;

            // Connect to a remote device.
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Establish the remote endpoint for the socket.
                // The name of the 
                // Remote device is "local host".
                bool bIpOK = true;
                IPAddress ipAddress_ipv4;
                bIpOK = IPAddress.TryParse(strIP, out ipAddress_ipv4);
                
                if (bIpOK)
                {
                    IPAddress ipAddress = ipAddress_ipv4;
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, iPort);
                    
                    // Connect to the remote endpoint.
                    client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), client);
                    connectDone.WaitOne();                 
                }
            }
            catch (Exception e) 
            {
                bIsConnected = false;
                Console.WriteLine(e.ToString());
            }    
        }
        
        //==================================================================
        //	Function: ClientSendData
        //	Purpose:  This function is used to send data to remote device..
        //==================================================================
        /*
        public static void ClientSendData(string strData)
        {
            strData.Trim();
            if (strData != "")
            {
                if (client.Connected)
                {
                    // Send test data to the remote device.
                    Send(client, strData);
                    sendDone.WaitOne();
                }
            }
        }
        */
        public static void ClientSendData(string strData)
        {
            strData.Trim();
            if (strData != "")
            {
                if (bIsConnected)
                {
                    strData += "\0";

                    // Send test data to the remote device.
                    Send(client, strData);
                    sendDone.WaitOne();
                }
            }
        }
        
        //==================================================================
        //	Function: ClientDisconnect
        //	Purpose:  This function is used to disconnect communication.
        //           Disconnect parameter set true, it mean user can re-use the socket resources.!
        //
        //           MSDN: Closes the socket connection and allows reuse of the socket.
        //==================================================================
        public static void ClientDisconnect()
        {
            client.Shutdown(SocketShutdown.Both);
            client.Close();

            bIsConnected = false;
        }
        
        //==================================================================
        //	Function: ClientReleaseObject
        //	Purpose:  This function is used to release socket object...
        //==================================================================
        public static void ClientReleaseObject()
        {
            // Release the socket.
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
        
        //==================================================================
        //	Function: ClientIsConnected
        //	Purpose:  This function is used to return client connected status..
        //==================================================================
        public static bool ClientIsConnected()
        {
            bool bInConnected = false;
            //bInConnected = client.Connected;
            bInConnected = bIsConnected;
            return bInConnected;
        }
        
        //==================================================================
        //	Function: ConnectCallback
        //	Purpose:  This function is the connect callback function, copy from MSDN
        //==================================================================
        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;
                
                // Complete the connection.
                client.EndConnect(ar);
                
                Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString());
                
                // Signal that the connection has been made.
                connectDone.Set();

                // Assignment recvice data callback 
                bIsConnected = true;
                UpdataReviceDataToUI("Connected");
                
                // Setup receive callback
                Receive(client);
                receiveDone.WaitOne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        //==================================================================
        //	Function: Receive
        //	Purpose:  This function is the Receive function. copy from MSDN
        //==================================================================
        private static void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;
                
                // Begin receiving the data from the remote device.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        //==================================================================
        //	Function: ReceiveCallback
        //	Purpose:  This function is the receive callback function, copy from MSDN
        //==================================================================
        /*
        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                
                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);
                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.sb.Length > 1)
                    {
                        m_Response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        */
        
        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                
                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);
                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    // state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                    
                    // Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                    
                    // Put recvice data into string
                    m_Remote_Response = Encoding.ASCII.GetString(state.buffer, 0, bytesRead);
                    UpdataReviceDataToUI(m_Remote_Response);

                    // Signal that all bytes have been received.
                    receiveDone.Set();
                }
                else
                {
                    // Base on MSDN sample code, it assume after revice data, it do not need 
                    // restablish the revice callback function. So, in our application, we sure assume we always waiting new data
                    // And the connection never stop..
                    // The connection only happen in lost connection with server
                    
                    // All the data has arrived; put it in response.
                    //if (state.sb.Length > 1)
                    //{
                    //    m_Response = state.sb.ToString();
                    //}
                    // Signal that all bytes have been received.
                    //receiveDone.Set();

                    UpdataConnectionStatusToUI(true);
                    bIsConnected = false;
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        //==================================================================
        //	Function: Send
        //	Purpose:  This function is the send function, copy from MSDN
        //==================================================================
        private static void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);
            
            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }
        
        //==================================================================
        //	Function: SendCallback
        //	Purpose:  This function is the send callback function, copy from MSDN
        //==================================================================
        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;
                
                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);
                
                // Signal that all bytes have been sent.
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }








    }
}
