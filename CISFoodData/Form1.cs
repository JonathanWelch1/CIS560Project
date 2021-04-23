using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Query1_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "1";
        }

        private void Query2_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "2";

        }

        private void Query3_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "3";

        }

        private void Query4_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "4";
        }

        private void Query5_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "5";
        }

        private void Query6_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "6";
        }

        private void Query7_Click(object sender, EventArgs e)
        {
            SqlOutPutTextBox.Text = "7";
        }

        private void Query8_Click(object sender, EventArgs e)
        {

            SqlOutPutTextBox.Text = "8";
        }

        private void Query9_Click(object sender, EventArgs e)
        {
            SqlOutPutTextBox.Text = "9";
        }

        private void Query10_Click(object sender, EventArgs e)
        {
            SqlOutPutTextBox.Text = "10";
        }

        private void Query11_Click(object sender, EventArgs e)
        {
            SqlOutPutTextBox.Text = "11";
        }

        private void Query12_Click(object sender, EventArgs e)
        {
            SqlOutPutTextBox.Text = "12";
        }

        private void ClearTextBox_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void ClearDisplay()
        {
            SqlOutPutTextBox.Text = "";
        }

    }
}
