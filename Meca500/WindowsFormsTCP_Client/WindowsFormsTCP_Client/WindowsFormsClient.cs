using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using wGeneralClient;

namespace WindowsFormsTCP_Client
{
    public partial class WindowsFormsClient : Form
    {

        //===============================================================
        //===============================================================
        //寫入文字檔案功能函式。
        public void StreamWriterTextFile_Fn(string strContent_Val, string strFilePath_Val)
        {
            //建立物件案例。(取得文字檔案寫入案例)
            StreamWriter objStreamWriter = new StreamWriter(strFilePath_Val);
            //將字串內容寫入緩衝區。
            objStreamWriter.Write(strContent_Val);
            //釋放使用中的資源。
            objStreamWriter.Close();
            objStreamWriter.Dispose();
        }

        //讀取文字檔案功能函式。
        public string StreamReadTextFile_Fn(string strFilePath_Val)
        {
            //當要存取的檔案存在時。
            if (File.Exists(strFilePath_Val) == true)
            {
                //建立物件案例。(取得文字檔案讀取案例)
                StreamReader objStreamReader = new StreamReader(strFilePath_Val, Encoding.UTF8);
                //將字串內容從頭到尾讀取至緩衝區。
                string strText = objStreamReader.ReadToEnd();
                //釋放使用中的資源。
                objStreamReader.Close();
                objStreamReader.Dispose();
                //傳回結果。
                return strText;
            }
            else
            {
                //傳回結果。
                return null;
            }
        }
        //===============================================================
        //===============================================================
        /// </summary>
        public WindowsFormsClient()
        {
            InitializeComponent();
            
            //Initial window position setting
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = (Point)new Size(2430, 470); 
        }

        //==================================================================
        //	Purpose:  This function is used to updata revice on the ui, when the communication be revice data
        //==================================================================
        public delegate void UIOperationInfomationUpdataUI(string strReviceData);
        public void UIMonitorOperationToDoUpdataUI(string strReviceData)
        {
            if (this.InvokeRequired)
            {
                UIOperationInfomationUpdataUI myUpdateOperationUpdataUI = new UIOperationInfomationUpdataUI(UIMonitorOperationToDoUpdataUI);
                this.Invoke(myUpdateOperationUpdataUI, strReviceData);
            }
            else
            {
                ReciveData(strReviceData);
            }
        }//Revice Data

        //==================================================================
        //	Purpose:  This function is used to updata connection status on the ui, when the communication lost
        //==================================================================
        public delegate void UIOperationInfomationUpdataUI_ConnectionStatus(bool bIsConnection);
        public void UIMonitorOperationToDoUpdataUI_ConnectionStatus(bool bIsConnection)
        {
            if (this.InvokeRequired)
            {
                UIOperationInfomationUpdataUI_ConnectionStatus myUpdateOperationUpdataUI_ConnectionStatus = new UIOperationInfomationUpdataUI_ConnectionStatus(UIMonitorOperationToDoUpdataUI_ConnectionStatus);
                this.Invoke(myUpdateOperationUpdataUI_ConnectionStatus, bIsConnection);
            }
            else
            {
                ConnectBtn.Text = "Connect";
                Disconnect();
            }
        }//Lost connection with server

        public void InitialClientObject()
        {
            GeneralClient.ClientUpdataUI(this);
        }

        public void InitialUI()
        {
            TextBox_IP_Field_1.Text = "192";
            TextBox_IP_Field_2.Text = "168";
            TextBox_IP_Field_3.Text = "0";
            TextBox_IP_Field_4.Text = "100";

            TextBox_Port.Text = "10000";

            TextBox_Send_Data.Enabled = false;
            ActivateBtn.Enabled = false;
        }

        private void WindowsFormsClient_Load(object sender, EventArgs e)
        {
            InitialUI();

            InitialClientObject();
        }

        public void Connected()
        {
            bool bEnable = false;
            TextBox_IP_Field_1.Enabled = bEnable;
            TextBox_IP_Field_2.Enabled = bEnable;
            TextBox_IP_Field_3.Enabled = bEnable;
            TextBox_IP_Field_4.Enabled = bEnable;
            TextBox_Port.Enabled = bEnable;

            ConnectBtn.Enabled = !bEnable;
            TextBox_Send_Data.Enabled = !bEnable;
            ActivateBtn.Enabled = !bEnable;
        }

        public void Disconnect()
        {
            bool bEnable = true;
            TextBox_IP_Field_1.Enabled = bEnable;
            TextBox_IP_Field_2.Enabled = bEnable;
            TextBox_IP_Field_3.Enabled = bEnable;
            TextBox_IP_Field_4.Enabled = bEnable;

            TextBox_Port.Enabled = bEnable;
            ConnectBtn.Enabled = bEnable;

            TextBox_Send_Data.Enabled = !bEnable;
            ActivateBtn.Enabled = !bEnable;
        }

