﻿using System;
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
    public partial class Department : Form
    {
        Functions Con;
        public Department()
        {
            InitializeComponent();
            Con = new Functions();
            showDepartments();
        }

        
        private void ListerDepartments()
        {
            string Query = "Select * FROM DepartmentTb1";
            DepList.DataSource = Con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text == "") 
                {
                    MessageBox.Show("missing Data!!!");
                }else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Insert into DepartmentTb1 values({'0'})";
                    Query = String.Format(DepNameTb.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {

            }

        }
    }
}
