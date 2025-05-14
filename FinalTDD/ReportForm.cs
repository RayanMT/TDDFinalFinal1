using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTDD
{
    public partial class ReportForm : Form
    {
        private RichTextBox richTextBox;

        public ReportForm(string reportText)
        {
            this.Text = "Vehicle Report";
            this.Width = 1000;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize RichTextBox
            richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                Multiline = true,
                ScrollBars = RichTextBoxScrollBars.Both,
                WordWrap = false,
                Font = new Font("Consolas", 10), // Monospaced = faster rendering
                BackColor = Color.White,
                ForeColor = Color.Black
            };

            // Performance: stop layout while adding large content
            this.SuspendLayout();
            richTextBox.SuspendLayout();

            // Set the text (fast even for large content)
            richTextBox.Text = reportText;

            // Resume layout
            richTextBox.ResumeLayout();
            this.Controls.Add(richTextBox);
            this.ResumeLayout();
        }
    }
}



