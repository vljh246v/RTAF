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

namespace RTAF_Project
{
    
    public partial class Measurement : Form, dataTransferInterface
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int n, int m);

        bool isStart = false;
        bool isCheckEnd = false;
        bool beepFlag = false;
        double avgTime = 0;
        double totalTime = 0;

        int workCount = 0;
        


        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        System.Windows.Forms.Timer aTimer;

        PatientInfo pa_info;
        DB_Handler DB;

        

        public Measurement(object obj)
        {
            InitializeComponent();
            this.pa_info = (PatientInfo)obj;
            txt_name.Text = pa_info.getName().ToString();
            lab_avgTime.Text = avgTime.ToString();
            DB = new DB_Handler();
            
        }

        private void Measurement_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Measurement_KeyDown);
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            totalTime = 0;
            isStart = true;
            lab_avgTime.Text = "0";
            btn_stop.Enabled = true;
            btn_start.Enabled = false;
            workCount = 0;
            avgTime = 0;

            if (isCheckEnd)
            {
                sw.Reset();
                isCheckEnd = false;
                btn_save.Enabled = false;
                statusBox.Text = "";
            }
        }
        

        void Measurement_KeyDown(object sender, KeyEventArgs e)
        {
            if (isStart && e.KeyCode == Keys.M)
            {
                Beep(384, 400);
                if (workCount == 0)
                {
                    sw.Start();
                    workCount++;
                }else
                {
                    double tickTerm = sw.ElapsedMilliseconds / 1000.0f;
                    statusBox.Text += workCount + " : " + tickTerm.ToString() + "\r\n";
                    sw.Restart();
                    totalTime += tickTerm;
                    avgTime = totalTime / workCount;
                    //avgTime += tickTerm / workCount;
                    lab_avgTime.Text = avgTime.ToString();
                    workCount++;
                }
            }
            
            
        }
        
        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;

            isStart = false;
            isCheckEnd = true;

            btn_sound.Enabled = true;

            btn_save.Enabled = true;
        }

        private void Measurement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Form1"].Show();
        }

        private void bnt_recentlyInfo_Click(object sender, EventArgs e)
        {
            DB.ConnectDB();
            int count = DB.getRowCount(pa_info.getID());
            DB.DisconnectDB();

            if(count == 0)
            {
                MessageBox.Show("측정 기록이 없는 환자 입니다.");
            }else
            {
                RecentlyList list = new RecentlyList(pa_info, this as dataTransferInterface);
                list.ShowDialog();
            }
           
        }
        
        public void setData(object info)
        {
            avgTime = (double)info;
            lab_avgTime.Text = avgTime.ToString();
            isCheckEnd = true;
            btn_sound.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveForm save = new saveForm(avgTime, pa_info.getID());
            save.ShowDialog();
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
            if (lab_avgTime.Text == "0")
            {
                MessageBox.Show("평균 시간이 0 입니다. 실험 또는 과거 평균시간을 선택해 주세요");
            }else
            {

                if (beepFlag)
                {
                    btn_sound.Text = "소리 출력";
                    beepFlag = false;
                    aTimer.Tick -= new EventHandler(timer_Tick);
                    aTimer.Enabled = false;
                }
                else
                {
                    btn_sound.Text = "소리 정지";
                    beepFlag = true;

                    double tempAvgTime = Double.Parse(lab_avgTime.Text.ToString());
                    int speed = Decimal.ToInt32(selectSpeed.Value);
                    double changeSppen = tempAvgTime * (speed / 100.0f);

                    TimeSpan interval = TimeSpan.FromSeconds(changeSppen);
                    aTimer = new Timer();

                    aTimer.Interval = (int)interval.TotalMilliseconds;
                    aTimer.Tick += new EventHandler(timer_Tick);
                    aTimer.Enabled = true;
                }
            }
        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            Beep(384, 400);
        }
    }
}
