﻿using System;
using HospitalManagement1.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement1.DataAccessLayer
{
    class EmployeeDataAccess
    {
        DataAccess dataAccess;


        public EmployeeDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
           SqlDataReader reader = dataAccess.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Occupation = reader["Occupation"].ToString();
                employee.Specialist = reader["Specialist"].ToString();
                employee.Salary = (int)reader["Salary"];
                employee.StaffId = (int)reader["StaffId"];
            }
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeId="+id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Occupation = reader["Occupation"].ToString();
                employee.Specialist = reader["Specialist"].ToString();
                employee.Salary = (int)reader["Salary"];
                employee.StaffId = (int)reader["StaffId"];
            
            return employee;
        }

        public int AddNewEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(EmployeeName,Occupation,Specialist,Salary,StaffId) VALUES('"+employee.EmployeeName+"','"+employee.Occupation+"','"+employee.Specialist+"',"+employee.Salary+","+employee.StaffId+")";
            return this.dataAccess.ExecuteQuery(sql);
        }

        public int GetStaffId(string staffName)
        {
            string StaffIdSearchSql = "SELECT * FROM Staffs WHERE StaffName = '" + staffName + "'";
            SqlDataReader reader = this.dataAccess.GetData(StaffIdSearchSql);
            reader.Read();
            int StaffId = (int)reader["StaffId"];
            return StaffId;
        }

    }
}
