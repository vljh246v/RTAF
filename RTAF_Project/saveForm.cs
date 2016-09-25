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
    public partial class saveForm : Form
    {
        private string expTime;
        private double avgTime;
        private int id;
        DateTime nowTime;
        DB_Handler DB;
        
        

        public saveForm(double avgTime, int id)
        {
            InitializeComponent();
            DB = new DB_Handler();
            this.avgTime = avgTime;
            this.id = id;

            nowTime = DateTime.Now;
            expTime = nowTime.ToString("yyyy-MM-dd tt hh:mm:ss");
            lab_chekcTime.Text = expTime;
            lab_avgTime.Text = avgTime.ToString();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DB.ConnectDB();
            DB.insertCheckResult(this.avgTime, nowTime, txt_note.Text.ToString(), this.id);
            DB.DisconnectDB();
            this.Close();
        }
    }
}
