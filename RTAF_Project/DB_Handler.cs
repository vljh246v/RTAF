using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace RTAF_Project
{
    class DB_Handler
    {
        OleDbConnection con;
        OleDbCommand cmd;
        string SQL;
        string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RTAF_DB.mdb;User Id=;Password=;";
        public DB_Handler()
        {
            
            con = new OleDbConnection(strAccessConn);
            //con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=RTAF_DB.accdb;Mode=ReadWrite;");
        }
        public void openDB()
        {
            con.Open();
        }

        public void ConnectDB()
        {
            try
            {
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Data);
            }
        }

        public void DisconnectDB()
        {
            con.Close();
        }

        public DataTable GetTabel(string sql)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int insertPatioentinfo(PatientInfo info)
        {
            SQL = "INSERT INTO Patient (Pa_Name, Pa_Age, Pa_Sex, Pa_Birth, Pa_Height, Pa_Weight, Pa_Hemiside) VALUES ('"
                 + info.getName() + "',"
                 + info.getAge() + ","
                 + info.getSex() + ",'"
                 + info.getBirth().ToString("yyyy-MM-dd tt hh:mm:ss") + "',"
                 + info.getHeight() + ","
                 + info.getWeight() + ",'"
                 + info.getHemiside()
                 + "')";

            cmd = new OleDbCommand();
            cmd.Connection = con;

            cmd.CommandText = SQL;

            int flag = cmd.ExecuteNonQuery();
            string query2 = "Select @@Identity";
            cmd.CommandText = query2;
            int ID = (int)cmd.ExecuteScalar();
           
            return ID;
        }

        public int getRowCount(int id)
        {
            SQL = "SELECT COUNT(*) FROM TreatmentList WHERE TreatmentList.ID1 = " + id;
            cmd = new OleDbCommand(SQL, con);
            OleDbDataReader reader =  cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = (int)reader[0];
            }
            reader.Close();
            return count;
        }

        public void insertCheckResult(double avgTime, DateTime checkTime, string note, int id)
        {
            /*SQL = "INSERT INTO TreatmentList VALUES ("
                + id + ","
                + avgTime + ","
                + checkTime + ",'"
                + note + "')";

            cmd = new OleDbCommand(SQL, con);
            int flag = cmd.ExecuteNonQuery();*/

            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO TreatmentList VALUES (@ID, @AvgTime, @InsertDate, @Note)";
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = id;
            cmd.Parameters.Add("@AvgTime", OleDbType.Double).Value = avgTime;
            cmd.Parameters.Add("@InsertDate", OleDbType.Date).Value = checkTime;
            cmd.Parameters.Add("@Note", OleDbType.LongVarChar).Value = note;

            int flag = cmd.ExecuteNonQuery();
        }
        
        public void updatePatientInfo(PatientInfo info)
        {
            SQL = "UPDATE Patient SET Pa_Name = '"
                + info.getName()
                + "', Pa_Age = "
                + info.getAge()
                + ", Pa_Sex = "
                + info.getSex()
                + ", Pa_Birth = '"
                + info.getBirth().ToString("yyyy-MM-dd tt hh:mm:ss")
                + "', Pa_Height = "
                + info.getHeight()
                + ", Pa_Weight = "
                + info.getWeight()
                + ", Pa_Hemiside = '"
                + info.getHemiside()
                + "' WHERE ID = "
                + info.getID();

            cmd = new OleDbCommand(SQL, con);


            /*cmd.CommandText = "UPDATE Patient SET (@Pa_Name, @Pa_Age, @Pa_Sex, @Pa_Birth, @Pa_Height, @Pa_Weight, @Pa_Hemiside) WHERE ID = "
                + info.getID();
            cmd.Parameters.Add("@Pa_Name", OleDbType.VarChar).Value = info.getName();
            cmd.Parameters.Add("@Pa_Age", OleDbType.Integer).Value = info.getAge();
            cmd.Parameters.Add("@Pa_Sex", OleDbType.Integer).Value = info.getSex();
            cmd.Parameters.Add("@Pa_Birth", OleDbType.Date).Value = info.getBirth();
            cmd.Parameters.Add("@Pa_Height", OleDbType.Integer).Value = info.getHeight();
            cmd.Parameters.Add("@Pa_Weight", OleDbType.Integer).Value = info.getWeight();
            cmd.Parameters.Add("@Pa_Hemiside", OleDbType.VarChar).Value = info.getHemiside();
            */
            int flag = cmd.ExecuteNonQuery();
        }
    }
}
