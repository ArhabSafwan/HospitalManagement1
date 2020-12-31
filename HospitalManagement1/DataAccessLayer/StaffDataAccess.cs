using HospitalManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.DataAccessLayer
{
    class StaffDataAccess
    {
        DataAccess dataAccess;
        public StaffDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public Staff GetStaff(int id)
        {
            string sql = "SELECT * FROM  Staffs WHERE  StaffId-"+id;
            SqlDataReader reader =this.dataAccess.GetData(sql);
            reader.Read();
            Staff staff = new Staff();
            staff.StaffId = (int)reader["StaffId"];
            staff.StaffName = reader["StaffName"].ToString();
            return staff;
        }
        public int insertStaff(Staff staff)
        {
            string sql = "INSERT INTO Staffs(StaffName) VALUES('"+staff.StaffName+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
