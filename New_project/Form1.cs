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
            Panel.GetControlFromPosition(0,0).Size = new Size(15,15);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
