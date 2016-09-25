namespace RTAF_Project
{
    partial class InfoChangeForm
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
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pick_birth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabtn_male = new System.Windows.Forms.RadioButton();
            this.rabtn_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pick_height = new System.Windows.Forms.NumericUpDown();
            this.pick_weight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.check_Sideleft = new System.Windows.Forms.CheckBox();
            this.check_SideRight = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pick_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(113, 274);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 1;
            this.btn_change.Text = "변경완료 ";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(194, 274);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 2;
            this.btn_cancle.Text = "취소";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(108, 32);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "생년월일 : ";
            // 
            // pick_birth
            // 
            this.pick_birth.Location = new System.Drawing.Point(108, 63);
            this.pick_birth.Name = "pick_birth";
            this.pick_birth.Size = new System.Drawing.Size(160, 21);
            this.pick_birth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "성별 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabtn_female);
            this.groupBox1.Controls.Add(this.rabtn_male);
            this.groupBox1.Location = new System.Drawing.Point(108, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // rabtn_male
            // 
            this.rabtn_male.AutoSize = true;
            this.rabtn_male.Checked = true;
            this.rabtn_male.Location = new System.Drawing.Point(33, 18);
            this.rabtn_male.Name = "rabtn_male";
            this.rabtn_male.Size = new System.Drawing.Size(47, 16);
            this.rabtn_male.TabIndex = 0;
            this.rabtn_male.TabStop = true;
            this.rabtn_male.Text = "남성";
            this.rabtn_male.UseVisualStyleBackColor = true;
            // 
            // rabtn_female
            // 
            this.rabtn_female.AutoSize = true;
            this.rabtn_female.Location = new System.Drawing.Point(86, 18);
            this.rabtn_female.Name = "rabtn_female";
            this.rabtn_female.Size = new System.Drawing.Size(47, 16);
            this.rabtn_female.TabIndex = 1;
            this.rabtn_female.TabStop = true;
            this.rabtn_female.Text = "여성";
            this.rabtn_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "신장(cm) : ";
            // 
            // pick_height
            // 
            this.pick_height.Location = new System.Drawing.Point(108, 159);
            this.pick_height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pick_height.Name = "pick_height";
            this.pick_height.Size = new System.Drawing.Size(160, 21);
            this.pick_height.TabIndex = 9;
            // 
            // pick_weight
            // 
            this.pick_weight.Location = new System.Drawing.Point(108, 196);
            this.pick_weight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pick_weight.Name = "pick_weight";
            this.pick_weight.Size = new System.Drawing.Size(160, 21);
            this.pick_weight.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "체중(kg) : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hemiside : ";
            // 
            // check_Sideleft
            // 
            this.check_Sideleft.AutoSize = true;
            this.check_Sideleft.Location = new System.Drawing.Point(141, 234);
            this.check_Sideleft.Name = "check_Sideleft";
            this.check_Sideleft.Size = new System.Drawing.Size(36, 16);
            this.check_Sideleft.TabIndex = 13;
            this.check_Sideleft.Text = "좌";
            this.check_Sideleft.UseVisualStyleBackColor = true;
            // 
            // check_SideRight
            // 
            this.check_SideRight.AutoSize = true;
            this.check_SideRight.Location = new System.Drawing.Point(194, 235);
            this.check_SideRight.Name = "check_SideRight";
            this.check_SideRight.Size = new System.Drawing.Size(36, 16);
            this.check_SideRight.TabIndex = 14;
            this.check_SideRight.Text = "우";
            this.check_SideRight.UseVisualStyleBackColor = true;
            // 
            // InfoChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 303);
            this.Controls.Add(this.check_SideRight);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.check_Sideleft);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pick_weight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pick_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pick_birth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "InfoChangeForm";
            this.Text = "InfoChangeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pick_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pick_birth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabtn_female;
        private System.Windows.Forms.RadioButton rabtn_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown pick_height;
        private System.Windows.Forms.NumericUpDown pick_weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_Sideleft;
        private System.Windows.Forms.CheckBox check_SideRight;
    }
}