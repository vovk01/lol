using System.Drawing;
using System.Windows.Forms;

namespace New_project
{
    public partial class Form1 : Form
    {
	    private Label[] _playerFields;
	    private const int CountOfPlayerFields = 37;

        public Form1()
        {
            InitializeComponent();
			InitializeLabelArray();
			FillAreaWithLabels();
        }

	    private void InitializeLabelArray()
	    {
			_playerFields = new Label[CountOfPlayerFields];

		    for (var i = 0; i < CountOfPlayerFields; i++)
		    {
			    _playerFields[i] = new Label()
			    {
				    Dock = DockStyle.Fill,
					BackColor = Color.Black
			    };
		    }
	    }

	    private void FillAreaWithLabels()
	    {
		    var index = 0;

		    int[] countForPlacement = { 3, 5, 7, 7, 7, 5, 3 };
			int[] valuesForPlacement = { 5, 3, 1, 1, 1, 3, 5 };

			for (var i = 0; i < 7; i++)
			{
				for (var j = 0; j < countForPlacement[i]; j++)
				{
					Panel.Controls.Add(_playerFields[index++], i * 2 + 1, j * 2 + valuesForPlacement[i]);
				}
			}
	    }

	}
}
