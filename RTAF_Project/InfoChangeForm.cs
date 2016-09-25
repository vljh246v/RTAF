using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace RTAF_Project
{
    public partial class InfoChangeForm : Form
    {

        List<PatientInfo> list = null;
        PatientInfo tempInfo = null;
        SearchForm parentForm;
        DB_Handler DB;
        public InfoChangeForm(object list, SearchForm form)
        {
            InitializeComponent();
            DB = new DB_Handler();
            this.parentForm = form;
            this.list = (List < PatientInfo >)list;

            this.tempInfo = this.list[0];

            txt_name.Text = this.tempInfo.getName();
            pick_birth.Value = this.tempInfo.getBirth();
            if(this.tempInfo.getSex() == 1)
            {
                rabtn_male.Checked = true;
                rabtn_female.Checked = false;
            }else
            {
                rabtn_female.Checked = true;
                rabtn_male.Checked = false;
            }
            pick_height.Value = this.tempInfo.getHeight();
            pick_weight.Value = this.tempInfo.getWeight();

            string tempSide = this.tempInfo.getHemiside();
            if(tempSide == "좌")
            {
                check_Sideleft.Checked = true;
            }else if(tempSide == "우")
            {
                check_SideRight.Checked = true;
            }else if(tempSide == "좌/우")
            {
                check_Sideleft.Checked = true;
                check_SideRight.Checked = true;
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(txt_name.Text + " 님 환자 정보를 수정하시겠습니까?", "수정",
               MessageBoxButtons.YesNo);


            if (result1.ToString() == "Yes")
            {
                tempInfo.setName(txt_name.Text);
                tempInfo.setBirth(pick_birth.Value);
                if (rabtn_male.Checked)
                {
                    tempInfo.setSex(1);
                }
                else if (rabtn_female.Checked)
                {
                    tempInfo.setSex(2);
                }

                tempInfo.setHeight((int)pick_height.Value);
                tempInfo.setWeight((int)pick_weight.Value);


                string hemisideString = "";

                if (check_Sideleft.Checked)
                {
                    if (check_SideRight.Checked)
                    {
                        hemisideString = "좌/우";
                    }
                    else
                    {
                        hemisideString = "좌";
                    }
                }
                else if (check_SideRight.Checked)
                {
                    if (check_Sideleft.Checked)
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

                tempInfo.setHemiside(hemisideString);

                tempInfo.setAge(getAge(pick_birth.Value));

                DB.ConnectDB();
                DB.updatePatientInfo(tempInfo);
                DB.DisconnectDB();

                this.parentForm.resetGridView();
                this.Close();
            }
            else if(result1.ToString() == "No"){
                ;
            }

            
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
            }
            else
            {
                iAge = now_year - birth_year - 1;
            }


            return iAge;
        }
    }
}
