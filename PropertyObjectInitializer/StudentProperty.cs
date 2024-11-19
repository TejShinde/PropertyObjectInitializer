using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyObjectInitializer
{
    internal class StudentProperty
    {
        private int rollNo;
        private string name;
        private string course;

        public int RollNo
        {
            set { rollNo = value; }
            get { return rollNo; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }

        }
        public string Course
        {
            set { course = value; }
            get { return course; }

        }
    }
}
