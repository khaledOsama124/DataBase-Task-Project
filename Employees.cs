using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            DepCb.DataSource = con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpName.Text == "" || GenCp.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySaTb.Text == "")
                {
                    MessageBox.Show("missing Data!!!");

                }
                else
                {
                    String Name = EmpName.Text;
                    String Gander = GenCp.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(GenCp.SelectedValue.ToString());
                    String Data_OF_Birth = DOBTb.Value.ToString();
                    String jdate = JDate.Value.ToString();
                    int salary = Convert.ToInt32(DailySaTb.Text);
                    string Query = "Insert into DepartmentTb1 values '{0}','{1}','{2}','{3}','{4}','{5}";
                    Query = string.Format(Query, Name, Gander, Dep, Data_OF_Birth, jdate, salary);
                    con.SetData(Query);
                    showEmp();
                    MessageBox.Show("Employee Tb1");
                    EmpName.Text = Query;
                    DailySaTb.Text = "";
                    GenCp.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;





                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void DeleteBtn_Click(object sender, PaintEventArgs e)
        {
            try
            {

                if (key==0)
                {
                    MessageBox.Show("missing Data!!!");

                }
                else
                {
                    
                    string Query = "Delete  DepartmentTb1 set EmpName =   where EmpId ={0}";
                    Query = string.Format(Query ,key);
                    con.SetData(Query);
                    showEmp();
                    MessageBox.Show("Employee Deleted!!");
                    EmpName.Text = Query;
                    DailySaTb.Text = "";
                    GenCp.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;





                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }



        }

        private void UpdateBtn_Click(
            object sender,
            PaintEventArgs e)
        {
            try
            {
                if (EmpName.Text == "" || GenCp.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySaTb.Text == "")
                {
                    MessageBox.Show("missing Data!!!");

                }
                else
                {
                    String Name = EmpName.Text;
                    String Gander = GenCp.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(GenCp.SelectedValue.ToString());
                    String Data_OF_Birth = DOBTb.Value.ToString();
                    String jdate = JDate.Value.ToString();
                    int salary = Convert.ToInt32(DailySaTb.Text);
                    string Query = "Update  DepartmentTb1 set EmpName =  '{0}',EmpGen ='{1}',EmpDep = '{2}',EmpDOB'{3}',EmpJdate'{4}',EmpSal='{5}' where EmpId ='{6}'";
                    Query = string.Format(Query, Name, Gander, Dep, Data_OF_Birth, jdate, salary, key);
                    con.SetData(Query);
                    showEmp();
                    MessageBox.Show("Employee ADD!!");
                    EmpName.Text = Query;
                    DailySaTb.Text = "";
                    GenCp.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;





                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

          

        }
       private void EmployeeList_cellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            EmpName.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCp.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            EmpName.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            if (EmpName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        int key = 0;



    }

}

