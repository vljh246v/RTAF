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
    public partial class inputInfo : Form, dataTransferInterface
    {
        PatientInfo currentPatient;
        public inputInfo()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime dt = dateTimePicker1.Value;

            lab_age.Text = getAge(dt).ToString();

        }

        public int getAge(DateTime selectDate)
        {
            DateTime dtNow = DateTime.Parse(System.DateTime.Now.ToString());

            int iAge = 0;
            int birth_year = selectDate.Year;
            int birth_month = selectDate.Month;
            int birth_day = selectDate.Day;

            int now_year = dtNow.Year;
            int now_month = dtNow.Month;
            int now_day = dtNow.Day;

            if (birth_month < now_month)
            {
                iAge = now_year - birth_year;
            }
            else if (birth_month == now_month)
            {
                if (birth_day <= now_day)
                {
                    iAge = now_year - birth_year;
                }
                else
                {
                    iAge = now_year = birth_year - 1;
                }
            }else
            {
                iAge = now_year - birth_year - 1;
            }


            return iAge;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tempSex = 0;
            string hemisideString = "";

            if (TBox_name.Text == "")
            {
                MessageBox.Show("이름이 빈칸 입니다.");
            }else
            {
                
                if (rabtn_female.Checked)
                {
                    tempSex = 2;
                }
                else
                {
                    tempSex = 1;
                }

                if (check_Left.Checked)
                {
                    if (check_Right.Checked)
                    {
                        hemisideString = "좌/우";
                    }
                    else
                    {
                        hemisideString = "좌";
                    }
                }
                else if (check_Right.Checked)
                {
                    if (check_Left.Checked)
                    {
                        hemisideString = "좌/우";
                    }
                    else
                    {
                        hemisideString = "우";
                    }
                }
                else
                {
                    hemisideString = "무";
                }




                if (checkBox1.Checked)
                {
                    DialogResult result1 = MessageBox.Show("환자 정보를 저장하고 측정을 시작하시겠습니까?", "측정시작",
                    MessageBoxButtons.YesNo);


                    if (result1.ToString() == "Yes")
                    {
                        currentPatient = new PatientInfo(TBox_name.Text, Int32.Parse(lab_age.Text), tempSex, dateTimePicker1.Value, Decimal.ToInt32(height.Value), Decimal.ToInt32(weight.Value), hemisideString);
                        DB_Handler DB = new DB_Handler();
                        DB.ConnectDB();
                        int pa_id = DB.insertPatioentinfo(currentPatient);
                        DB.DisconnectDB();

                        currentPatient.setID(pa_id);

                        Measurement form = new Measurement(currentPatient);
                        form.Show();
                        this.Close();
                        Application.OpenForms["Form1"].Hide();
                    }
                    else if (result1.ToString() == "No")
                    {

                    }
                }
                else
                {
                    DialogResult result1 = MessageBox.Show("측정을 시작하시겠습니까?", "측정시작",
                    MessageBoxButtons.YesNo);


                    if (result1.ToString() == "Yes")
                    {
                        //currentPatient = new PatientInfo(TBox_name.Text, Int32.Parse(lab_age.Text), tempSex, dateTimePicker1.Value, Decimal.ToInt32(height.Value), Decimal.ToInt32(weight.Value), hemisideString);
                        Measurement form = new Measurement(currentPatient);

                        form.Show();
                        this.Close();
                        Application.OpenForms["Form1"].Hide();
                    }
                    else if (result1.ToString() == "No")
                    {

                    }
                }
            }
            
        }

        private void rabtn_regPatient_CheckedChanged(object sender, EventArgs e)
        {
            TBox_name.Enabled = false;
            rabtn_male.Enabled = false;
            rabtn_female.Enabled = false;
            dateTimePicker1.Enabled = false;

            
        }

        private void rabtn_newPatient_CheckedChanged(object sender, EventArgs e)
        {
            TBox_name.Enabled = true;
            rabtn_male.Enabled = true;
            rabtn_female.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TBox_name.Enabled = true;
                rabtn_male.Enabled = true;
                rabtn_female.Enabled = true;
                dateTimePicker1.Enabled = true;
                weight.Enabled = true;
                height.Enabled = true;
                check_Left.Enabled = true;
                check_Right.Enabled = true;

                btn_search.Enabled = false;
            }else
            {
                TBox_name.Enabled = false;
                rabtn_male.Enabled = false;
                rabtn_female.Enabled = false;
                dateTimePicker1.Enabled = false;
                weight.Enabled = false;
                height.Enabled = false;
                check_Left.Enabled = false;
                check_Right.Enabled = false;

                btn_search.Enabled = true;
            }
            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            Form searchPatioent = new PatientList(this as dataTransferInterface);
            searchPatioent.ShowDialog();
        }

        public void setData(Object info)
        {
            currentPatient = (PatientInfo)info;

            TBox_name.Text = currentPatient.getName();
            
            if(currentPatient.getSex() == 1)
            {
                rabtn_male.Checked = true;
            }else if(currentPatient.getSex() == 2)
            {
                rabtn_female.Checked = true;
            }
            lab_age.Text = currentPatient.getAge().ToString() ;
            dateTimePicker1.Value = currentPatient.getBirth();
            height.Value = currentPatient.getHeight();
            weight.Value = currentPatient.getWeight();

            if(currentPatient.getHemiside() == "좌")
            {
                check_Left.Checked = true;
                check_Right.Checked = false;
            }else if(currentPatient.getHemiside() == "우")
            {
                check_Right.Checked = true;
                check_Left.Checked = false;
            }else if(currentPatient.getHemiside() == "좌/우")
            {
                check_Left.Checked = true;
                check_Right.Checked = true;
            }
        }
    }
}