        public void Connecting(bool bLockUI)
        {
            if (bLockUI)
            {
                bool bEnable = true;
                TextBox_IP_Field_1.Enabled = bEnable;
                TextBox_IP_Field_2.Enabled = bEnable;
                TextBox_IP_Field_3.Enabled = bEnable;
                TextBox_IP_Field_4.Enabled = bEnable;

                TextBox_Port.Enabled = bEnable;

                ConnectBtn.Enabled = bEnable;

                TextBox_Send_Data.Enabled = bEnable;
                ActivateBtn.Enabled = bEnable;
            }
            else
            {
                bool bEnable = false;
                TextBox_IP_Field_1.Enabled = bEnable;
                TextBox_IP_Field_2.Enabled = bEnable;
                TextBox_IP_Field_3.Enabled = bEnable;
                TextBox_IP_Field_4.Enabled = bEnable;

                TextBox_Port.Enabled = bEnable;

                ConnectBtn.Enabled = bEnable;

                TextBox_Send_Data.Enabled = bEnable;
                ActivateBtn.Enabled = bEnable;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Connecting(false);

            // Try to get data from forms.
            string strIP_Field1 = TextBox_IP_Field_1.Text;
            string strIP_Field2 = TextBox_IP_Field_2.Text;
            string strIP_Field3 = TextBox_IP_Field_3.Text;
            string strIP_Field4 = TextBox_IP_Field_4.Text;
            string strPort = TextBox_Port.Text;
            int iPort = Convert.ToInt32(strPort);
            
            // OK, to do the job
            bool bCurrentStatus = false; 
            if (strIP_Field1 == "" || strIP_Field2 == "" || strIP_Field3 == "" || strIP_Field4 == "")
            {
                string strMsg = "";
                strMsg = "Please fill the forms";
                MessageBox.Show(strMsg);
            }
            else
            {
                if (GeneralClient.ClientIsConnected())
                {
                    bCurrentStatus = true;
                    // Current status is connected
                    // So, shutdown connection, close it.
                    
                    GeneralClient.ClientDisconnect();
                }
                else
                {
                    bCurrentStatus = false;
                    // Current status is disconnected
                    // So, we try to connected.
                    string strIP = string.Format("{0}.{1}.{2}.{3}", strIP_Field1, strIP_Field2, strIP_Field3, strIP_Field4);
                    GeneralClient.ClientConnect(strIP, iPort);
                }

                int iTimeout = 3; // secs
                int iStart = Environment.TickCount;
                int iEnd = 0;
                while (true)
                {
                    // Wait connection statuc is ready
                    if (bCurrentStatus)
                    {
                        if (GeneralClient.ClientIsConnected() == false)
                            break;
                    }
                    else
                    {
                        if (GeneralClient.ClientIsConnected() == true)
                            break;
                    }



                    iEnd = Environment.TickCount;
                    if ((iEnd - iStart) > (iTimeout * 1000))
                        break;

                    Application.DoEvents();

                    Thread.Sleep(10);
                }
            }// Valid form  

            // Redraw client button status
            if (GeneralClient.ClientIsConnected())
            {
                ConnectBtn.Text = "Disonnect";
                Connected();
            }
            else
            {
                ConnectBtn.Text = "Connect";
                Disconnect();
            }
        }



        public void ReciveData(string strData)
        {
            strData.Trim();
            if (strData != "")
                ListBox_Receive_Data.Items.Insert(0, strData);
        }

        private void TextBox_IP_Field_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void TextBox_IP_Field_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox_IP_Field_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox_IP_Field_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ListBox_Receive_Data.Items.Clear();
        }

        private void ListBox_Receive_Data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            if (ActivateBtn.Text == " Activate")        //watch out the space
            {
                GeneralClient.ClientSendData("ActivateRobot");
                GeneralClient.ClientSendData("Home");
                ActivateBtn.Text = " Deactivate";
            }
            else if (ActivateBtn.Text == " Deactivate")
            {
                GeneralClient.ClientSendData("DeactivateRobot");
                ActivateBtn.Text = " Activate";
            }

        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            string strSendData = "";
            strSendData = TextBox_Send_Data.Text;
            strSendData.Trim();

            if (strSendData != "")
                GeneralClient.ClientSendData(strSendData);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            //宣告字串變數。(要存取的檔案所在位置)
            string strFilePath = (@"D:\work\solomon\MecaDemic\read.txt");
            //將文字檔案的內容輸出在畫面上。
            MessageBox.Show(StreamReadTextFile_Fn(strFilePath));
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            GeneralClient.ClientSendData("PauseMotion");
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            GeneralClient.ClientSendData("ResumeMotion");
        }

        private void Home_Click(object sender, EventArgs e)
        {
            GeneralClient.ClientSendData("MoveJoints(0,-30,30,0,90,60)");
        }
        private void Alignment_Click(object sender, EventArgs e)
        {
            GeneralClient.ClientSendData("MoveJoints(0,30,-30,0,90,60)");
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Motion.Demo0811(9, 5, 1, 15, 1, 1); //4, 8, 2, 10, 2, 1
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimumBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingButton.Height;
            SidePanel.Top = SettingButton.Top;
        }

        private void Introduction_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Introduction.Height;
            SidePanel.Top = Introduction.Top;
        }

        private void RobotArm_Click_Click(object sender, EventArgs e)
        {
            SidePanel.Height = RobotArm_Click.Height;
            SidePanel.Top = RobotArm_Click.Top;
        }
    }
}
