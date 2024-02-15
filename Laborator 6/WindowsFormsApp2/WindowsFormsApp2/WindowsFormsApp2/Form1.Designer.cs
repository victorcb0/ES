namespace WindowsFormsApp2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_sensor33 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sensor22 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_sensor11 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sensor3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_sensor2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sensor1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.ProgressBar_statusCom = new System.Windows.Forms.ProgressBar();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tabel = new System.Windows.Forms.Button();
            this.Tabel1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_sensor33);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_sensor22);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_sensor11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_sensor3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_sensor2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_sensor1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 333);
            this.panel1.TabIndex = 0;
            // 
            // textBox_sensor33
            // 
            this.textBox_sensor33.BackColor = System.Drawing.Color.White;
            this.textBox_sensor33.Location = new System.Drawing.Point(709, 194);
            this.textBox_sensor33.Name = "textBox_sensor33";
            this.textBox_sensor33.ReadOnly = true;
            this.textBox_sensor33.Size = new System.Drawing.Size(58, 22);
            this.textBox_sensor33.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "INDEXUL DE CALDURA:";
            // 
            // textBox_sensor22
            // 
            this.textBox_sensor22.BackColor = System.Drawing.Color.White;
            this.textBox_sensor22.Location = new System.Drawing.Point(398, 197);
            this.textBox_sensor22.Name = "textBox_sensor22";
            this.textBox_sensor22.ReadOnly = true;
            this.textBox_sensor22.Size = new System.Drawing.Size(58, 22);
            this.textBox_sensor22.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "UMIDITATEA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "TEMPERATURA:";
            // 
            // textBox_sensor11
            // 
            this.textBox_sensor11.BackColor = System.Drawing.Color.White;
            this.textBox_sensor11.Location = new System.Drawing.Point(194, 197);
            this.textBox_sensor11.Name = "textBox_sensor11";
            this.textBox_sensor11.ReadOnly = true;
            this.textBox_sensor11.Size = new System.Drawing.Size(58, 22);
            this.textBox_sensor11.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(20, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "EXTERIOR";
            // 
            // textBox_sensor3
            // 
            this.textBox_sensor3.BackColor = System.Drawing.Color.White;
            this.textBox_sensor3.Location = new System.Drawing.Point(709, 51);
            this.textBox_sensor3.Name = "textBox_sensor3";
            this.textBox_sensor3.ReadOnly = true;
            this.textBox_sensor3.Size = new System.Drawing.Size(58, 22);
            this.textBox_sensor3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "INDEXUL DE CALDURA:";
            // 
            // textBox_sensor2
            // 
            this.textBox_sensor2.BackColor = System.Drawing.Color.White;
            this.textBox_sensor2.Location = new System.Drawing.Point(381, 48);
            this.textBox_sensor2.Name = "textBox_sensor2";
            this.textBox_sensor2.ReadOnly = true;
            this.textBox_sensor2.Size = new System.Drawing.Size(58, 22);
            this.textBox_sensor2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "UMIDITATEA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "INTERIOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "TEMPERATURA:";
            // 
            // textBox_sensor1
            // 
            this.textBox_sensor1.BackColor = System.Drawing.Color.White;
            this.textBox_sensor1.Location = new System.Drawing.Point(177, 48);
            this.textBox_sensor1.Name = "textBox_sensor1";
            this.textBox_sensor1.ReadOnly = true;
            this.textBox_sensor1.Size = new System.Drawing.Size(58, 22);
            this.textBox_sensor1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.ProgressBar_statusCom);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_ComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Setting";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(603, 62);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ProgressBar_statusCom
            // 
            this.ProgressBar_statusCom.Location = new System.Drawing.Point(12, 25);
            this.ProgressBar_statusCom.Name = "ProgressBar_statusCom";
            this.ProgressBar_statusCom.Size = new System.Drawing.Size(89, 80);
            this.ProgressBar_statusCom.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(486, 62);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(383, 62);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(197, 75);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE: ";
            // 
            // comboBox_ComPort
            // 
            this.comboBox_ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ComPort.FormattingEnabled = true;
            this.comboBox_ComPort.Location = new System.Drawing.Point(197, 39);
            this.comboBox_ComPort.Name = "comboBox_ComPort";
            this.comboBox_ComPort.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ComPort.TabIndex = 1;
            this.comboBox_ComPort.DropDown += new System.EventHandler(this.comboBox_ComPort_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT: ";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tabel
            // 
            this.Tabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabel.Location = new System.Drawing.Point(123, 360);
            this.Tabel.Name = "Tabel";
            this.Tabel.Size = new System.Drawing.Size(271, 38);
            this.Tabel.TabIndex = 7;
            this.Tabel.Text = "Temperatura Interior TABEL";
            this.Tabel.UseVisualStyleBackColor = true;
            this.Tabel.Click += new System.EventHandler(this.Tabel_Click);
            // 
            // Tabel1
            // 
            this.Tabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabel1.Location = new System.Drawing.Point(415, 360);
            this.Tabel1.Name = "Tabel1";
            this.Tabel1.Size = new System.Drawing.Size(277, 38);
            this.Tabel1.TabIndex = 8;
            this.Tabel1.Text = "Temperatura Exterior TABEL";
            this.Tabel1.UseVisualStyleBackColor = true;
            this.Tabel1.Click += new System.EventHandler(this.Tabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 512);
            this.Controls.Add(this.Tabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ProgressBar ProgressBar_statusCom;
        private System.Windows.Forms.TextBox textBox_sensor1;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_sensor2;
        private System.Windows.Forms.TextBox textBox_sensor33;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_sensor22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_sensor11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sensor3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Tabel;
        private System.Windows.Forms.Button Tabel1;
    }
}

