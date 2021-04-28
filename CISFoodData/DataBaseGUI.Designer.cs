namespace CISFoodData
{
    partial class DataBaseGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Query1 = new System.Windows.Forms.Button();
            this.Query2 = new System.Windows.Forms.Button();
            this.Query3 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Query4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Query5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Query6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Query7 = new System.Windows.Forms.Button();
            this.Query8 = new System.Windows.Forms.Button();
            this.Query9 = new System.Windows.Forms.Button();
            this.Query10 = new System.Windows.Forms.Button();
            this.Query11 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Query12 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Query1
            // 
            this.Query1.Location = new System.Drawing.Point(561, 70);
            this.Query1.Margin = new System.Windows.Forms.Padding(4);
            this.Query1.Name = "Query1";
            this.Query1.Size = new System.Drawing.Size(168, 70);
            this.Query1.TabIndex = 0;
            this.Query1.Text = "Select Categories";
            this.Query1.UseVisualStyleBackColor = true;
            this.Query1.Click += new System.EventHandler(this.Query1_Click);
            // 
            // Query2
            // 
            this.Query2.Location = new System.Drawing.Point(385, 70);
            this.Query2.Margin = new System.Windows.Forms.Padding(4);
            this.Query2.Name = "Query2";
            this.Query2.Size = new System.Drawing.Size(168, 70);
            this.Query2.TabIndex = 1;
            this.Query2.Text = "Search by partial Discrp";
            this.Query2.UseVisualStyleBackColor = true;
            this.Query2.Click += new System.EventHandler(this.Query2_Click);
            // 
            // Query3
            // 
            this.Query3.Location = new System.Drawing.Point(385, 233);
            this.Query3.Margin = new System.Windows.Forms.Padding(4);
            this.Query3.Name = "Query3";
            this.Query3.Size = new System.Drawing.Size(168, 70);
            this.Query3.TabIndex = 2;
            this.Query3.Text = "Search Nutrients By FoodID";
            this.Query3.UseVisualStyleBackColor = true;
            this.Query3.Click += new System.EventHandler(this.Query3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(136, 485);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(975, 346);
            this.dataGridView.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1044, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 37);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "FoodID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 17;
            // 
            // Query4
            // 
            this.Query4.Location = new System.Drawing.Point(385, 148);
            this.Query4.Margin = new System.Windows.Forms.Padding(4);
            this.Query4.Name = "Query4";
            this.Query4.Size = new System.Drawing.Size(168, 70);
            this.Query4.TabIndex = 18;
            this.Query4.Text = "All Foods By Category";
            this.Query4.UseVisualStyleBackColor = true;
            this.Query4.Click += new System.EventHandler(this.Query4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "CategoryID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1044, 176);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 37);
            this.textBox2.TabIndex = 20;
            // 
            // Query5
            // 
            this.Query5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Query5.Location = new System.Drawing.Point(177, 148);
            this.Query5.Margin = new System.Windows.Forms.Padding(4);
            this.Query5.Name = "Query5";
            this.Query5.Size = new System.Drawing.Size(168, 70);
            this.Query5.TabIndex = 21;
            this.Query5.Text = "Category Report";
            this.Query5.UseVisualStyleBackColor = false;
            this.Query5.Click += new System.EventHandler(this.Query5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1044, 222);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 37);
            this.textBox3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(963, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "NutrientID";
            // 
            // Query6
            // 
            this.Query6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Query6.Location = new System.Drawing.Point(177, 225);
            this.Query6.Margin = new System.Windows.Forms.Padding(4);
            this.Query6.Name = "Query6";
            this.Query6.Size = new System.Drawing.Size(168, 70);
            this.Query6.TabIndex = 24;
            this.Query6.Text = "Search by Category and Nutrient IDs";
            this.Query6.UseVisualStyleBackColor = false;
            this.Query6.Click += new System.EventHandler(this.Query6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1044, 279);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 37);
            this.textBox4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(918, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Number of Results";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(957, 342);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(65, 37);
            this.textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1105, 342);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 37);
            this.textBox6.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Between";
            // 
            // Query7
            // 
            this.Query7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Query7.Location = new System.Drawing.Point(984, 388);
            this.Query7.Margin = new System.Windows.Forms.Padding(4);
            this.Query7.Name = "Query7";
            this.Query7.Size = new System.Drawing.Size(168, 70);
            this.Query7.TabIndex = 30;
            this.Query7.Text = "Foods in Calorie Range";
            this.Query7.UseVisualStyleBackColor = false;
            this.Query7.Click += new System.EventHandler(this.Query7_Click);
            // 
            // Query8
            // 
            this.Query8.Location = new System.Drawing.Point(177, 310);
            this.Query8.Margin = new System.Windows.Forms.Padding(4);
            this.Query8.Name = "Query8";
            this.Query8.Size = new System.Drawing.Size(168, 70);
            this.Query8.TabIndex = 31;
            this.Query8.Text = "Nutrients and there Measurments";
            this.Query8.UseVisualStyleBackColor = true;
            this.Query8.Click += new System.EventHandler(this.Query8_Click);
            // 
            // Query9
            // 
            this.Query9.Location = new System.Drawing.Point(385, 310);
            this.Query9.Margin = new System.Windows.Forms.Padding(4);
            this.Query9.Name = "Query9";
            this.Query9.Size = new System.Drawing.Size(168, 70);
            this.Query9.TabIndex = 32;
            this.Query9.Text = "Foods With Most Combined Nutrients";
            this.Query9.UseVisualStyleBackColor = true;
            this.Query9.Click += new System.EventHandler(this.Query9_Click);
            // 
            // Query10
            // 
            this.Query10.Location = new System.Drawing.Point(177, 70);
            this.Query10.Margin = new System.Windows.Forms.Padding(4);
            this.Query10.Name = "Query10";
            this.Query10.Size = new System.Drawing.Size(168, 70);
            this.Query10.TabIndex = 33;
            this.Query10.Text = "Select All Foods From Database";
            this.Query10.UseVisualStyleBackColor = true;
            this.Query10.Click += new System.EventHandler(this.Query10_Click);
            // 
            // Query11
            // 
            this.Query11.Location = new System.Drawing.Point(561, 148);
            this.Query11.Margin = new System.Windows.Forms.Padding(4);
            this.Query11.Name = "Query11";
            this.Query11.Size = new System.Drawing.Size(168, 70);
            this.Query11.TabIndex = 34;
            this.Query11.Text = "Set Name for Food";
            this.Query11.UseVisualStyleBackColor = true;
            this.Query11.Click += new System.EventHandler(this.Query11_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(737, 171);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 37);
            this.textBox7.TabIndex = 35;
            // 
            // Query12
            // 
            this.Query12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Query12.Location = new System.Drawing.Point(561, 233);
            this.Query12.Margin = new System.Windows.Forms.Padding(4);
            this.Query12.Name = "Query12";
            this.Query12.Size = new System.Drawing.Size(168, 70);
            this.Query12.TabIndex = 36;
            this.Query12.Text = "Highest Nutrient Amount in Calorie Range";
            this.Query12.UseVisualStyleBackColor = false;
            this.Query12.Click += new System.EventHandler(this.Query12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search by partial Discript:";
            // 
            // DataBaseGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 925);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Query12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Query11);
            this.Controls.Add(this.Query10);
            this.Controls.Add(this.Query9);
            this.Controls.Add(this.Query8);
            this.Controls.Add(this.Query7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Query6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Query5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Query4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Query3);
            this.Controls.Add(this.Query2);
            this.Controls.Add(this.Query1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataBaseGUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Query1;
        private System.Windows.Forms.Button Query2;
        private System.Windows.Forms.Button Query3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Query4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Query5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Query6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Query7;
        private System.Windows.Forms.Button Query8;
        private System.Windows.Forms.Button Query9;
        private System.Windows.Forms.Button Query10;
        private System.Windows.Forms.Button Query11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Query12;
        private System.Windows.Forms.Label label7;
    }
}

