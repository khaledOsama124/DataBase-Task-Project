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

        public object DepName { get; private set; }

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
                if (DepName.Text == "")
                {
                    String Dep = DepName.Text;
                    String Query = "Insert into DepartmentTb1 values {('0')}";
                    Query = string.Format(DepName.Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Tb1");
                    DepName.Text = Query;




                }
                else
                {
                    MessageBox.Show("missing Data!!!");

                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
