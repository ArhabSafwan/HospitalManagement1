using HospitalManagement1.BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement1.PresentationLayer
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void StaffManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();
            loadStaffDataGridView.DataSource = staffService.GetStaffList();
        }
    }
}
