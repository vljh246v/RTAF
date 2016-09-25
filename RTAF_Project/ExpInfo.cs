using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAF_Project
{
    class ExpInfo
    {
        private int ID;
        private DateTime expTime;
        private double avgTime;


        public ExpInfo()
        {
            this.avgTime = 0;

        }
        
        public ExpInfo(int ID, DateTime expTime, double avgTime)
        {
            this.ID = ID;
            this.expTime = expTime;
            this.avgTime = avgTime;
        }

        public int getID()
        {
            return this.ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }

        public DateTime getExptime()
        {
            return this.expTime;
        }
        public void setDatetime(DateTime expTime)
        {
            this.expTime = expTime;
        }

        public double getAvgtime()
        {
            return this.avgTime;
        }
        public void setAvgtime(double avgTime)
        {
            this.avgTime = avgTime;
        }
    }
}
