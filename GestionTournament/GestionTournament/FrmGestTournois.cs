using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTournament
{
    public partial class FrmGestTournois : Form
    {
        int x = 10;
        int y = 10;
        public FrmGestTournois()
        {
            InitializeComponent();





            TextBox txtNamePlayer = new TextBox();
            txtNamePlayer.Name = "txtNamePlayer";
            txtNamePlayer.Location = new Point(x,y);


            this.Controls.Add(txtNamePlayer);






        }
    }
}
