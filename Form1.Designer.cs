
namespace ESP_Notifycation
{
    partial class NotificationApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectStatus = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PCport = new System.Windows.Forms.TextBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverport = new System.Windows.Forms.Label();
            this.serverip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pres = new System.Windows.Forms.Label();
            this.hum = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.light = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.threshold = new System.Windows.Forms.NumericUpDown();
            this.wdt = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.recieveenable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(415, 219);
            this.richTextBox1.MaxLength = 20;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(376, 183);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "接続状態：";
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.AutoSize = true;
            this.ConnectStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnectStatus.ForeColor = System.Drawing.Color.Black;
            this.ConnectStatus.Location = new System.Drawing.Point(83, 9);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(89, 32);
            this.ConnectStatus.TabIndex = 1;
            this.ConnectStatus.Text = "未接続";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(205, 17);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "接続";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "PC側ポート番号";
            // 
            // PCport
            // 
            this.PCport.Location = new System.Drawing.Point(110, 54);
            this.PCport.Name = "PCport";
            this.PCport.Size = new System.Drawing.Size(52, 23);
            this.PCport.TabIndex = 8;
            this.PCport.Text = "9000";
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(302, 17);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 14;
            this.Disconnect.Text = "切断";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "受信データ";
            // 
            // StatusText
            // 
            this.StatusText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusText.Location = new System.Drawing.Point(10, 28);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(367, 42);
            this.StatusText.TabIndex = 17;
            this.StatusText.Text = "正常";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "ステータスクリア";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "ESP32IPアドレス";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "ESP32ポート番号";
            // 
            // serverport
            // 
            this.serverport.AutoSize = true;
            this.serverport.Location = new System.Drawing.Point(113, 97);
            this.serverport.Name = "serverport";
            this.serverport.Size = new System.Drawing.Size(27, 15);
            this.serverport.TabIndex = 19;
            this.serverport.Text = "----";
            // 
            // serverip
            // 
            this.serverip.AutoSize = true;
            this.serverip.Location = new System.Drawing.Point(280, 97);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(76, 15);
            this.serverip.TabIndex = 20;
            this.serverip.Text = "---.---.---.---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverip);
            this.groupBox1.Controls.Add(this.serverport);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PCport);
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ConnectStatus);
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 128);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接続";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusText);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(14, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ステータス";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pres);
            this.groupBox3.Controls.Add(this.hum);
            this.groupBox3.Controls.Add(this.temp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 132);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "センサ情報";
            // 
            // pres
            // 
            this.pres.AutoSize = true;
            this.pres.Location = new System.Drawing.Point(99, 100);
            this.pres.Name = "pres";
            this.pres.Size = new System.Drawing.Size(47, 15);
            this.pres.TabIndex = 5;
            this.pres.Text = "----hpa";
            // 
            // hum
            // 
            this.hum.AutoSize = true;
            this.hum.Location = new System.Drawing.Point(108, 64);
            this.hum.Name = "hum";
            this.hum.Size = new System.Drawing.Size(32, 15);
            this.hum.TabIndex = 4;
            this.hum.Text = "---%";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(102, 29);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(38, 15);
            this.temp.TabIndex = 3;
            this.temp.Text = "--.-°C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "気圧";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "湿度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "温度";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.light);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.threshold);
            this.groupBox4.Location = new System.Drawing.Point(205, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 131);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "明るさセンサ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(66, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 28);
            this.panel1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "以上";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "以下";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "トリガ";
            // 
            // light
            // 
            this.light.AutoSize = true;
            this.light.Location = new System.Drawing.Point(111, 100);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(27, 15);
            this.light.TabIndex = 3;
            this.light.Text = "----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "現在値";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "通知閾値";
            // 
            // threshold
            // 
            this.threshold.Location = new System.Drawing.Point(111, 22);
            this.threshold.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(59, 23);
            this.threshold.TabIndex = 0;
            this.threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.threshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // wdt
            // 
            this.wdt.Interval = 1000;
            this.wdt.Tick += new System.EventHandler(this.wdt_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "ログ";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(415, 28);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(375, 163);
            this.log.TabIndex = 26;
            this.log.Text = "";
            // 
            // recieveenable
            // 
            this.recieveenable.AutoSize = true;
            this.recieveenable.Location = new System.Drawing.Point(650, 197);
            this.recieveenable.Name = "recieveenable";
            this.recieveenable.Size = new System.Drawing.Size(140, 19);
            this.recieveenable.TabIndex = 27;
            this.recieveenable.Text = "受信データを表示する";
            this.recieveenable.UseVisualStyleBackColor = true;
            // 
            // NotificationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 412);
            this.Controls.Add(this.recieveenable);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationApp";
            this.Text = "　Notification App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectStatus;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PCport;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label serverport;
        private System.Windows.Forms.Label serverip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label pres;
        private System.Windows.Forms.Label hum;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label light;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown threshold;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Timer wdt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.CheckBox recieveenable;
    }
}

