using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using wGeneralClient; 

namespace WindowsFormsTCP_Client
{
    class Motion
    {
        private static string MLRW(double n)    //MoveLinRelWRF
        {
            return "MoveLinRelWRF(0,0," + n.ToString() + ",0,0,0)\n";
        }

        public static void Demo0811(double startpos, double rootlength, double insertion, double circle, double section, int vel)        //in each section insert a length (insertion) and repeat (circle) times until reaching rootlength.
        {
            //GeneralClient.ClientSendData("ActivateRobot");
            //GeneralClient.ClientSendData("Home");
            GeneralClient.ClientSendData("MoveJoints(0,30,-30,0,90,60)");
            GeneralClient.ClientSendData("SetCartLinVel(" +vel.ToString() + ")");
            for (int i = 0; i + insertion <= rootlength; i++)
            {
                if (i != 0)
                    GeneralClient.ClientSendData(MLRW(-section));
                else
                    GeneralClient.ClientSendData(MLRW(-startpos));
                    
                for (int j = 0; j < circle; j++)
                {
                    GeneralClient.ClientSendData(MLRW(-insertion));
                    GeneralClient.ClientSendData(MLRW(insertion));
                } 
            }
            GeneralClient.ClientSendData("SetJointVel(1)");                     //pull out the tool
            GeneralClient.ClientSendData("MoveJoints(0,30,-30,0,90,60)"); 

            GeneralClient.ClientSendData("SetJointVel(25)");                    //remove to the home
            GeneralClient.ClientSendData("MoveJoints(0,-30,30,0,90,60)");
        }
    }

}
