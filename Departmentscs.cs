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
    public partial class Departmentscs : Form
    {
        Functions con;
        public Departmentscs()
        {
            InitializeComponent();
            con = new Functions();
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            String Query = "select * From DepartmentTb1";
            DepList.DataSource =con.GetData(Query);

        }
        
        private void AddBtn_click(object sender,EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing Data!!!");

                }
                else
                {
                    String Dep = DepNameTb.Text;
                    string Query = "Insert into DepartmentTb1 values {('0')}";
                    Query = string.Format(Query,Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Tb1");
                    DepNameTb.Text = Query;




                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
        int key = 0;
        private void Deplist_cellcontentClick(object sender,EventArgs e)
        {
            
                DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
                if(DepNameTb.Text == "")
                {
                     key = 0;
                }
                else
            {
                key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
            

        }
        private void EditBtn_click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing Data!!!");

                }
                else
                {
                    String Dep = DepNameTb.Text;
                    string Query = "Update  DepartmentTb1 Set DepName  values '{0}' Where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text,key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated");
                    DepNameTb.Text = Query;




                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
        private void DeleteBtn_click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing Data!!!");

                }
                else
                {
                    String Dep = DepNameTb.Text;
                    string Query = "Delete From DepartmentTb1  Where DepId = {0}";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!");
                    DepNameTb.Text = Query;




                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Empbtl_click(object sender,EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }
    }
}
