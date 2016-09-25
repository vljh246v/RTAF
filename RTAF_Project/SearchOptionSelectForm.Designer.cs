namespace RTAF_Project
{
    partial class SearchOptionSelectForm
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
            this.check_name = new System.Windows.Forms.CheckBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pick_birthStart = new System.Windows.Forms.DateTimePicker();
            this.pick_birthEnd = new System.Windows.Forms.DateTimePicker();
            this.check_birth = new System.Windows.Forms.CheckBox();
            this.check_Hemi = new System.Windows.Forms.CheckBox();
            this.check_HemiLeft = new System.Windows.Forms.CheckBox();
            this.check_HemiRight = new System.Windows.Forms.CheckBox();
            this.check_sex = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbtn_female = new System.Windows.Forms.RadioButton();
            this.radbtn_male = new System.Windows.Forms.RadioButton();
            this.check_expDay = new System.Windows.Forms.CheckBox();
            this.pick_expStart = new System.Windows.Forms.DateTimePicker();
            this.pick_expEnd = new System.Windows.Forms.DateTimePicker();
            this.check_height = new System.Windows.Forms.CheckBox();
            this.pick_heightStart = new System.Windows.Forms.NumericUpDown();
            this.pick_heightEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pick_ageEnd = new System.Windows.Forms.NumericUpDown();
            this.pick_ageStart = new System.Windows.Forms.NumericUpDown();
            this.check_age = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pick_weightEnd = new System.Windows.Forms.NumericUpDown();
            this.pick_weightStart = new System.Windows.Forms.NumericUpDown();
            this.check_weight = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pick_heightStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_heightEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_ageEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_ageStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_weightEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_weightStart)).BeginInit();
            this.SuspendLayout();
            // 
            // check_name
            // 
            this.check_name.AutoSize = true;
            this.check_name.Location = new System.Drawing.Point(12, 40);
            this.check_name.Name = "check_name";
            this.check_name.Size = new System.Drawing.Size(48, 16);
            this.check_name.TabIndex = 1;
            this.check_name.Text = "이름";
            this.check_name.UseVisualStyleBackColor = true;
            this.check_name.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(135, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(154, 21);
            this.txt_name.TabIndex = 2;
            // 
            // pick_birthStart
            // 
            this.pick_birthStart.Enabled = false;
            this.pick_birthStart.Location = new System.Drawing.Point(135, 62);
            this.pick_birthStart.Name = "pick_birthStart";
            this.pick_birthStart.Size = new System.Drawing.Size(154, 21);
            this.pick_birthStart.TabIndex = 3;
            // 
            // pick_birthEnd
            // 
            this.pick_birthEnd.Enabled = false;
            this.pick_birthEnd.Location = new System.Drawing.Point(330, 62);
            this.pick_birthEnd.Name = "pick_birthEnd";
            this.pick_birthEnd.Size = new System.Drawing.Size(154, 21);
            this.pick_birthEnd.TabIndex = 5;
            // 
            // check_birth
            // 
            this.check_birth.AutoSize = true;
            this.check_birth.Location = new System.Drawing.Point(12, 67);
            this.check_birth.Name = "check_birth";
            this.check_birth.Size = new System.Drawing.Size(72, 16);
            this.check_birth.TabIndex = 6;
            this.check_birth.Text = "생년월일";
            this.check_birth.UseVisualStyleBackColor = true;
            this.check_birth.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // check_Hemi
            // 
            this.check_Hemi.AutoSize = true;
            this.check_Hemi.Location = new System.Drawing.Point(12, 130);
            this.check_Hemi.Name = "check_Hemi";
            this.check_Hemi.Size = new System.Drawing.Size(84, 16);
            this.check_Hemi.TabIndex = 8;
            this.check_Hemi.Text = "Hemi_Side";
            this.check_Hemi.UseVisualStyleBackColor = true;
            this.check_Hemi.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // check_HemiLeft
            // 
            this.check_HemiLeft.AutoSize = true;
            this.check_HemiLeft.Enabled = false;
            this.check_HemiLeft.Location = new System.Drawing.Point(135, 130);
            this.check_HemiLeft.Name = "check_HemiLeft";
            this.check_HemiLeft.Size = new System.Drawing.Size(36, 16);
            this.check_HemiLeft.TabIndex = 9;
            this.check_HemiLeft.Text = "좌";
            this.check_HemiLeft.UseVisualStyleBackColor = true;
            // 
            // check_HemiRight
            // 
            this.check_HemiRight.AutoSize = true;
            this.check_HemiRight.Enabled = false;
            this.check_HemiRight.Location = new System.Drawing.Point(182, 130);
            this.check_HemiRight.Name = "check_HemiRight";
            this.check_HemiRight.Size = new System.Drawing.Size(36, 16);
            this.check_HemiRight.TabIndex = 10;
            this.check_HemiRight.Text = "우";
            this.check_HemiRight.UseVisualStyleBackColor = true;
            // 
            // check_sex
            // 
            this.check_sex.AutoSize = true;
            this.check_sex.Location = new System.Drawing.Point(12, 179);
            this.check_sex.Name = "check_sex";
            this.check_sex.Size = new System.Drawing.Size(48, 16);
            this.check_sex.TabIndex = 11;
            this.check_sex.Text = "성별";
            this.check_sex.UseVisualStyleBackColor = true;
            this.check_sex.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtn_female);
            this.groupBox1.Controls.Add(this.radbtn_male);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(135, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 40);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // radbtn_female
            // 
            this.radbtn_female.AutoSize = true;
            this.radbtn_female.Enabled = false;
            this.radbtn_female.Location = new System.Drawing.Point(47, 18);
            this.radbtn_female.Name = "radbtn_female";
            this.radbtn_female.Size = new System.Drawing.Size(35, 16);
            this.radbtn_female.TabIndex = 1;
            this.radbtn_female.TabStop = true;
            this.radbtn_female.Text = "여";
            this.radbtn_female.UseVisualStyleBackColor = true;
            // 
            // radbtn_male
            // 
            this.radbtn_male.AutoSize = true;
            this.radbtn_male.Checked = true;
            this.radbtn_male.Enabled = false;
            this.radbtn_male.Location = new System.Drawing.Point(6, 18);
            this.radbtn_male.Name = "radbtn_male";
            this.radbtn_male.Size = new System.Drawing.Size(35, 16);
            this.radbtn_male.TabIndex = 0;
            this.radbtn_male.TabStop = true;
            this.radbtn_male.Text = "남";
            this.radbtn_male.UseVisualStyleBackColor = true;
            // 
            // check_expDay
            // 
            this.check_expDay.AutoSize = true;
            this.check_expDay.Location = new System.Drawing.Point(12, 214);
            this.check_expDay.Name = "check_expDay";
            this.check_expDay.Size = new System.Drawing.Size(60, 16);
            this.check_expDay.TabIndex = 13;
            this.check_expDay.Text = "측정일";
            this.check_expDay.UseVisualStyleBackColor = true;
            this.check_expDay.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // pick_expStart
            // 
            this.pick_expStart.Enabled = false;
            this.pick_expStart.Location = new System.Drawing.Point(135, 214);
            this.pick_expStart.Name = "pick_expStart";
            this.pick_expStart.Size = new System.Drawing.Size(154, 21);
            this.pick_expStart.TabIndex = 15;
            // 
            // pick_expEnd
            // 
            this.pick_expEnd.Enabled = false;
            this.pick_expEnd.Location = new System.Drawing.Point(330, 214);
            this.pick_expEnd.Name = "pick_expEnd";
            this.pick_expEnd.Size = new System.Drawing.Size(154, 21);
            this.pick_expEnd.TabIndex = 16;
            // 
            // check_height
            // 
            this.check_height.AutoSize = true;
            this.check_height.Location = new System.Drawing.Point(12, 251);
            this.check_height.Name = "check_height";
            this.check_height.Size = new System.Drawing.Size(36, 16);
            this.check_height.TabIndex = 17;
            this.check_height.Text = "키";
            this.check_height.UseVisualStyleBackColor = true;
            this.check_height.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // pick_heightStart
            // 
            this.pick_heightStart.Enabled = false;
            this.pick_heightStart.Location = new System.Drawing.Point(135, 250);
            this.pick_heightStart.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pick_heightStart.Name = "pick_heightStart";
            this.pick_heightStart.Size = new System.Drawing.Size(59, 21);
            this.pick_heightStart.TabIndex = 18;
            // 
            // pick_heightEnd
            // 
            this.pick_heightEnd.Enabled = false;
            this.pick_heightEnd.Location = new System.Drawing.Point(235, 251);
            this.pick_heightEnd.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pick_heightEnd.Name = "pick_heightEnd";
            this.pick_heightEnd.Size = new System.Drawing.Size(54, 21);
            this.pick_heightEnd.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(295, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "부터";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(490, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "까지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(295, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "부터";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(490, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "까지";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(200, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "부터";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(295, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "까지";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(295, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "까지";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(200, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "부터";
            // 
            // pick_ageEnd
            // 
            this.pick_ageEnd.Enabled = false;
            this.pick_ageEnd.Location = new System.Drawing.Point(235, 99);
            this.pick_ageEnd.Name = "pick_ageEnd";
            this.pick_ageEnd.Size = new System.Drawing.Size(54, 21);
            this.pick_ageEnd.TabIndex = 28;
            // 
            // pick_ageStart
            // 
            this.pick_ageStart.Enabled = false;
            this.pick_ageStart.Location = new System.Drawing.Point(135, 98);
            this.pick_ageStart.Name = "pick_ageStart";
            this.pick_ageStart.Size = new System.Drawing.Size(59, 21);
            this.pick_ageStart.TabIndex = 27;
            // 
            // check_age
            // 
            this.check_age.AutoSize = true;
            this.check_age.Location = new System.Drawing.Point(12, 99);
            this.check_age.Name = "check_age";
            this.check_age.Size = new System.Drawing.Size(48, 16);
            this.check_age.TabIndex = 26;
            this.check_age.Text = "나이";
            this.check_age.UseVisualStyleBackColor = true;
            this.check_age.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(295, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "까지";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(200, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "부터";
            // 
            // pick_weightEnd
            // 
            this.pick_weightEnd.Enabled = false;
            this.pick_weightEnd.Location = new System.Drawing.Point(235, 282);
            this.pick_weightEnd.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pick_weightEnd.Name = "pick_weightEnd";
            this.pick_weightEnd.Size = new System.Drawing.Size(54, 21);
            this.pick_weightEnd.TabIndex = 33;
            // 
            // pick_weightStart
            // 
            this.pick_weightStart.Enabled = false;
            this.pick_weightStart.Location = new System.Drawing.Point(135, 281);
            this.pick_weightStart.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pick_weightStart.Name = "pick_weightStart";
            this.pick_weightStart.Size = new System.Drawing.Size(59, 21);
            this.pick_weightStart.TabIndex = 32;
            // 
            // check_weight
            // 
            this.check_weight.AutoSize = true;
            this.check_weight.Location = new System.Drawing.Point(12, 282);
            this.check_weight.Name = "check_weight";
            this.check_weight.Size = new System.Drawing.Size(60, 16);
            this.check_weight.TabIndex = 31;
            this.check_weight.Text = "몸무게";
            this.check_weight.UseVisualStyleBackColor = true;
            this.check_weight.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchOptionSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pick_weightEnd);
            this.Controls.Add(this.pick_weightStart);
            this.Controls.Add(this.check_weight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pick_ageEnd);
            this.Controls.Add(this.pick_ageStart);
            this.Controls.Add(this.check_age);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pick_heightEnd);
            this.Controls.Add(this.pick_heightStart);
            this.Controls.Add(this.check_height);
            this.Controls.Add(this.pick_expEnd);
            this.Controls.Add(this.pick_expStart);
            this.Controls.Add(this.check_expDay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.check_sex);
            this.Controls.Add(this.check_HemiRight);
            this.Controls.Add(this.check_HemiLeft);
            this.Controls.Add(this.check_Hemi);
            this.Controls.Add(this.check_birth);
            this.Controls.Add(this.pick_birthEnd);
            this.Controls.Add(this.pick_birthStart);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.check_name);
            this.Name = "SearchOptionSelectForm";
            this.Text = "SearchOptionSelectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pick_heightStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_heightEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_ageEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_ageStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_weightEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_weightStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker pick_birthStart;
        private System.Windows.Forms.DateTimePicker pick_birthEnd;
        private System.Windows.Forms.CheckBox check_birth;
        private System.Windows.Forms.CheckBox check_Hemi;
        private System.Windows.Forms.CheckBox check_HemiLeft;
        private System.Windows.Forms.CheckBox check_HemiRight;
        private System.Windows.Forms.CheckBox check_sex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbtn_female;
        private System.Windows.Forms.RadioButton radbtn_male;
        private System.Windows.Forms.CheckBox check_expDay;
        private System.Windows.Forms.DateTimePicker pick_expStart;
        private System.Windows.Forms.DateTimePicker pick_expEnd;
        private System.Windows.Forms.CheckBox check_height;
        private System.Windows.Forms.NumericUpDown pick_heightStart;
        private System.Windows.Forms.NumericUpDown pick_heightEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown pick_ageEnd;
        private System.Windows.Forms.NumericUpDown pick_ageStart;
        private System.Windows.Forms.CheckBox check_age;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown pick_weightEnd;
        private System.Windows.Forms.NumericUpDown pick_weightStart;
        private System.Windows.Forms.CheckBox check_weight;
        private System.Windows.Forms.Button button1;
    }
}