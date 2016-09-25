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
    public partial class SearchForm : Form, dataTransferInterface
    {
        DB_Handler db;
        FileHandler FIO;
        public void setData(object obj)
        {
            dataGridView1.DataSource = (DataTable)obj;
            
        }
        public void resetGridView()
        {
            db = new DB_Handler();
            
            db.ConnectDB();
            DataTable dt = db.GetTabel("SELECT * FROM Patient");
            dataGridView1.DataSource = dt;
            db.DisconnectDB();

            dataGridView1.Columns[0].DisplayIndex = 1;
        }
        public SearchForm()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();

            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            CheckboxColumn.Width = 50;
            CheckboxColumn.HeaderText = "선택";
            dataGridView1.Columns.Add(CheckboxColumn);
            resetGridView();

            FIO = new FileHandler();
        }
        // col 1 빼고 전부 금지
        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Form1"].Show();
        }
        

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex != 1)
            {
                MessageBox.Show("Not allow edit");
                e.Cancel = true;
            }
            else
            {
                ;
            }
        }

        private void btn_Setoption_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1)
            {
                SearchOptionSelectForm option = new SearchOptionSelectForm(this as dataTransferInterface);
                option.ShowDialog();
            }
            else
            {
                MessageBox.Show("검색할 수 있는 대상이 없습니다.");
            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = senderGrid.Rows[e.RowIndex];

                DialogResult result1 = MessageBox.Show("선택하신 환자가 이름 : " + selectRow.Cells[3].Value.ToString() + " 님 입니까?", "확인",
               MessageBoxButtons.YesNo);


                if (result1.ToString() == "Yes")
                {
                    PatientInfo tempInfo = new PatientInfo(
                    selectRow.Cells[3].Value.ToString(),
                    Int32.Parse(selectRow.Cells[4].Value.ToString()),
                    Int32.Parse(selectRow.Cells[6].Value.ToString()),
                    Convert.ToDateTime(selectRow.Cells[5].Value),
                    Int32.Parse(selectRow.Cells[7].Value.ToString()),
                    Int32.Parse(selectRow.Cells[8].Value.ToString()),
                    selectRow.Cells[9].Value.ToString()
                    );
                    tempInfo.setID(Int32.Parse(selectRow.Cells[2].Value.ToString()));

                    ExpInfoForm form = new ExpInfoForm(tempInfo);
                    form.ShowDialog();

                }
                else if (result1.ToString() == "No")
                {

                }
            }
        }

        public List<DataGridViewRow> getCheckCount()
        {
            int checkCount = 0;

            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
           

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value) == true)
                {
                    checkCount++;
                    rows_with_checked_column.Add(row);
                }
            }

            return rows_with_checked_column;
        }

        private void button2_Click(object sender, EventArgs e) //row 가 세로 col 가로
        {
            List<DataGridViewRow> rows_with_checked_column = getCheckCount();
            List<PatientInfo> patientList = new List<PatientInfo>();
            if (rows_with_checked_column.Count > 1)
            {
                MessageBox.Show("한명만 선택하세요");
            }
            else if (rows_with_checked_column.Count == 0)
            {
                MessageBox.Show("선택한 사람이 없습니다.");
            }
            else
            {
                foreach (DataGridViewRow row in rows_with_checked_column)
                {
                    PatientInfo temp = new PatientInfo(
                        row.Cells[3].Value.ToString(),
                        (int)row.Cells[4].Value,
                        (int)row.Cells[6].Value,
                        (DateTime)row.Cells[5].Value,
                        (int)row.Cells[7].Value,
                        (int)row.Cells[8].Value,
                        row.Cells[9].Value.ToString()
                        );
                    temp.setID((int)row.Cells[2].Value);
                    patientList.Add(temp);
                }

                InfoChangeForm form = new InfoChangeForm(patientList, this);
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if(officeType == null)
            {
                MessageBox.Show("엑셀을 설치하세요~");
            }else
            {
                List<DataGridViewRow> rows_with_checked_column = getCheckCount();
                List<PatientInfo> patientList = new List<PatientInfo>();
                if (rows_with_checked_column.Count > 1)
                {
                    MessageBox.Show("한명만 선택하세요");
                }
                else if (rows_with_checked_column.Count == 0)
                {
                    MessageBox.Show("선택한 사람이 없습니다.");
                }
                else
                {

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel Files|*.xls";
                    saveFileDialog1.Title = "Save an Image File";
                    saveFileDialog1.ShowDialog();

                    if (saveFileDialog1.FileName != "")
                    {
                        string dir = saveFileDialog1.InitialDirectory;
                        FIO.makeExcelFile((int)rows_with_checked_column[0].Cells[2].Value, saveFileDialog1.FileNames[0].ToString());
                    }
                }
            }
            
                
        }
    }
}
