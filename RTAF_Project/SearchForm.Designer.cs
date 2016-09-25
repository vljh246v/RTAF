namespace RTAF_Project
{
    partial class SearchForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Setoption = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viewDetails});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(500, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewDetails
            // 
            this.viewDetails.HeaderText = "상세보기";
            this.viewDetails.Name = "viewDetails";
            this.viewDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.viewDetails.Text = "상세보기";
            this.viewDetails.ToolTipText = "상세보기";
            this.viewDetails.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "환자 목록";
            // 
            // btn_Setoption
            // 
            this.btn_Setoption.Location = new System.Drawing.Point(437, 12);
            this.btn_Setoption.Name = "btn_Setoption";
            this.btn_Setoption.Size = new System.Drawing.Size(75, 23);
            this.btn_Setoption.TabIndex = 4;
            this.btn_Setoption.Text = "검색 옵션";
            this.btn_Setoption.UseVisualStyleBackColor = true;
            this.btn_Setoption.Click += new System.EventHandler(this.btn_Setoption_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "선택된 목록 엑셀로 출력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "선택된 환자 수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(356, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sex : 1(남)/2(여)";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Setoption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Setoption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn viewDetails;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label2;
    }
}