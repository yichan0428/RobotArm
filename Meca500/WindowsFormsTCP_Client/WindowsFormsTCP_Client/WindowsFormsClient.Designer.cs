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
            this.GroupBox_IP = new System.Windows.Forms.GroupBox();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.Label_Port = new System.Windows.Forms.Label();
            this.ActivateBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Label_IP_Field_3 = new System.Windows.Forms.Label();
            this.Label_IP_Field_2 = new System.Windows.Forms.Label();
            this.Label_IP_Field_1 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.TextBox_IP_Field_4 = new System.Windows.Forms.TextBox();
            this.TextBox_IP_Field_3 = new System.Windows.Forms.TextBox();
            this.TextBox_IP_Field_2 = new System.Windows.Forms.TextBox();
            this.TextBox_IP_Field_1 = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimumBtn = new System.Windows.Forms.Button();
            this.ListBox_Receive_Data = new System.Windows.Forms.ListBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.TextBox_Send_Data = new System.Windows.Forms.ComboBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Alignment = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MadeTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.QuationMarkButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.QuationMark = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.RobotArm_Click = new System.Windows.Forms.Button();
            this.Introduction = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.MinimumButton = new System.Windows.Forms.Button();
            this.GroupBox_IP.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_IP
            // 
            this.GroupBox_IP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox_IP.Controls.Add(this.TextBox_Port);
            this.GroupBox_IP.Controls.Add(this.Label_Port);
            this.GroupBox_IP.Controls.Add(this.ActivateBtn);
            this.GroupBox_IP.Controls.Add(this.Title);
            this.GroupBox_IP.Controls.Add(this.Label_IP_Field_3);
            this.GroupBox_IP.Controls.Add(this.Label_IP_Field_2);
            this.GroupBox_IP.Controls.Add(this.Label_IP_Field_1);
            this.GroupBox_IP.Controls.Add(this.ConnectBtn);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_4);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_3);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_2);
            this.GroupBox_IP.Controls.Add(this.TextBox_IP_Field_1);
            this.GroupBox_IP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox_IP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox_IP.Location = new System.Drawing.Point(-17, -17);
            this.GroupBox_IP.Name = "GroupBox_IP";
            this.GroupBox_IP.Size = new System.Drawing.Size(869, 128);
            this.GroupBox_IP.TabIndex = 2;
            this.GroupBox_IP.TabStop = false;
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox_Port.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Port.Location = new System.Drawing.Point(342, 32);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(54, 26);
            this.TextBox_Port.TabIndex = 4;
            this.TextBox_Port.Text = "10000";
            this.TextBox_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Port_KeyPress);
            // 
            // Label_Port
            // 
            this.Label_Port.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Port.Location = new System.Drawing.Point(301, 33);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(37, 22);
            this.Label_Port.TabIndex = 5;
            this.Label_Port.Text = "Port";
            this.Label_Port.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActivateBtn
            // 
            this.ActivateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ActivateBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ActivateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.ActivateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivateBtn.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActivateBtn.Image = ((System.Drawing.Image)(resources.GetObject("ActivateBtn.Image")));
            this.ActivateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActivateBtn.Location = new System.Drawing.Point(561, 49);
            this.ActivateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ActivateBtn.Name = "ActivateBtn";
            this.ActivateBtn.Size = new System.Drawing.Size(120, 40);
            this.ActivateBtn.TabIndex = 1292;
            this.ActivateBtn.Text = " Activate";
            this.ActivateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActivateBtn.UseVisualStyleBackColor = false;
            this.ActivateBtn.Click += new System.EventHandler(this.Activate_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Book Antiqua", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Title.Location = new System.Drawing.Point(25, 72);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(153, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Dental Robot";
            // 
            // Label_IP_Field_3
            // 
            this.Label_IP_Field_3.AutoSize = true;
            this.Label_IP_Field_3.Location = new System.Drawing.Point(226, 32);
            this.Label_IP_Field_3.Name = "Label_IP_Field_3";
            this.Label_IP_Field_3.Size = new System.Drawing.Size(12, 18);
            this.Label_IP_Field_3.TabIndex = 4;
            this.Label_IP_Field_3.Text = ".";
            // 
            // Label_IP_Field_2
            // 
            this.Label_IP_Field_2.AutoSize = true;
            this.Label_IP_Field_2.Location = new System.Drawing.Point(155, 32);
            this.Label_IP_Field_2.Name = "Label_IP_Field_2";
            this.Label_IP_Field_2.Size = new System.Drawing.Size(12, 18);
            this.Label_IP_Field_2.TabIndex = 4;
            this.Label_IP_Field_2.Text = ".";
            // 
            // Label_IP_Field_1
            // 
            this.Label_IP_Field_1.AutoSize = true;
            this.Label_IP_Field_1.Location = new System.Drawing.Point(84, 32);
            this.Label_IP_Field_1.Name = "Label_IP_Field_1";
            this.Label_IP_Field_1.Size = new System.Drawing.Size(12, 18);
            this.Label_IP_Field_1.TabIndex = 3;
            this.Label_IP_Field_1.Text = ".";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ConnectBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ConnectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConnectBtn.Image")));
            this.ConnectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectBtn.Location = new System.Drawing.Point(426, 49);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(111, 40);
            this.ConnectBtn.TabIndex = 1292;
            this.ConnectBtn.Text = " Connect";
            this.ConnectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TextBox_IP_Field_4
            // 
            this.TextBox_IP_Field_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBox_IP_Field_4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_IP_Field_4.Location = new System.Drawing.Point(240, 32);
            this.TextBox_IP_Field_4.Name = "TextBox_IP_Field_4";
            this.TextBox_IP_Field_4.Size = new System.Drawing.Size(56, 26);
            this.TextBox_IP_Field_4.TabIndex = 5;
            this.TextBox_IP_Field_4.Text = "100";
            this.TextBox_IP_Field_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_4_KeyPress);
            // 
            // TextBox_IP_Field_3
            // 
            this.TextBox_IP_Field_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBox_IP_Field_3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_IP_Field_3.Location = new System.Drawing.Point(169, 32);
            this.TextBox_IP_Field_3.Name = "TextBox_IP_Field_3";
            this.TextBox_IP_Field_3.Size = new System.Drawing.Size(56, 26);
            this.TextBox_IP_Field_3.TabIndex = 4;
            this.TextBox_IP_Field_3.Text = "0";
            this.TextBox_IP_Field_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_3_KeyPress);
            // 
            // TextBox_IP_Field_2
            // 
            this.TextBox_IP_Field_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBox_IP_Field_2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_IP_Field_2.Location = new System.Drawing.Point(98, 32);
            this.TextBox_IP_Field_2.Name = "TextBox_IP_Field_2";
            this.TextBox_IP_Field_2.Size = new System.Drawing.Size(56, 26);
            this.TextBox_IP_Field_2.TabIndex = 4;
            this.TextBox_IP_Field_2.Text = "168";
            this.TextBox_IP_Field_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_2_KeyPress);
            // 
            // TextBox_IP_Field_1
            // 
            this.TextBox_IP_Field_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBox_IP_Field_1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_IP_Field_1.Location = new System.Drawing.Point(26, 32);
            this.TextBox_IP_Field_1.Name = "TextBox_IP_Field_1";
            this.TextBox_IP_Field_1.Size = new System.Drawing.Size(56, 26);
            this.TextBox_IP_Field_1.TabIndex = 3;
            this.TextBox_IP_Field_1.Text = "192";
            this.TextBox_IP_Field_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_IP_Field_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IP_Field_1_KeyPress);
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(741, 13);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(37, 35);
            this.CloseBtn.TabIndex = 1296;
            this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // MinimumBtn
            // 
            this.MinimumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MinimumBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimumBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MinimumBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MinimumBtn.FlatAppearance.BorderSize = 0;
            this.MinimumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinimumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimumBtn.Image")));
            this.MinimumBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimumBtn.Location = new System.Drawing.Point(691, 13);
            this.MinimumBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumBtn.Name = "MinimumBtn";
            this.MinimumBtn.Size = new System.Drawing.Size(37, 35);
            this.MinimumBtn.TabIndex = 1296;
            this.MinimumBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimumBtn.UseVisualStyleBackColor = false;
            this.MinimumBtn.Click += new System.EventHandler(this.MinimumBtn_Click);
            // 
            // ListBox_Receive_Data
            // 
            this.ListBox_Receive_Data.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListBox_Receive_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Receive_Data.FormattingEnabled = true;
            this.ListBox_Receive_Data.ItemHeight = 36;
            this.ListBox_Receive_Data.Location = new System.Drawing.Point(222, 314);
            this.ListBox_Receive_Data.Name = "ListBox_Receive_Data";
            this.ListBox_Receive_Data.Size = new System.Drawing.Size(726, 184);
            this.ListBox_Receive_Data.TabIndex = 4;
            this.ListBox_Receive_Data.SelectedIndexChanged += new System.EventHandler(this.ListBox_Receive_Data_SelectedIndexChanged);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(742, 463);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(77, 30);
            this.Button_Clear.TabIndex = 5;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(635, 521);
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
            this.TextBox_Send_Data.Location = new System.Drawing.Point(208, 530);
            this.TextBox_Send_Data.Name = "TextBox_Send_Data";
            this.TextBox_Send_Data.Size = new System.Drawing.Size(396, 26);
            this.TextBox_Send_Data.TabIndex = 10;
            this.TextBox_Send_Data.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(781, 421);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 36);
            this.button_Load.TabIndex = 12;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(299, 363);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(597, 130);
            this.listBox1.TabIndex = 11;
            // 
            // Alignment
            // 
            this.Alignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Alignment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Alignment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.Alignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alignment.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alignment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Alignment.Image = ((System.Drawing.Image)(resources.GetObject("Alignment.Image")));
            this.Alignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alignment.Location = new System.Drawing.Point(296, 231);
            this.Alignment.Margin = new System.Windows.Forms.Padding(4);
            this.Alignment.Name = "Alignment";
            this.Alignment.Size = new System.Drawing.Size(156, 46);
            this.Alignment.TabIndex = 1291;
            this.Alignment.Text = " Alignment";
            this.Alignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Alignment.UseVisualStyleBackColor = false;
            this.Alignment.Click += new System.EventHandler(this.Alignment_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start.Location = new System.Drawing.Point(688, 135);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(152, 81);
            this.Start.TabIndex = 1292;
            this.Start.Text = " Start";
            this.Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(309, 156);
            this.Home.Margin = new System.Windows.Forms.Padding(4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(123, 45);
            this.Home.TabIndex = 1292;
            this.Home.Text = " Home";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Continue.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Continue.Image = ((System.Drawing.Image)(resources.GetObject("Continue.Image")));
            this.Continue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Continue.Location = new System.Drawing.Point(769, 232);
            this.Continue.Margin = new System.Windows.Forms.Padding(4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(148, 45);
            this.Continue.TabIndex = 1292;
            this.Continue.Text = " Continue";
            this.Continue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stop.Location = new System.Drawing.Point(607, 232);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(148, 45);
            this.Stop.TabIndex = 1292;
            this.Stop.Text = "  Pause";
            this.Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MenuPanel.Controls.Add(this.MadeTime);
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.QuationMarkButton);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.SidePanel);
            this.MenuPanel.Controls.Add(this.QuationMark);
            this.MenuPanel.Controls.Add(this.SettingButton);
            this.MenuPanel.Controls.Add(this.RobotArm_Click);
            this.MenuPanel.Controls.Add(this.Introduction);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(192, 577);
            this.MenuPanel.TabIndex = 1294;
            // 
            // MadeTime
            // 
            this.MadeTime.AutoSize = true;
            this.MadeTime.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.MadeTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.MadeTime.Location = new System.Drawing.Point(7, 484);
            this.MadeTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MadeTime.Name = "MadeTime";
            this.MadeTime.Size = new System.Drawing.Size(74, 22);
            this.MadeTime.TabIndex = 3;
            this.MadeTime.Text = "ver.0.0.0";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 1071);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = " Robot Control";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // QuationMarkButton
            // 
            this.QuationMarkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuationMarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMarkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuationMarkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuationMarkButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.QuationMarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuationMarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuationMarkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuationMarkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuationMarkButton.Location = new System.Drawing.Point(29, 1000);
            this.QuationMarkButton.Margin = new System.Windows.Forms.Padding(4);
            this.QuationMarkButton.Name = "QuationMarkButton";
            this.QuationMarkButton.Size = new System.Drawing.Size(37, 35);
            this.QuationMarkButton.TabIndex = 1;
            this.QuationMarkButton.Text = "?";
            this.QuationMarkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuationMarkButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, -28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.SidePanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SidePanel.Location = new System.Drawing.Point(185, 266);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 51);
            this.SidePanel.TabIndex = 0;
            // 
            // QuationMark
            // 
            this.QuationMark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuationMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuationMark.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuationMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.QuationMark.FlatAppearance.BorderSize = 0;
            this.QuationMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuationMark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuationMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuationMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuationMark.Location = new System.Drawing.Point(16, 1110);
            this.QuationMark.Margin = new System.Windows.Forms.Padding(4);
            this.QuationMark.Name = "QuationMark";
            this.QuationMark.Size = new System.Drawing.Size(44, 42);
            this.QuationMark.TabIndex = 3;
            this.QuationMark.Text = "?";
            this.QuationMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuationMark.UseVisualStyleBackColor = false;
            // 
            // SettingButton
            // 
            this.SettingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SettingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(0, 357);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(192, 51);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = "  Setting";
            this.SettingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // RobotArm_Click
            // 
            this.RobotArm_Click.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RobotArm_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RobotArm_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RobotArm_Click.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RobotArm_Click.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RobotArm_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RobotArm_Click.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotArm_Click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RobotArm_Click.Image = ((System.Drawing.Image)(resources.GetObject("RobotArm_Click.Image")));
            this.RobotArm_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RobotArm_Click.Location = new System.Drawing.Point(1, 266);
            this.RobotArm_Click.Margin = new System.Windows.Forms.Padding(4);
            this.RobotArm_Click.Name = "RobotArm_Click";
            this.RobotArm_Click.Size = new System.Drawing.Size(188, 51);
            this.RobotArm_Click.TabIndex = 4;
            this.RobotArm_Click.Text = "  Robot Control";
            this.RobotArm_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RobotArm_Click.UseVisualStyleBackColor = false;
            this.RobotArm_Click.Click += new System.EventHandler(this.RobotArm_Click_Click);
            // 
            // Introduction
            // 
            this.Introduction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Introduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Introduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Introduction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Introduction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Introduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Introduction.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Introduction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Introduction.Image = ((System.Drawing.Image)(resources.GetObject("Introduction.Image")));
            this.Introduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Introduction.Location = new System.Drawing.Point(1, 172);
            this.Introduction.Margin = new System.Windows.Forms.Padding(4);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(189, 51);
            this.Introduction.TabIndex = 4;
            this.Introduction.Text = "  Introduction";
            this.Introduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Introduction.UseVisualStyleBackColor = false;
            this.Introduction.Click += new System.EventHandler(this.Introduction_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TitlePanel.Controls.Add(this.MinimumBtn);
            this.TitlePanel.Controls.Add(this.CloseBtn);
            this.TitlePanel.Controls.Add(this.button3);
            this.TitlePanel.Controls.Add(this.MinimumButton);
            this.TitlePanel.Controls.Add(this.GroupBox_IP);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(192, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(782, 101);
            this.TitlePanel.TabIndex = 1295;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1348, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 35);
            this.button3.TabIndex = 0;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MinimumButton
            // 
            this.MinimumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MinimumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimumButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MinimumButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MinimumButton.FlatAppearance.BorderSize = 0;
            this.MinimumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MinimumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimumButton.Image")));
            this.MinimumButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimumButton.Location = new System.Drawing.Point(1304, 32);
            this.MinimumButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumButton.Name = "MinimumButton";
            this.MinimumButton.Size = new System.Drawing.Size(37, 35);
            this.MinimumButton.TabIndex = 0;
            this.MinimumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimumButton.UseVisualStyleBackColor = false;
            // 
            // WindowsFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(974, 577);
            this.ControlBox = false;
            this.Controls.Add(this.ListBox_Receive_Data);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Alignment);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TextBox_Send_Data);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.button_Load);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsFormsClient";
            this.Text = "NASA_Dental Robot";
            this.Load += new System.EventHandler(this.WindowsFormsClient_Load);
            this.GroupBox_IP.ResumeLayout(false);
            this.GroupBox_IP.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ComboBox TextBox_Send_Data;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Alignment;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button QuationMarkButton;
        private System.Windows.Forms.Label MadeTime;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button QuationMark;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button MinimumButton;
        private System.Windows.Forms.Button MinimumBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button ActivateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RobotArm_Click;
        private System.Windows.Forms.Button Introduction;
    }
}

