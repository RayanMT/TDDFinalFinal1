namespace FinalTDD
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(81, 1029);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(349, 96);
            button1.TabIndex = 0;
            button1.Text = "+ Add Vehicle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAddVehicle_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            button2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.Location = new System.Drawing.Point(517, 1029);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(349, 96);
            button2.TabIndex = 1;
            button2.Text = "Generate 10,000";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnGenerateRandom_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            button3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button3.Location = new System.Drawing.Point(338, 1179);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(300, 136);
            button3.TabIndex = 2;
            button3.Text = "Show Report";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnShowReport_Click;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.MidnightBlue;
            label1.Location = new System.Drawing.Point(54, 275);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(347, 78);
            label1.TabIndex = 3;
            label1.Text = "Vehicle Number";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.MidnightBlue;
            label2.Location = new System.Drawing.Point(103, 376);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(266, 78);
            label2.TabIndex = 4;
            label2.Text = "Model";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.MidnightBlue;
            label3.Location = new System.Drawing.Point(103, 515);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(266, 78);
            label3.TabIndex = 6;
            label3.Text = "Manufacturer";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.MidnightBlue;
            label4.Location = new System.Drawing.Point(103, 636);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(266, 78);
            label4.TabIndex = 5;
            label4.Text = "Year";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.MidnightBlue;
            label5.Location = new System.Drawing.Point(103, 748);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(266, 78);
            label5.TabIndex = 8;
            label5.Text = "Type";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.MidnightBlue;
            label6.Location = new System.Drawing.Point(103, 867);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(266, 78);
            label6.TabIndex = 7;
            label6.Text = "Maintainance";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(549, 275);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(270, 63);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox2.Location = new System.Drawing.Point(549, 536);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(270, 63);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox3.Location = new System.Drawing.Point(549, 398);
            textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(270, 63);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            numericUpDown1.Location = new System.Drawing.Point(549, 655);
            numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            numericUpDown1.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(344, 59);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboBox1.DropDownHeight = 70;
            comboBox1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 10;
            comboBox1.Items.AddRange(new object[] { "Bus", "Commercial", "Private", "Truck" });
            comboBox1.Location = new System.Drawing.Point(549, 769);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(300, 16);
            comboBox1.TabIndex = 13;
            comboBox1.DrawItem += DrawComboBoxItem;
            // 
            // comboBox2
            // 
            comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboBox2.DropDownHeight = 70;
            comboBox2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.ItemHeight = 10;
            comboBox2.Items.AddRange(new object[] { "Ok", "Needs Service" });
            comboBox2.Location = new System.Drawing.Point(549, 888);
            comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(300, 16);
            comboBox2.TabIndex = 14;
            comboBox2.DrawItem += DrawComboBoxItem;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.car_top;
            pictureBox2.Location = new System.Drawing.Point(101, -76);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(765, 384);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_doodles;
            ClientSize = new System.Drawing.Size(971, 1398);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}