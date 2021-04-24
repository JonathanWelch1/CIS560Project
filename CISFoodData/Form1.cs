﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using FoodData;

namespace CISFoodData
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connectionString = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog = joselopez44528; User ID = joselopez44528; Password= ksu10191947* ");
        private void Query1_Click(object sender, EventArgs e)
        {

            
            connectionString.Open();
            var adp = new SqlDataAdapter("Select * From Food.Category C", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query2_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            var adp = new SqlDataAdapter("Select F.FoodID, F.Discription From Food.Food F", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();


        }

        private void Query3_Click(object sender, EventArgs e)
        {
         
                connectionString.Open();
                int FoodID = Convert.ToInt32(textBox1.Text);
                var adp = new SqlDataAdapter("Select N.NutrientName, A.Amount, M.UnitMeasurement From Food.Amount A Inner join Food.Nutrient N ON N.NutrientID = A.NutrientID Inner Join Food.Measurement M ON M.MeasurementID = A.MeasurementID Where A.FoodID = " + FoodID + " and A.Amount Is Not Null", connectionString);
                var dt = new DataTable();
                adp.Fill(dt);
                dataGridView.DataSource = dt;
                connectionString.Close();
        }

        private void Query4_Click_1(object sender, EventArgs e)
        {
            connectionString.Open();
            int CategoryID = Convert.ToInt32(textBox2.Text);
            var adp = new SqlDataAdapter("Select C.CategoryName, F.Discription From Food.Category C Inner Join Food.FoodCategoryL L ON L.CategoryID = C.CategoryID Inner Join Food.Food F ON F.FoodID = L.FoodID Where C.CategoryID = " + CategoryID + " Group By CategoryName, Discription", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query5_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            int NutrientID = Convert.ToInt32(textBox3.Text);
            var adp = new SqlDataAdapter("Select Top(100) F.Discription ,N.NutrientName, A.Amount, M.UnitMeasurement From Food.Nutrient N Inner Join Food.Amount A ON A.NutrientID = N.NutrientID Inner Join Food.Food F ON F.FoodID = A.FoodID Inner Join Food.Measurement M ON M.MeasurementID = A.MeasurementID  Where N.NutrientID = " + NutrientID + " Order By A.Amount DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }


        private void ClearTextBox_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void ClearDisplay()
        {

        }

    }
}
