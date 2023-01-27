using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Task_Project
{

    public partial class Employees : Form
    {
        Functions con;
        public Employees()
        {
            InitializeComponent();
            con = new Functions();
            showEmp();
            GetDepartment();
        }
        private void showEmp()
        {
            string Query = "select * From EmployeesTb1";
            EmployeeList.DataSource = con.GetData(Query);
        }

        private void GetDepartment()
        {
            String Query = "Select * from DepartmentTb1";
            DepCb.DisplayMember = con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource=con.GetData(Query)

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
