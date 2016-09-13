using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 14; i=i+2)
                for (int j = 1; j <= 14; j= j +2)
                {
                    Label Cubicle = new Label();
                    Cubicle = new System.Windows.Forms.Label();
                    Cubicle.Dock = System.Windows.Forms.DockStyle.Fill;
                    Cubicle.BackColor = Color.Black;
                    Panel.Controls.Add(Cubicle, i, j);
                }
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Control button { get; set; }
    }
}
