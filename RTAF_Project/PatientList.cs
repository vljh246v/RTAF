using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTAF_Project
{
    public partial class PatientList : Form
    {
        DB_Handler db;
        private dataTransferInterface frm = null;
        public PatientList(dataTransferInterface frm)
        {
            InitializeComponent();
            db = new DB_Handler();
            db.ConnectDB();
            DataTable dt =  db.GetTabel("SELECT * FROM Patient");
            dataGridView1.DataSource = dt;
            db.DisconnectDB();
            this.frm = frm;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = senderGrid.Rows[e.RowIndex];

                DialogResult result1 = MessageBox.Show("선택하신 환자가 이름 : " + selectRow.Cells[2].Value.ToString() + " 님 입니까?", "확인",
               MessageBoxButtons.YesNo);


                if (result1.ToString() == "Yes")
                {
                    PatientInfo tempInfo = new PatientInfo(
                    selectRow.Cells[2].Value.ToString(),
                    Int32.Parse(selectRow.Cells[3].Value.ToString()),
                    Int32.Parse(selectRow.Cells[5].Value.ToString()),
                    Convert.ToDateTime(selectRow.Cells[4].Value),
                    Int32.Parse(selectRow.Cells[6].Value.ToString()),
                    Int32.Parse(selectRow.Cells[7].Value.ToString()),
                    selectRow.Cells[8].Value.ToString()
                    );
                    tempInfo.setID(Int32.Parse(selectRow.Cells[1].Value.ToString()));
                    frm.setData(tempInfo);

                    this.Close();
                }
                else if(result1.ToString() == "No"){

                }
            }
        }
    }
}
