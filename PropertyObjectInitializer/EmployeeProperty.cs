using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyObjectInitializer
{
    internal class EmployeeProperty
    {
        private int _empId;
        private string _empName;
        private string _department;

        // Public properties
        public int EmpId
        {
            set { _empId = value; }
            get { return _empId; }
        }

        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }

        public string Department
        {
            set { _department = value; }
            get { return _department; }
        }
    }
}
