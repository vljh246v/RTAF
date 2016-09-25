using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAF_Project
{
    class TotalResult
    {
        private PatientInfo paInfo = null;
        private List<ExpInfo> expList = null;
           

        public TotalResult(PatientInfo paInfo, List<ExpInfo> expInfo)
        {
            this.paInfo = paInfo;
            this.expList = expInfo;
        }
        public TotalResult()
        {
            this.paInfo = new PatientInfo();
            this.expList = new List<ExpInfo>();
        }

        public PatientInfo getPainfo()
        {
            return this.paInfo;
        }
        public void setPainfo(PatientInfo info)
        {
            this.paInfo = info;
        }

        public List<ExpInfo> getExpList()
        {
            return this.expList;
        }
        public void setExpList(List<ExpInfo> list)
        {
            this.expList = list;
        }

        public void addExpInfo(ExpInfo info)
        {
            this.expList.Add(info);
        }
    }
}
