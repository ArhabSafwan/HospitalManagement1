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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
            Action<object, EventArgs> AddEmployeebutton_Click = null;
            AddEmployeebutton_Click += this.RefreshGridView;
        }

        private void EmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void RefreshGridView(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeelistGridView.DataSource = employeeService.GetEmployeesList();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeelistGridView.DataSource = employeeService.GetEmployeesList();
            StaffService staffService = new StaffService();
            AddEmployeeStaflistcomboBox.DataSource = staffService.GetStaffNameList();
        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.AddNewEmployee(AddEmployeeNametextBox.Text, AddOccupationtextBox.Text, AddSpecialisttextBox.Text, AddSpecialisttextBox.Text, AddSalarytextBox.Text, AddEmployeeStaflistcomboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("New Employee added");
            }
            else
            {
                MessageBox.Show("Error in adding new Employee");
            }

        }
    }
}
