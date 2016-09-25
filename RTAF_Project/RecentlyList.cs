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
    public partial class RecentlyList : Form
    {
        DB_Handler db;
        PatientInfo info;

        private dataTransferInterface frm = null;

        public RecentlyList(object info, dataTransferInterface frm)
        {
            InitializeComponent();

            this.frm = frm;
            this.info = (PatientInfo)info;

            if(this.info.getID() == -1)
            {
                MessageBox.Show("신규 환자 입니다.");
            }else
            {
                db = new DB_Handler();
                db.ConnectDB();
                DataTable dt = db.GetTabel("SELECT * FROM TreatmentList WHERE TreatmentList.ID1= " + this.info.getID());
                dataGridView1.DataSource = dt;
                db.DisconnectDB();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = senderGrid.Rows[e.RowIndex];
                frm.setData(selectRow.Cells[2].Value);
                this.Close();
            }
        }
    }
}
