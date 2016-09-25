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
    public partial class ExpInfoForm : Form
    {
        DB_Handler db;
        PatientInfo info;
        public ExpInfoForm(object info)
        {
            InitializeComponent();

            this.info = (PatientInfo)info;
            db = new DB_Handler();
            db.ConnectDB();
            DataTable dt = db.GetTabel("SELECT * FROM TreatmentList WHERE TreatmentList.ID1= " + this.info.getID());
            dataGridView1.DataSource = dt;
            db.DisconnectDB();
        }
    }
}
