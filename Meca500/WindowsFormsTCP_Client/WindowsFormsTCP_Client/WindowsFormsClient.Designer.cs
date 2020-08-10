namespace WindowsFormsTCP_Client
{
    partial class WindowsFormsClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsClient));
            this.Button_Client_Connect = new System.Windows.Forms.Button();
            this.GroupBox_IP = new System.Windows.Forms.GroupBox();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.Label_Port = new System.Windows.Forms.Label();
            this.Label_IP_Field_3 = new System.Windows.Forms.Label();
            this.Label_IP_Field_2 = new System.Windows.Forms.Label();
            this.Label_IP_Field_1 = new System.Windows.Forms.Label();
            this.TextBox_IP_Field_4 = new System.Windows.Forms.TextBox();
            this.TextBox_IP_Field_3 = new System.Windows.Forms.TextBox();
            this.TextBox_IP_Field_2 = new System.Windows.Forms.TextBox();
            this.TextBox_IP_Field_1 = new System.Windows.Forms.TextBox();
            this.ListBox_Receive_Data = new System.Windows.Forms.ListBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.TextBox_Send_Data = new System.Windows.Forms.ComboBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Alignment = new System.Windows.Forms.Button();
            this.GroupBox_IP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Client_Connect
            // 
            this.Button_Client_Connect.Location = new System.Drawing.Point(413, 20);
            this.Button_Client_Connect.Name = "Button_Client_Connect";
            this.Button_Client_Connect.Size = new System.Drawing.Size(78, 44);
            this.Button_Client_Connect.TabIndex = 0;
            this.Button_Client_Connect.Text = "Connect";
            this.Button_Client_Connect.UseVisualStyleBackColor = true;
            this.Button_Client_Connect.Click += new System.EventHandler(this.Button_Client_Connect_Click);
            // 
            // GroupBox_IP
            // 
            this.GroupBox_IP.Controls.Add(this.TextBox_Port);
            this.GroupBox_IP.Controls.Add(this.Label_Port);
            this.GroupBox_IP.Controls.Add(this.Label_IP_Field_3);
            this.GroupBox_IP.Controls.Add(this.Label_IP_Field_2);
            this.GroupBox_IP.Controls.Add(this.Label_IP_Field_1);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_4);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_3);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_2);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_1);
            this.GroupBox_IP.Location = new System.Drawing.Point(12, 11);
            this.GroupBox_IP.Name = "GroupBox_IP";
            this.GroupBox_IP.Size = new System.Drawing.Size(396, 53);
            this.GroupBox_IP.TabIndex = 2;
            this.GroupBox_IP.TabStop = false;
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(329, 19);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(54, 24);
            this.TextBox_Port.TabIndex = 4;
            this.TextBox_Port.Text = "0";
            this.TextBox_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Port_KeyPress);
            // 
            // Label_Port
            // 
            this.Label_Port.Location = new System.Drawing.Point(288, 22);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(37, 22);
            this.Label_Port.TabIndex = 5;
            this.Label_Port.Text = "Port";
            this.Label_Port.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_IP_Field_3
            // 
            this.Label_IP_Field_3.AutoSize = true;
            this.Label_IP_Field_3.Location = new System.Drawing.Point(213, 19);
            this.Label_IP_Field_3.Name = "Label_IP_Field_3";
            this.Label_IP_Field_3.Size = new System.Drawing.Size(12, 18);
            this.Label_IP_Field_3.TabIndex = 4;
            this.Label_IP_Field_3.Text = ".";
            // 
            // Label_IP_Field_2
            // 
            this.Label_IP_Field_2.AutoSize = true;
            this.Label_IP_Field_2.Location = new System.Drawing.Point(142, 19);
            this.Label_IP_Field_2.Name = "Label_IP_Field_2";
            this.Label_IP_Field_2.Size = new System.Drawing.Size(12, 18);
            this.Label_IP_Field_2.TabIndex = 4;
            this.Label_IP_Field_2.Text = ".";
            // 
            // Label_IP_Field_1
            // 
            this.Label_IP_Field_1.AutoSize = true;
            this.Label_IP_Field_1.Location = new System.Drawing.Point(71, 19);
            this.Label_IP_Field_1.Name = "Label_IP_Field_1";
            this.Label_IP_Field_1.Size = new System.Drawing.Size(12, 18);
            this.Label_IP_Field_1.TabIndex = 3;
            this.Label_IP_Field_1.Text = ".";
            // 
            // TextBox_IP_Field_4
            // 
            this.TextBox_IP_Field_4.Location = new System.Drawing.Point(227, 19);
            this.TextBox_IP_Field_4.Name = "TextBox_IP_Field_4";
            this.TextBox_IP_Field_4.Size = new System.Drawing.Size(56, 24);
            this.TextBox_IP_Field_4.TabIndex = 5;
            this.TextBox_IP_Field_4.Text = "0";
            this.TextBox_IP_Field_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_4_KeyPress);
            // 
            // TextBox_IP_Field_3
            // 
            this.TextBox_IP_Field_3.Location = new System.Drawing.Point(156, 19);
            this.TextBox_IP_Field_3.Name = "TextBox_IP_Field_3";
            this.TextBox_IP_Field_3.Size = new System.Drawing.Size(56, 24);
            this.TextBox_IP_Field_3.TabIndex = 4;
            this.TextBox_IP_Field_3.Text = "0";
            this.TextBox_IP_Field_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_3_KeyPress);
            // 
            // TextBox_IP_Field_2
            // 
            this.TextBox_IP_Field_2.Location = new System.Drawing.Point(85, 19);
            this.TextBox_IP_Field_2.Name = "TextBox_IP_Field_2";
            this.TextBox_IP_Field_2.Size = new System.Drawing.Size(56, 24);
            this.TextBox_IP_Field_2.TabIndex = 4;
            this.TextBox_IP_Field_2.Text = "0";
            this.TextBox_IP_Field_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_2_KeyPress);
            // 
            // TextBox_IP_Field_1
            // 
            this.TextBox_IP_Field_1.Location = new System.Drawing.Point(13, 19);
            this.TextBox_IP_Field_1.Name = "TextBox_IP_Field_1";
            this.TextBox_IP_Field_1.Size = new System.Drawing.Size(56, 24);
            this.TextBox_IP_Field_1.TabIndex = 3;
            this.TextBox_IP_Field_1.Text = "0";
            this.TextBox_IP_Field_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_1_KeyPress);
            // 
            // ListBox_Receive_Data
            // 
            this.ListBox_Receive_Data.FormattingEnabled = true;
            this.ListBox_Receive_Data.ItemHeight = 18;
            this.ListBox_Receive_Data.Location = new System.Drawing.Point(12, 346);
            this.ListBox_Receive_Data.Name = "ListBox_Receive_Data";
            this.ListBox_Receive_Data.Size = new System.Drawing.Size(564, 94);
            this.ListBox_Receive_Data.TabIndex = 4;
            this.ListBox_Receive_Data.SelectedIndexChanged += new System.EventHandler(this.ListBox_Receive_Data_SelectedIndexChanged);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(499, 410);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(77, 30);
            this.Button_Clear.TabIndex = 5;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(496, 450);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(80, 47);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(221, 123);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(80, 43);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Activate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_ActivateRobot_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(413, 77);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(77, 43);
            this.Send.TabIndex = 9;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // TextBox_Send_Data
            // 
            this.TextBox_Send_Data.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Send_Data.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox_Send_Data.FormattingEnabled = true;
            this.TextBox_Send_Data.Items.AddRange(new object[] {
            "Delay(t)",
            "MoveJoints(,,,,,)",
            "MoveLin(,,,,,)",
            "SetBlending(p)",
            "SetCartAcc(p)",
            "SetCartAngVel(a)",
            "SetCartLinVel(v)",
            "SetJointAcc(p)",
            "SetJointVel(p)",
            "DeactivateRobot",
            "BrakesOn",
            "BrakesOff",
            "GetJoints",
            "GetPose",
            "Home",
            "ResetError",
            "ActivateRobot"});
            this.TextBox_Send_Data.Location = new System.Drawing.Point(12, 86);
            this.TextBox_Send_Data.Name = "TextBox_Send_Data";
            this.TextBox_Send_Data.Size = new System.Drawing.Size(396, 26);
            this.TextBox_Send_Data.TabIndex = 10;
            this.TextBox_Send_Data.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(496, 368);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 36);
            this.button_Load.TabIndex = 12;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 202);
            this.listBox1.TabIndex = 11;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(491, 119);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 43);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(15, 119);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 43);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(101, 119);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(80, 43);
            this.Continue.TabIndex = 7;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Alignment
            // 
            this.Alignment.Location = new System.Drawing.Point(307, 123);
            this.Alignment.Name = "Alignment";
            this.Alignment.Size = new System.Drawing.Size(80, 43);
            this.Alignment.TabIndex = 7;
            this.Alignment.Text = "Alignment";
            this.Alignment.UseVisualStyleBackColor = true;
            this.Alignment.Click += new System.EventHandler(this.Alignment_Click);
            // 
            // WindowsFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 509);
            this.ControlBox = false;
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TextBox_Send_Data);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Alignment);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.ListBox_Receive_Data);
            this.Controls.Add(this.GroupBox_IP);
            this.Controls.Add(this.Button_Client_Connect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsFormsClient";
            this.Text = "WindowsFormsClient";
            this.Load += new System.EventHandler(this.WindowsFormsClient_Load);
            this.GroupBox_IP.ResumeLayout(false);
            this.GroupBox_IP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Client_Connect;
        private System.Windows.Forms.GroupBox GroupBox_IP;
        private System.Windows.Forms.TextBox TextBox_IP_Field_4;
        private System.Windows.Forms.TextBox TextBox_IP_Field_3;
        private System.Windows.Forms.TextBox TextBox_IP_Field_2;
        private System.Windows.Forms.TextBox TextBox_IP_Field_1;
        private System.Windows.Forms.Label Label_IP_Field_3;
        private System.Windows.Forms.Label Label_IP_Field_2;
        private System.Windows.Forms.Label Label_IP_Field_1;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.ListBox ListBox_Receive_Data;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ComboBox TextBox_Send_Data;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Alignment;
    }
}

