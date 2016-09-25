namespace RTAF_Project
{
    partial class Measurement
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
            this.bnt_recentlyInfo = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_avgTime = new System.Windows.Forms.Label();
            this.selectSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sound = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_recentlyInfo
            // 
            this.bnt_recentlyInfo.Location = new System.Drawing.Point(234, 4);
            this.bnt_recentlyInfo.Name = "bnt_recentlyInfo";
            this.bnt_recentlyInfo.Size = new System.Drawing.Size(109, 23);
            this.bnt_recentlyInfo.TabIndex = 0;
            this.bnt_recentlyInfo.Text = "최근기록 보기";
            this.bnt_recentlyInfo.UseVisualStyleBackColor = true;
            this.bnt_recentlyInfo.Click += new System.EventHandler(this.bnt_recentlyInfo_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(97, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(131, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "환자 정보 : ";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(24, 31);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(319, 312);
            this.statusBox.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(349, 62);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(190, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "측정시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(349, 102);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(190, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "측정정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "평균 속도(초) : ";
            // 
            // lab_avgTime
            // 
            this.lab_avgTime.AutoSize = true;
            this.lab_avgTime.Location = new System.Drawing.Point(444, 31);
            this.lab_avgTime.Name = "lab_avgTime";
            this.lab_avgTime.Size = new System.Drawing.Size(11, 12);
            this.lab_avgTime.TabIndex = 7;
            this.lab_avgTime.Text = "0";
            // 
            // selectSpeed
            // 
            this.selectSpeed.Location = new System.Drawing.Point(396, 190);
            this.selectSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.selectSpeed.Name = "selectSpeed";
            this.selectSpeed.Size = new System.Drawing.Size(143, 21);
            this.selectSpeed.TabIndex = 8;
            this.selectSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "비율 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "단위 (%)";
            // 
            // btn_sound
            // 
            this.btn_sound.Enabled = false;
            this.btn_sound.Location = new System.Drawing.Point(464, 217);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(75, 23);
            this.btn_sound.TabIndex = 11;
            this.btn_sound.Text = "소리 출력";
            this.btn_sound.UseVisualStyleBackColor = true;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(349, 143);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(190, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "측정기록 저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Measurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 355);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_sound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectSpeed);
            this.Controls.Add(this.lab_avgTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.bnt_recentlyInfo);
            this.Name = "Measurement";
            this.Text = "검사";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Measurement_FormClosing);
            this.Load += new System.EventHandler(this.Measurement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_recentlyInfo;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_avgTime;
        private System.Windows.Forms.NumericUpDown selectSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sound;
        private System.Windows.Forms.Button btn_save;
    }
}