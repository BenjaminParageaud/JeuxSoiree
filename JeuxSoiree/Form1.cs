using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuxSoiree
{
    public partial class Menu_main : Form
    {
        public Menu_main()
        {
            InitializeComponent();
            main_property();
        }

        private void main_property()
        {
            this.Text = "My game";
            this.Size = new Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment quitter?", "Quitter", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void actionVeriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_Verite action_verite_game = new Action_Verite();
            action_verite_game.Tag = this;
            action_verite_game.Show();

        }

        private void Menu_main_Load(object sender, EventArgs e)
        {

        }
    }
}
