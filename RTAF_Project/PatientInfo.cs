using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTAF_Project
{
    class PatientInfo
    {
        private int ID;
        private string name;
        private int age;
        private int sex; //male 1, female 2
        private DateTime birth;
        private int weight;
        private int height;
        private string hemiside;

        public PatientInfo()
        {

        }
        public PatientInfo(string name, int age, int sex, DateTime birth, int height, int weight, string Hemiside)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.birth = birth;
            this.weight = weight;
            this.height = height;
            this.hemiside = Hemiside;
            this.ID = -1;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return this.age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

        public int getSex()
        {
            return this.sex;
        }
        public void setSex(int sex)
        {
            this.sex = sex;
        }

        public DateTime getBirth()
        {
            return this.birth;
        }
        public void setBirth(DateTime birth)
        {
            this.birth = birth;
        }

        public int getWeight()
        {
            return this.weight;
        }
        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public int getHeight()
        {
            return this.height;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }

        public string getHemiside()
        {
            return this.hemiside;
        }
        public void setHemiside(string side)
        {
            this.hemiside = side;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }
    }
}
