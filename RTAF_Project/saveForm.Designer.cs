namespace RTAF_Project
{
    partial class saveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_avgTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_chekcTime = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "평균시간(초) : ";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(12, 94);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(298, 159);
            this.txt_note.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "특이사항";
            // 
            // lab_avgTime
            // 
            this.lab_avgTime.AutoSize = true;
            this.lab_avgTime.Location = new System.Drawing.Point(103, 27);
            this.lab_avgTime.Name = "lab_avgTime";
            this.lab_avgTime.Size = new System.Drawing.Size(38, 12);
            this.lab_avgTime.TabIndex = 3;
            this.lab_avgTime.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "측정시간 : ";
            // 
            // lab_chekcTime
            // 
            this.lab_chekcTime.AutoSize = true;
            this.lab_chekcTime.Location = new System.Drawing.Point(81, 51);
            this.lab_chekcTime.Name = "lab_chekcTime";
            this.lab_chekcTime.Size = new System.Drawing.Size(38, 12);
            this.lab_chekcTime.TabIndex = 5;
            this.lab_chekcTime.Text = "label5";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(14, 270);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(143, 23);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "확인";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(163, 270);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(147, 24);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // saveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 305);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lab_chekcTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_avgTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label1);
            this.Name = "saveForm";
            this.Text = "saveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_avgTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_chekcTime;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}