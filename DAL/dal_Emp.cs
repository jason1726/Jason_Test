using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class dal_Emp
    {
        private string tempSQL = "";
        private string connetionString = ConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;

        public DataTable GetEmp(int EmpID)
        {
            DataTable dtItem = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                tempSQL = "select * from employee where empid=@empid";
                SqlCommand cmd = new SqlCommand(tempSQL, cnn);
                cmd.Parameters.Add("@empid", SqlDbType.Int);
                cmd.Parameters["@empid"].Value = EmpID;

                try
                {
                    cnn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtItem);
                }
                catch
                {
                    //nothing
                }
                finally
                {
                    cnn.Close();
                }
            }

            return dtItem;
        }

        public bool UpdateEmp(int EmpID, string EmpName, string EmpTel, string EmpAddress)
        {
            bool isUpdate = false;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                tempSQL = "update employee set empname=@empname,emptel=@emptel,empaddress=@empaddress where empid=@empid";
                SqlCommand cmd = new SqlCommand(tempSQL, cnn);
                cmd.Parameters.Add("@empid", SqlDbType.Int);
                cmd.Parameters["@empid"].Value = EmpID;

                cmd.Parameters.Add("@empname", SqlDbType.VarChar);
                cmd.Parameters["@empname"].Value = EmpName;

                cmd.Parameters.Add("@emptel", SqlDbType.VarChar);
                cmd.Parameters["@emptel"].Value = EmpTel;

                cmd.Parameters.Add("@empaddress", SqlDbType.VarChar);
                cmd.Parameters["@empaddress"].Value = EmpAddress;

                try
                {
                    cnn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        isUpdate = true;
                }
                catch
                {
                    //nothing
                }
                finally
                {
                    cnn.Close();
                }
                return isUpdate;
            }
        }

        public bool AddEmp(string EmpName, string EmpTel, string EmpAddress)
        {
            bool isAdd = false;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                tempSQL = "insert into employee values(@empname,@emptel,@empaddress)";
                SqlCommand cmd = new SqlCommand(tempSQL, cnn);

                cmd.Parameters.Add("@empname", SqlDbType.VarChar);
                cmd.Parameters["@empname"].Value = EmpName;

                cmd.Parameters.Add("@emptel", SqlDbType.VarChar);
                cmd.Parameters["@emptel"].Value = EmpTel;

                cmd.Parameters.Add("@empaddress", SqlDbType.VarChar);
                cmd.Parameters["@empaddress"].Value = EmpAddress;

                try
                {
                    cnn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        isAdd = true;
                }
                catch
                {
                    //nothing
                }
                finally
                {
                    cnn.Close();
                }
                return isAdd;
            }
        }

        public bool DeleteEmp(int EmpID)
        {
            bool isDel = false;
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                tempSQL = "delete employee where empid=@empid";
                SqlCommand cmd = new SqlCommand(tempSQL, cnn);

                cmd.Parameters.Add("@empid", SqlDbType.Int);
                cmd.Parameters["@empid"].Value = EmpID;

                try
                {
                    cnn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        isDel = true;
                }
                catch
                {
                    //nothing
                }
                finally
                {
                    cnn.Close();
                }
                return isDel;
            }
        }
    }
}