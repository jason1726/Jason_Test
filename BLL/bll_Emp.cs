using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bll_Emp
    {
        private dal_Emp _emp = new dal_Emp();

        /// <summary>
        ///取得員工資料
        /// </summary>
        /// <param name="EmpID">員工編號</param>
        /// <returns></returns>
        public DataTable GetEmp(int EmpID)
        {
            return _emp.GetEmp(EmpID);
        }

        /// <summary>
        ///更新員工資料
        /// </summary>
        /// <param name="EmpID">員工編號</param>
        /// <param name="EmpName">員工姓名</param>
        /// <param name="EmpTel">員工電話</param>
        /// <param name="EmpAddress">員工地址</param>
        /// <returns></returns>
        public bool UpdateEmp(int EmpID, string EmpName, string EmpTel, string EmpAddress)
        {
            return _emp.UpdateEmp(EmpID, EmpName, EmpTel, EmpAddress);
        }

        /// <summary>
        /// 新增員工資料
        /// </summary>
        /// <param name="EmpName">員工姓名</param>
        /// <param name="EmpTel">員工電話</param>
        /// <param name="EmpAddress">員工地址</param>
        /// <returns></returns>
        public bool AddEmp(string EmpName, string EmpTel, string EmpAddress)
        {
            return _emp.AddEmp(EmpName, EmpTel, EmpAddress);
        }

        /// <summary>
        /// 刪除員工資料
        /// </summary>
        /// <param name="EmpID">員工編號</param>
        /// <returns></returns>
        public bool DeleteEmp(int EmpID)
        {
            return _emp.DeleteEmp(EmpID);
        }
    }
}