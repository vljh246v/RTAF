namespace RTAF_Project
{
    partial class inputInfo
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
            this.TBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rabtn_male = new System.Windows.Forms.RadioButton();
            this.rabtn_female = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_age = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_Right = new System.Windows.Forms.CheckBox();
            this.check_Left = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBox_name
            // 
            this.TBox_name.Enabled = false;
            this.TBox_name.Location = new System.Drawing.Point(12, 82);
            this.TBox_name.Name = "TBox_name";
            this.TBox_name.Size = new System.Drawing.Size(204, 21);
            this.TBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // rabtn_male
            // 
            this.rabtn_male.AutoSize = true;
            this.rabtn_male.Checked = true;
            this.rabtn_male.Enabled = false;
            this.rabtn_male.Location = new System.Drawing.Point(6, 20);
            this.rabtn_male.Name = "rabtn_male";
            this.rabtn_male.Size = new System.Drawing.Size(47, 16);
            this.rabtn_male.TabIndex = 3;
            this.rabtn_male.TabStop = true;
            this.rabtn_male.Text = "남자";
            this.rabtn_male.UseVisualStyleBackColor = true;
            // 
            // rabtn_female
            // 
            this.rabtn_female.AutoSize = true;
            this.rabtn_female.Enabled = false;
            this.rabtn_female.Location = new System.Drawing.Point(59, 20);
            this.rabtn_female.Name = "rabtn_female";
            this.rabtn_female.Size = new System.Drawing.Size(47, 16);
            this.rabtn_female.TabIndex = 4;
            this.rabtn_female.Text = "여자";
            this.rabtn_female.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "생년월일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "세(만)";
            // 
            // lab_age
            // 
            this.lab_age.AutoSize = true;
            this.lab_age.Location = new System.Drawing.Point(156, 155);
            this.lab_age.Name = "lab_age";
            this.lab_age.Size = new System.Drawing.Size(11, 12);
            this.lab_age.TabIndex = 8;
            this.lab_age.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "측정시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabtn_male);
            this.groupBox1.Controls.Add(this.rabtn_female);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 43);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "신규환자";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(171, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 28);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "조회";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "키(cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "몸무게(kg)";
            // 
            // weight
            // 
            this.weight.Enabled = false;
            this.weight.Location = new System.Drawing.Point(123, 216);
            this.weight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(79, 21);
            this.weight.TabIndex = 18;
            this.weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // height
            // 
            this.height.Enabled = false;
            this.height.Location = new System.Drawing.Point(12, 216);
            this.height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(75, 21);
            this.height.TabIndex = 19;
            this.height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_Right);
            this.groupBox2.Controls.Add(this.check_Left);
            this.groupBox2.Location = new System.Drawing.Point(13, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 51);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hemi_Side";
            // 
            // check_Right
            // 
            this.check_Right.AutoSize = true;
            this.check_Right.Enabled = false;
            this.check_Right.Location = new System.Drawing.Point(58, 20);
            this.check_Right.Name = "check_Right";
            this.check_Right.Size = new System.Drawing.Size(36, 16);
            this.check_Right.TabIndex = 1;
            this.check_Right.Text = "우";
            this.check_Right.UseVisualStyleBackColor = true;
            // 
            // check_Left
            // 
            this.check_Left.AutoSize = true;
            this.check_Left.Enabled = false;
            this.check_Left.Location = new System.Drawing.Point(6, 20);
            this.check_Left.Name = "check_Left";
            this.check_Left.Size = new System.Drawing.Size(36, 16);
            this.check_Left.TabIndex = 0;
            this.check_Left.Text = "좌";
            this.check_Left.UseVisualStyleBackColor = true;
            // 
            // inputInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBox_name);
            this.Name = "inputInfo";
            this.Text = "mm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabtn_male;
        private System.Windows.Forms.RadioButton rabtn_female;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_Right;
        private System.Windows.Forms.CheckBox check_Left;
    }
}