﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recommendations
{
    public partial class CategoriesForm : Form
    {
        private SqlConnection sqlConnection = null;
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void cCloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fromCatReturnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecommendationsForm recommendations = new RecommendationsForm();
            recommendations.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM Products", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            catDataGV.DataSource = dataSet.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 1"; 
        }

        private void houseRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 2";
        }

        private void phoneRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 3";
        }

        private void beautiRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 4";
        }

        private void kitchenRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 5";
        }

        private void computerRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 6";
        }

        private void kidRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 7";
        }

        private void gameRB_CheckedChanged(object sender, EventArgs e)
        {
            (catDataGV.DataSource as DataTable).DefaultView.RowFilter = $"Category_Id = 8";
        }

       
    }
}
