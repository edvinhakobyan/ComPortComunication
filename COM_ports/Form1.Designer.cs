namespace COM_ports
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_OPEN = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboB_COMPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboB_ParityBits = new System.Windows.Forms.ComboBox();
            this.comboB_StopBits = new System.Windows.Forms.ComboBox();
            this.comboB_DataBits = new System.Windows.Forms.ComboBox();
            this.comboB_BaudRate = new System.Windows.Forms.ComboBox();
            this.Dpanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_CLOSE);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.button_OPEN);
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboB_COMPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboB_ParityBits);
            this.groupBox1.Controls.Add(this.comboB_StopBits);
            this.groupBox1.Controls.Add(this.comboB_DataBits);
            this.groupBox1.Controls.Add(this.comboB_BaudRate);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Cotrol";
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.Location = new System.Drawing.Point(99, 162);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(75, 23);
            this.button_CLOSE.TabIndex = 1;
            this.button_CLOSE.Text = "CLOSE";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.Button_CLOSE_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 191);
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(193, 10);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            // 
            // button_OPEN
            // 
            this.button_OPEN.Location = new System.Drawing.Point(18, 162);
            this.button_OPEN.Name = "button_OPEN";
            this.button_OPEN.Size = new System.Drawing.Size(75, 23);
            this.button_OPEN.TabIndex = 0;
            this.button_OPEN.Text = "OPEN";
            this.button_OPEN.UseVisualStyleBackColor = true;
            this.button_OPEN.Click += new System.EventHandler(this.Button_OPEN_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Refresh.BackgroundImage")));
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Refresh.ImageKey = "(none)";
            this.button_Refresh.Location = new System.Drawing.Point(178, 162);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(33, 23);
            this.button_Refresh.TabIndex = 5;
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits";
            // 
            // comboB_COMPort
            // 
            this.comboB_COMPort.AllowDrop = true;
            this.comboB_COMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_COMPort.FormattingEnabled = true;
            this.comboB_COMPort.Location = new System.Drawing.Point(90, 25);
            this.comboB_COMPort.Name = "comboB_COMPort";
            this.comboB_COMPort.Size = new System.Drawing.Size(121, 21);
            this.comboB_COMPort.Sorted = true;
            this.comboB_COMPort.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // comboB_ParityBits
            // 
            this.comboB_ParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_ParityBits.FormattingEnabled = true;
            this.comboB_ParityBits.Location = new System.Drawing.Point(90, 125);
            this.comboB_ParityBits.Name = "comboB_ParityBits";
            this.comboB_ParityBits.Size = new System.Drawing.Size(121, 21);
            this.comboB_ParityBits.TabIndex = 4;
            // 
            // comboB_StopBits
            // 
            this.comboB_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_StopBits.FormattingEnabled = true;
            this.comboB_StopBits.Location = new System.Drawing.Point(90, 100);
            this.comboB_StopBits.Name = "comboB_StopBits";
            this.comboB_StopBits.Size = new System.Drawing.Size(121, 21);
            this.comboB_StopBits.TabIndex = 3;
            // 
            // comboB_DataBits
            // 
            this.comboB_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_DataBits.FormattingEnabled = true;
            this.comboB_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboB_DataBits.Location = new System.Drawing.Point(90, 75);
            this.comboB_DataBits.Name = "comboB_DataBits";
            this.comboB_DataBits.Size = new System.Drawing.Size(121, 21);
            this.comboB_DataBits.TabIndex = 2;
            // 
            // comboB_BaudRate
            // 
            this.comboB_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_BaudRate.FormattingEnabled = true;
            this.comboB_BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400"});
            this.comboB_BaudRate.Location = new System.Drawing.Point(90, 50);
            this.comboB_BaudRate.Name = "comboB_BaudRate";
            this.comboB_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboB_BaudRate.TabIndex = 1;
            // 
            // Dpanel
            // 
            this.Dpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dpanel.Location = new System.Drawing.Point(249, 13);
            this.Dpanel.Name = "Dpanel";
            this.Dpanel.Size = new System.Drawing.Size(500, 500);
            this.Dpanel.TabIndex = 2;
            this.Dpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Dpanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Receive X = ;Y =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "-------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dpanel);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Arduino Connect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboB_COMPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboB_ParityBits;
        private System.Windows.Forms.ComboBox comboB_StopBits;
        private System.Windows.Forms.ComboBox comboB_DataBits;
        private System.Windows.Forms.ComboBox comboB_BaudRate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.Button button_OPEN;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Panel Dpanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

