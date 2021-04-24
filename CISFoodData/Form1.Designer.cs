namespace CISFoodData
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Query1
            // 
            this.Query1.Location = new System.Drawing.Point(89, 57);
            this.Query1.Name = "Query1";
            this.Query1.Size = new System.Drawing.Size(126, 57);
            this.Query1.TabIndex = 0;
            this.Query1.Text = "Select Categories";
            this.Query1.UseVisualStyleBackColor = true;
            this.Query1.Click += new System.EventHandler(this.Query1_Click);
            // 
            // Query2
            // 
            this.Query2.Location = new System.Drawing.Point(289, 57);
            this.Query2.Name = "Query2";
            this.Query2.Size = new System.Drawing.Size(126, 57);
            this.Query2.TabIndex = 1;
            this.Query2.Text = "Food Descrp";
            this.Query2.UseVisualStyleBackColor = true;
            this.Query2.Click += new System.EventHandler(this.Query2_Click);
            // 
            // Query3
            // 
            this.Query3.Location = new System.Drawing.Point(486, 57);
            this.Query3.Name = "Query3";
            this.Query3.Size = new System.Drawing.Size(126, 57);
            this.Query3.TabIndex = 2;
            this.Query3.Text = "Search Neutrient By ID";
            this.Query3.UseVisualStyleBackColor = true;
            this.Query3.Click += new System.EventHandler(this.Query3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(89, 365);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(731, 281);
            this.dataGridView.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 31);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FoodID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 17;
            // 
            // Query4
            // 
            this.Query4.Location = new System.Drawing.Point(661, 57);
            this.Query4.Name = "Query4";
            this.Query4.Size = new System.Drawing.Size(126, 57);
            this.Query4.TabIndex = 18;
            this.Query4.Text = "Search By Category\r\n";
            this.Query4.UseVisualStyleBackColor = true;
            this.Query4.Click += new System.EventHandler(this.Query4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CategoryID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(713, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 31);
            this.textBox2.TabIndex = 20;
            // 
            // Query5
            // 
            this.Query5.Location = new System.Drawing.Point(89, 154);
            this.Query5.Name = "Query5";
            this.Query5.Size = new System.Drawing.Size(126, 57);
            this.Query5.TabIndex = 21;
            this.Query5.Text = "Searching By NutrientID";
            this.Query5.UseVisualStyleBackColor = true;
            this.Query5.Click += new System.EventHandler(this.Query5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 230);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 31);
            this.textBox3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "NutrientID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 765);
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
            this.Name = "Form1";
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
    }
}

