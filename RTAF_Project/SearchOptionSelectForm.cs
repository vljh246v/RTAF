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
    public partial class SearchOptionSelectForm : Form
    {
        string SQL;
        DB_Handler DB;
        private dataTransferInterface frm = null;
        bool isFirstQuery = true;
        public SearchOptionSelectForm(dataTransferInterface frm)
        {
            InitializeComponent();
            SQL = "";
            DB = new DB_Handler();
            this.frm = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL = "";
            DB.ConnectDB();
            SQL += "SELECT  Patient.ID, Patient.Pa_Name, Patient.Pa_Age, Patient.Pa_Birth, Patient.Pa_Sex, Patient.Pa_Height, Patient.Pa_Weight, Patient.Pa_Hemiside FROM Patient, TreatmentList WHERE ";
            if (check_name.Checked)
            {
                isFirstQuery = false;
                SQL += "Patient.Pa_Name = '" + txt_name.Text.ToString() + "'";
            }
            if (check_age.Checked)
            {
                if (isFirstQuery)
                {

                }else
                {
                    SQL += "AND ";
                }
                SQL += "Patient.Pa_Age >= "
                    + Int32.Parse(pick_ageStart.Value.ToString())
                    + " AND Patient.Pa_Age <= "
                    + Int32.Parse(pick_ageEnd.Value.ToString());
            }
            if (check_birth.Checked)
            {
                if (isFirstQuery)
                {

                }
                else
                {
                    SQL += "AND ";
                }

                SQL += "Patient.Pa_Birth Between Format(#"
                    + pick_birthStart.Value.ToShortDateString()
                    + "#, 'dd/mm/yyyy') And Format(#"
                    + pick_birthEnd.Value.ToShortDateString()
                    + "#, 'dd/mm/yyyy')";
            }
            if (check_Hemi.Checked)
            {
                if (isFirstQuery)
                {

                }
                else
                {
                    SQL += "AND ";
                }
                string hemisideString = "";
                if (check_HemiLeft.Checked)
                {
                    if (check_HemiRight.Checked)
                    {
                        hemisideString = "좌/우";
                    }
                    else
                    {
                        hemisideString = "좌";
                    }
                }
                else if (check_HemiRight.Checked)
                {
                    if (check_HemiLeft.Checked)
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
                SQL += "Patient.Pa_Hemiside = '" + hemisideString + "'";
            }
            if (check_sex.Checked)
            {
                if (isFirstQuery)
                {

                }
                else
                {
                    SQL += "AND ";
                }
                int sexFlag = 0;
                if (radbtn_female.Checked)
                {
                    sexFlag = 2;
                }else if (radbtn_male.Checked)
                {
                    sexFlag = 1;
                }
                SQL += "Patient.Pa_Sex = " + sexFlag;
            }
            if (check_expDay.Checked)
            {
                if (isFirstQuery)
                {

                }
                else
                {
                    SQL += "AND ";
                }
                
                SQL += "TreatmentList.InsertDate Between Format(#"
                    + pick_expStart.Value.ToShortDateString()
                    + "#, 'dd/mm/yyyy') And Format(#"
                    + pick_expEnd.Value.ToShortDateString()
                    + "#, 'dd/mm/yyyy')";
            }
            if (check_height.Checked)
            {
                if (isFirstQuery)
                {

                }
                else
                {
                    SQL += "AND ";
                }

                SQL += "Patient.Pa_Height >= "
                    + Int32.Parse(pick_heightStart.Value.ToString())
                    + " AND Patient.Pa_Height <= "
                    + Int32.Parse(pick_heightEnd.Value.ToString());
            }
            if (check_weight.Checked)
            {
                if (isFirstQuery)
                {

                }
                else
                {
                    SQL += "AND ";
                }
                SQL += "Patient.Pa_Weight >= "
                    + Int32.Parse(pick_weightStart.Value.ToString())
                    + " AND Patient.Pa_Weight <= "
                    + Int32.Parse(pick_weightEnd.Value.ToString());
            }

            SQL += " GROUP BY Patient.ID, Patient.Pa_Name, Patient.Pa_Age, Patient.Pa_Birth, Patient.Pa_Sex, Patient.Pa_Height, Patient.Pa_Weight, Patient.Pa_Hemiside";
            DataTable dt =  DB.GetTabel(SQL);
            DB.DisconnectDB();
            frm.setData(dt);
            this.Close();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            string checkBoxName = ((CheckBox)sender).Name;

            if(checkBoxName == check_name.Name)
            {
                if (check_name.Checked)
                {
                    txt_name.Enabled = true;
                }
                else
                {
                    txt_name.Enabled = false;
                }
            }else if(checkBoxName == check_age.Name)
            {
                if (check_age.Checked)
                {
                    pick_ageStart.Enabled = true;
                    pick_ageEnd.Enabled = true;
                }
                else
                {
                    pick_ageStart.Enabled = false;
                    pick_ageEnd.Enabled = false;
                }
            }
            else if(checkBoxName == check_birth.Name)
            {
                if (check_birth.Checked)
                {
                    pick_birthStart.Enabled = true;
                    pick_birthEnd.Enabled = true;
                }
                else
                {
                    pick_birthStart.Enabled = false;
                    pick_birthEnd.Enabled = false;
                }
            }else if(checkBoxName == check_Hemi.Name)
            {
                if (check_Hemi.Checked)
                {
                    check_HemiLeft.Enabled = true;
                    check_HemiRight.Enabled = true;
                }
                else
                {
                    check_HemiLeft.Enabled = false;
                    check_HemiRight.Enabled = false;
                }
            }else if(checkBoxName == check_sex.Name)
            {
                if (check_sex.Checked)
                {
                    groupBox1.Enabled = true;
                    radbtn_female.Enabled = true;
                    radbtn_male.Enabled = true;
                }
                else
                {
                    groupBox1.Enabled = false;
                    radbtn_female.Enabled = false;
                    radbtn_male.Enabled = false;
                }
            }else if(checkBoxName == check_expDay.Name)
            {
                if (check_expDay.Checked)
                {
                    pick_expStart.Enabled = true;
                    pick_expEnd.Enabled = true;
                }
                else
                {
                    pick_expEnd.Enabled = false;
                    pick_expStart.Enabled = false;
                }
            }else if(checkBoxName == check_height.Name)
            {
                if (check_height.Checked)
                {
                    pick_heightStart.Enabled = true;
                    pick_heightEnd.Enabled = true;
                }
                else
                {
                    pick_heightEnd.Enabled = false;
                    pick_heightStart.Enabled = false;
                }
            }else if(checkBoxName == check_weight.Name)
            {
                if (check_weight.Checked)
                {
                    pick_weightEnd.Enabled = true;
                    pick_weightStart.Enabled = true;
                }
                else
                {
                    pick_weightEnd.Enabled = false;
                    pick_weightStart.Enabled = false;
                }
            }

        }
    }
}
