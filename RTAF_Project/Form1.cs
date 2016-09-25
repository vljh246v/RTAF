using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.AccessControl;


namespace RTAF_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btn_measurement_Click(object sender, EventArgs e)
        {
            Form inputInfo = new inputInfo();
            inputInfo.ShowDialog();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Show();
            this.Hide();
        }
    }
}
