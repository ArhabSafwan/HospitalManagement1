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
        public List<Staff> GetAllStaffs()
        {
            string sql = "SELECT FROM Staffs";
            SqlDataReader reader =this.dataAccess.GetData(sql);
            List<Staff> staffs = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff();
                staff.StaffId = (int)reader["StaffId"];
                staff.StaffName = reader["StaffName"].ToString();
                staffs.Add(staff); 
            }
            return staffs;
        }
    }
}
