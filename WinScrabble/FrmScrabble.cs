using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{
    public partial class FrmScrabble : Form
    {
        Joueur J1;
        Joueur J2;
        public FrmScrabble()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            string joueur1 = txtJoueur1.Text;
            string joueur2 = txtJoueur2.Text;

            Joueur J1 = new Joueur(joueur1);
            Joueur J2 = new Joueur(joueur2);


            
            txtJoueur1.Clear();
            txtJoueur2.Clear();
            joueur1 = txtJoueur1.Text;
            joueur2 = txtJoueur2.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
