using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLocalGame_Click(object sender, EventArgs e)
        {
            using (GameWindow f = new GameWindow())
            {
                f.ShowDialog();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
