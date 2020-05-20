namespace SerComm
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portName = new System.Windows.Forms.ComboBox();
            this.bauderate_ = new System.Windows.Forms.ComboBox();
            this.parity_ = new System.Windows.Forms.ComboBox();
            this.databits_ = new System.Windows.Forms.ComboBox();
            this.stopbits_ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connectbtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.Readbox = new System.Windows.Forms.RichTextBox();
            this.sendbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Comport_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stopbits_);
            this.groupBox1.Controls.Add(this.databits_);
            this.groupBox1.Controls.Add(this.parity_);
            this.groupBox1.Controls.Add(this.bauderate_);
            this.groupBox1.Controls.Add(this.portName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // portName
            // 
            this.portName.FormattingEnabled = true;
            this.portName.Location = new System.Drawing.Point(93, 27);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(121, 23);
            this.portName.TabIndex = 2;
            this.portName.Text = "Select Port Name";
            this.portName.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // bauderate_
            // 
            this.bauderate_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bauderate_.FormattingEnabled = true;
            this.bauderate_.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.bauderate_.Location = new System.Drawing.Point(93, 65);
            this.bauderate_.Name = "bauderate_";
            this.bauderate_.Size = new System.Drawing.Size(121, 23);
            this.bauderate_.TabIndex = 3;
            // 
            // parity_
            // 
            this.parity_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity_.FormattingEnabled = true;
            this.parity_.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.parity_.Location = new System.Drawing.Point(93, 103);
            this.parity_.Name = "parity_";
            this.parity_.Size = new System.Drawing.Size(121, 23);
            this.parity_.TabIndex = 4;
            // 
            // databits_
            // 
            this.databits_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databits_.FormattingEnabled = true;
            this.databits_.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databits_.Location = new System.Drawing.Point(93, 142);
            this.databits_.Name = "databits_";
            this.databits_.Size = new System.Drawing.Size(121, 23);
            this.databits_.TabIndex = 5;
            // 
            // stopbits_
            // 
            this.stopbits_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbits_.FormattingEnabled = true;
            this.stopbits_.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.stopbits_.Location = new System.Drawing.Point(93, 181);
            this.stopbits_.Name = "stopbits_";
            this.stopbits_.Size = new System.Drawing.Size(121, 23);
            this.stopbits_.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parity";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop Bits";
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(124, 273);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(92, 52);
            this.connectbtn.TabIndex = 10;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(254, 302);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(82, 23);
            this.sendbtn.TabIndex = 11;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(544, 302);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(82, 23);
            this.clearbtn.TabIndex = 12;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Readbox
            // 
            this.Readbox.Location = new System.Drawing.Point(242, 25);
            this.Readbox.Name = "Readbox";
            this.Readbox.ReadOnly = true;
            this.Readbox.Size = new System.Drawing.Size(429, 204);
            this.Readbox.TabIndex = 13;
            this.Readbox.Text = "";
            // 
            // sendbox
            // 
            this.sendbox.Location = new System.Drawing.Point(303, 255);
            this.sendbox.Name = "sendbox";
            this.sendbox.Size = new System.Drawing.Size(368, 20);
            this.sendbox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Send Data";
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(21, 288);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 16;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 362);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendbox);
            this.Controls.Add(this.Readbox);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox portName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stopbits_;
        private System.Windows.Forms.ComboBox databits_;
        private System.Windows.Forms.ComboBox parity_;
        private System.Windows.Forms.ComboBox bauderate_;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.RichTextBox Readbox;
        private System.Windows.Forms.TextBox sendbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshbtn;
    }
}

