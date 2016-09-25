namespace RTAF_Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_measurement = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_measurement
            // 
            this.btn_measurement.Location = new System.Drawing.Point(34, 192);
            this.btn_measurement.Name = "btn_measurement";
            this.btn_measurement.Size = new System.Drawing.Size(97, 23);
            this.btn_measurement.TabIndex = 0;
            this.btn_measurement.Text = "측정모드";
            this.btn_measurement.UseVisualStyleBackColor = true;
            this.btn_measurement.Click += new System.EventHandler(this.btn_measurement_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(137, 192);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(98, 23);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "환자관리모드";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 395);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_measurement);
            this.Name = "Form1";
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_measurement;
        private System.Windows.Forms.Button btn_admin;
    }
}

