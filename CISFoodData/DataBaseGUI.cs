using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CISFoodData
{
    public partial class DataBaseGUI : Form
    {

       

        public DataBaseGUI()
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
         
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("User must enter FoodID");
                    return;
                }
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
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("User must enter CategoryID");
                return;
            }
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
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("User must enter rank");
                return;
            }
            connectionString.Open();
            int NutrientID = Convert.ToInt32(textBox3.Text);
            var adp = new SqlDataAdapter("Select Top(100) F.Discription ,N.NutrientName, A.Amount, M.UnitMeasurement From Food.Nutrient N Inner Join Food.Amount A ON A.NutrientID = N.NutrientID Inner Join Food.Food F ON F.FoodID = A.FoodID Inner Join Food.Measurement M ON M.MeasurementID = A.MeasurementID  Where N.NutrientID = " + NutrientID + " Order By A.Amount DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("User must enter CategoryID");
                return;
            }
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("User must enter NutrientID");
                return;
            }
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("User must enter rank");
                return;
            }
            connectionString.Open();
            int CategoryID = Convert.ToInt32(textBox2.Text);
            int NutrientID = Convert.ToInt32(textBox3.Text);
            int rank = Convert.ToInt32(textBox4.Text);
            var adp = new SqlDataAdapter("SELECT TOP("+rank+ ")F.Discription AS 'FoodName', N.NutrientName, A.Amount FROM FOOD.Nutrient N INNER JOIN FOOD.Amount A ON A.NutrientID = N.NutrientID INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID INNER JOIN FOOD.FoodCategoryL FCL ON FCL.FoodID = F.FoodID INNER JOIN FOOD.Category C ON C.CategoryID = FCL.CategoryID WHERE C.CategoryID =" + CategoryID + "AND N.NutrientID =" + NutrientID+ "ORDER BY A.Amount DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("User must enter rank");
                return;
            }
            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("User must enter Low Value");
                return;
            }
            if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("User must enter High value");
                return;
            }
            connectionString.Open();
            int LOW = Convert.ToInt32(textBox5.Text);
            int HIGH = Convert.ToInt32(textBox6.Text);
            int rank = Convert.ToInt32(textBox4.Text);
            var adp = new SqlDataAdapter("SELECT TOP("+ rank +") F.Discription AS 'FoodName', M.UnitMeasurement, N.NutrientName, A.Amount FROM FOOD.Nutrient N INNER JOIN FOOD.Amount A ON A.NutrientID = N.NutrientID INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID INNER JOIN FOOD.Measurement M ON M.MeasurementID = A.MeasurementID WHERE M.MeasurementID = 0 AND A.Amount BETWEEN " + LOW + " AND " + HIGH + " Order BY A.Amount DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("User must enter categoryID");
                return;
            }
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("User must enter NutrientID");
                return;
            }
            connectionString.Open();
            int CategoryID = Convert.ToInt32(textBox2.Text);
            int NutrientID = Convert.ToInt32(textBox3.Text);
            var adp = new SqlDataAdapter("WITH FoodofCategory(FoodID, Discription, CategoryName) AS (SELECT FD.FoodID, FD.Discription, C.CategoryName FROM Food.Category C INNER JOIN Food.FoodCategoryL L ON L.CategoryID = C.CategoryID INNER JOIN Food.Food FD ON FD.FoodID = L.FoodID WHERE C.CategoryID =" + CategoryID+ "GROUP BY FD.FoodID, FD.Discription, C.CategoryName ) SELECT TOP 50 F.CategoryName, F.Discription, A.Amount, M.UnitMeasurement FROM FoodofCategory F INNER JOIN Food.Amount A ON A.FoodID = F.FoodID INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID WHERE N.NutrientID = " + NutrientID + "ORDER BY A.Amount DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query9_Click(object sender, EventArgs e)
        {
            if(textBox4.Text.Equals(""))
            {
                MessageBox.Show("User must enter rank");
                return;
            }
            connectionString.Open();
            int rank = Convert.ToInt32(textBox4.Text);
            
            var adp = new SqlDataAdapter("SELECT TOP("+ rank + ") F.FoodID, F.Discription, RANK() OVER(ORDER BY Amount.Total DESC) AS [RankOfFood] FROM ( SELECT TOP(" + rank+ ") A.FoodID, SUM(A.Amount) AS Total FROM Food.Amount A INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID GROUP BY A.FoodID ORDER BY Total DESC) AS Amount INNER JOIN Food.Food F ON F.FoodID = Amount.FoodID ORDER BY Amount.Total DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query10_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            var adp = new SqlDataAdapter("SELECT * FROM Food.Category C Inner join Food.FoodCategoryL FCL ON FCL.CategoryID = C.CategoryID Inner join Food.Food F ON F.FoodID = FCL.FoodID INNER JOIN Food.Amount A ON A.FoodID = F.FoodID INNER JOIN Food.Measurement M ON M.MeasurementID = A.MeasurementID INNER JOIN Food.Nutrient N ON N.NutrientID = A.NutrientID", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("User must enter FoodID");
                return;
            }
            if (textBox7.Text.Equals(""))
            {
                MessageBox.Show("User must enter Food name");
                return;
            }
            connectionString.Open();
            int foodID = Convert.ToInt32(textBox1.Text);
            string name = Convert.ToString(textBox7.Text);
            var adp = new SqlDataAdapter("UPDATE Food.Food SET Name ='" + name + "' WHERE FoodID = " + foodID + "SELECT * FROM Food.Food", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }

        private void Query12_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("User must enter rank");
                return;
            }
            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("User must enter Low value");
                return;
            }
            if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("User must enter High value");
                return;
            }
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("User must enter  nutrientID");
                return;
            }
            connectionString.Open();
            int rank = Convert.ToInt32(textBox4.Text);
            int LOW = Convert.ToInt32(textBox5.Text);
            int HIGH = Convert.ToInt32(textBox6.Text);
            int NutrientID = Convert.ToInt32(textBox3.Text);
            var adp = new SqlDataAdapter("WITH Calories(Discription, Amount) AS (SELECT F.Discription, A.Amount FROM FOOD.Amount A INNER JOIN FOOD.Measurement M ON M.MeasurementID = A.MeasurementID INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID WHERE M.MeasurementID = 0 AND A.Amount BETWEEN " + LOW + " AND " + HIGH + ") SELECT TOP(" + rank + ") CAL.Discription AS 'FoodName', CAL.Amount AS 'Calories', N.NutrientName, A.Amount FROM FOOD.Nutrient N INNER JOIN FOOD.Amount A ON A.NutrientID = N.NutrientID INNER JOIN FOOD.Food F ON F.FoodID = A.FoodID INNER JOIN FOOD.FoodCategoryL FCL ON FCL.FoodID = F.FoodID INNER JOIN FOOD.Category C ON C.CategoryID = FCL.CategoryID INNER JOIN FOOD.Measurement M ON M.MeasurementID = A.MeasurementID INNER JOIN Calories CAL ON CAL.Discription = F.Discription WHERE N.NutrientID ="+ NutrientID + " AND A.Amount IS NOT NULL ORDER BY A.Amount DESC", connectionString);
            var dt = new DataTable();
            adp.Fill(dt);
            dataGridView.DataSource = dt;
            connectionString.Close();
        }
    }
}
