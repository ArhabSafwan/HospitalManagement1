using HospitalManagement1.DataAccessLayer;
using HospitalManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.BussinessLogicLayer
{
    class StaffService
    {
        StaffDataAccess staffDataAccess;
        public StaffService()
        {
            this.staffDataAccess = new StaffDataAccess();
        }

      public List<Staff> GetStaffList()
        {
            return this.staffDataAccess.GetAllStaffs();
        }

    }
}
