using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace RTAF_Project
{
    class FileHandler
    {
        TotalResult result = null;
        DB_Handler DB = null;
        string SQL;
        public FileHandler()
        {
            DB = new DB_Handler();
            SQL = "";
        }

        public void setResult(TotalResult result)
        {
            this.result = result;
        }

        public void makeExcelFile(int userID, string fileName)
        {
            SQL = "SELECT * FROM Patient WHERE Patient.ID = " + userID;

            DB.ConnectDB();
            DataTable paDT = DB.GetTabel(SQL);
            
            SQL = "SELECT * FROM TreatmentList WHERE TreatmentList.ID1 = " + userID;
            DataTable expDT = DB.GetTabel(SQL);

            DB.DisconnectDB();


            object misValue = System.Reflection.Missing.Value;

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Sheets[1];
            //Excel.Worksheet xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Sheets[2];

            string data = "";
            xlWorkSheet1.Cells[1, 1] = "ID";
            xlWorkSheet1.Cells[1, 2] = "Name";
            xlWorkSheet1.Cells[1, 3] = "Age";
            xlWorkSheet1.Cells[1, 4] = "Birth";
            xlWorkSheet1.Cells[1, 5] = "Sex";
            xlWorkSheet1.Cells[1, 6] = "Height";
            xlWorkSheet1.Cells[1, 7] = "Weigth";
            xlWorkSheet1.Cells[1, 8] = "Hemiside";

            xlWorkSheet1.Cells[4, 1] = "ID";
            xlWorkSheet1.Cells[4, 2] = "avgTime";
            xlWorkSheet1.Cells[4, 3] = "expDate";
            xlWorkSheet1.Cells[4, 4] = "Note";

            for (int i = 0; i <= paDT.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= paDT.Columns.Count - 1; j++)
                {
                    
                    data = paDT.Rows[i].ItemArray[j].ToString();

                    if (i + 2 == 5)
                    {
                        if(data == "1")
                        {
                            data = "남";
                        }else
                        {
                            data = "여";
                        }
                    }

                    xlWorkSheet1.Cells[i + 2, j + 1] = data;
                }
            }

            for (int i = 0; i <= expDT.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= expDT.Columns.Count - 1; j++)
                {
                    data = expDT.Rows[i].ItemArray[j].ToString();
                    xlWorkSheet1.Cells[i + 5, j + 1] = data;
                }
            }
            xlWorkBook.SaveAs(fileName + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();


            releaseObject(xlWorkSheet1);
          //  releaseObject(xlWorkSheet2);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
