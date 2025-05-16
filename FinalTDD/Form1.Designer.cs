using System.Windows.Forms;
using System.Drawing;


namespace FinalTDD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Panel panelComboBox1;
        private System.Windows.Forms.Panel panelComboBox2;
        private Label arrowLabel1;
        private Label arrowLabel2;


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
            button1.Location = new System.Drawing.Point(50, 643);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(215, 60);
            button1.TabIndex = 0;
            button1.Text = "+ Add Vehicle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAddVehicle_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            button2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.Location = new System.Drawing.Point(318, 643);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(215, 60);
            button2.TabIndex = 1;
            button2.Text = "Generate 10,000";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnGenerateRandom_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            button3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button3.Location = new System.Drawing.Point(208, 737);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(185, 85);
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
            label1.Location = new System.Drawing.Point(33, 172);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(214, 49);
            label1.TabIndex = 3;
            label1.Text = "Vehicle Number";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.MidnightBlue;
            label2.Location = new System.Drawing.Point(63, 235);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(164, 49);
            label2.TabIndex = 4;
            label2.Text = "Model";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.MidnightBlue;
            label3.Location = new System.Drawing.Point(63, 322);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(164, 49);
            label3.TabIndex = 6;
            label3.Text = "Manufacturer";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.MidnightBlue;
            label4.Location = new System.Drawing.Point(63, 398);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(164, 49);
            label4.TabIndex = 5;
            label4.Text = "Year";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.MidnightBlue;
            label5.Location = new System.Drawing.Point(63, 468);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(164, 49);
            label5.TabIndex = 8;
            label5.Text = "Type";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.MidnightBlue;
            label6.Location = new System.Drawing.Point(63, 542);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(164, 49);
            label6.TabIndex = 7;
            label6.Text = "Maintainance";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(338, 172);
            textBox1.Margin = new System.Windows.Forms.Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(168, 41);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox2.Location = new System.Drawing.Point(338, 335);
            textBox2.Margin = new System.Windows.Forms.Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(168, 41);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox3.Location = new System.Drawing.Point(338, 249);
            textBox3.Margin = new System.Windows.Forms.Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(168, 41);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            numericUpDown1.Location = new System.Drawing.Point(338, 409);
            numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            numericUpDown1.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(168, 40);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // comboBox1.Items.AddRange(new object[] { "Bus", "Commercial", "Private", "Truck" });
            comboBox1.Location = new System.Drawing.Point(338, 481);
            comboBox1.Margin = new System.Windows.Forms.Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(168, comboBox1.Height);
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
            //comboBox2.Items.AddRange(new object[] { "Ok", "Needs Service" });
            comboBox2.Location = new System.Drawing.Point(338, 555);
            comboBox2.Margin = new System.Windows.Forms.Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(168, comboBox2.Height);
            comboBox2.TabIndex = 14;
            comboBox2.DrawItem += DrawComboBoxItem;



            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.car_top;
            pictureBox2.Location = new System.Drawing.Point(62, -48);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(471, 240);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_doodles;
            ClientSize = new System.Drawing.Size(598, 659);
            //Controls.Add(comboBox2);
            // Controls.Add(comboBox1);
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

            // panelComboBox1 (Type)
            panelComboBox1 = new Panel();
            panelComboBox1.Location = new System.Drawing.Point(338, 481);  // Match comboBox1's original spot
            panelComboBox1.Size = new System.Drawing.Size(168, 41);  // Same as textboxes
            panelComboBox1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelComboBox1);

            comboBox1.Parent = panelComboBox1;
            comboBox1.Location = new Point(0, (panelComboBox1.Height - comboBox1.Height) / 2);

            // Arrow Label for Type ComboBox
            arrowLabel1 = new Label();
            arrowLabel1.Text = "▼";
            arrowLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            arrowLabel1.AutoSize = false;
            arrowLabel1.TextAlign = ContentAlignment.MiddleCenter;
            arrowLabel1.Size = new Size(20, panelComboBox1.Height);
            arrowLabel1.Location = new Point(panelComboBox1.Width - 20, 0);
            arrowLabel1.BackColor = Color.Transparent;
            panelComboBox1.Controls.Add(arrowLabel1);

            // panelComboBox2 (Maintenance)
            panelComboBox2 = new Panel();
            panelComboBox2.Location = new System.Drawing.Point(338, 555);  // Match comboBox2's original spot
            panelComboBox2.Size = new System.Drawing.Size(168, 41);  // Same as textboxes
            panelComboBox2.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelComboBox2);

            comboBox2.Parent = panelComboBox2;
            comboBox2.Location = new Point(0, (panelComboBox2.Height - comboBox2.Height) / 2);

            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();




            // Arrow Label for Maintenance ComboBox
            arrowLabel2 = new Label();
            arrowLabel2.Text = "▼";
            arrowLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            arrowLabel2.AutoSize = false;
            arrowLabel2.TextAlign = ContentAlignment.MiddleCenter;
            arrowLabel2.Size = new Size(20, panelComboBox2.Height);
            arrowLabel2.Location = new Point(panelComboBox2.Width - 20, 0);
            arrowLabel2.BackColor = Color.Transparent;
            panelComboBox2.Controls.Add(arrowLabel2);


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