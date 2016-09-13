using System.Drawing;
using System.Windows.Forms;

namespace New_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			FillAreaWithLabels();
        }

	    private void FillAreaWithLabels()
	    {
		    int[] countForPlacement = { 3, 5, 7, 7, 7, 5, 3 };
			int[] valuesForPlacement = { 5, 3, 1, 1, 1, 3, 5 };

			for (var i = 0; i < 7; i++)
			{
				for (var j = 0; j < countForPlacement[i]; j++)
				{
					Panel.Controls.Add(
						new Label
						{
							Dock = DockStyle.Fill,
							BackColor = Color.Black
						}, 
						i * 2 + 1, 
						j * 2 + valuesForPlacement[i]
					);
				}
			}
	    }

	}
}
