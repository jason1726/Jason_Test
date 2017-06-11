using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        private string strEmpID = "";
        private string strEmpName = "";
        private string strEmpTel = "";
        private string strEmpAddress = "";

        public string EmpID
        {
            get
            {
                return strEmpID;
            }
            set
            {
                strEmpID = value;
            }
        }

        public string EmpName
        {
            get
            {
                return strEmpName;
            }
            set
            {
                strEmpName = value;
            }
        }

        public string EmpTel
        {
            get
            {
                return strEmpTel;
            }
            set
            {
                strEmpTel = value;
            }
        }

        public string EmpAddress
        {
            get
            {
                return strEmpAddress;
            }
            set
            {
                strEmpAddress = value;
            }
        }
    }
}