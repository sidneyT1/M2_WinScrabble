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

        Joueur joueurActuel; // Pour suivre le joueur actuel
        int tourJoueur = 0; // Pour suivre le nombre de tours de chaque joueur
        Random random = new Random();



        public FrmScrabble()
        {
            InitializeComponent();
            
        }


      

        public void btnCommencer_Click(object sender, EventArgs e)
        {
            J1 = new Joueur(txtJoueur1.Text);
            J2 = new Joueur(txtJoueur2.Text);

            
            nomJoueur1.Text = txtJoueur1.Text;
            nomJoueur2.Text = txtJoueur2.Text;

            
            
            string lettres = "";
            for (int i = 0; i < 7; i++)
            {
                lettres += (char)('A' + random.Next(26));
            }
            txtLettres.Text = lettres;


            if (random.Next(2) == 0)
            {
                joueurActuel = J1;
            }
            else
            {
                joueurActuel = J2;
            }
            lblJoueurActuel.Text = "Tour de " + joueurActuel.nom; //affichage tour au début de la partie
        }

        private void btnProposerMot_Click(object sender, EventArgs e)
        {
            if (tourJoueur < 20) 
            {
                string motPropose = txtMotPropose.Text.ToUpper(); 
                joueurActuel.AjouterMot(motPropose); 
                int scoreJoueur = joueurActuel.GetTotalPoints(); 
                AfficherScore(scoreJoueur);

                string lettres = "";
                for (int i = 0; i < 7; i++)
                {
                    lettres += (char)('A' + random.Next(26));
                }
                txtLettres.Text = lettres;


                if (joueurActuel == J1)
                {
                    joueurActuel = J2;
                }
                else
                {
                    joueurActuel = J1;
                }

                tourJoueur++; 
                lblJoueurActuel.Text = "Tour de " + joueurActuel.nom; // affichage du tour pendant la partie
            }
            else
            {
                
                AfficherResultatFinal();
            }
            txtMotPropose.Clear();
        }

        private void AfficherScore(int score) 
        {
            if (joueurActuel == J1)
                lblScoreJoueur1.Text = "Score: " + score.ToString();
            else
                lblScoreJoueur2.Text = "Score: " + score.ToString();
        }

        private void AfficherResultatFinal()
        {
            // Afficher le nom du gagnant
            string gagnant;
            if (J1.GetTotalPoints() > J2.GetTotalPoints())
            {
                gagnant = J1.nom;
            }
            else
            {
                gagnant = J2.nom;
            }
            MessageBox.Show("Le gagnant est " + gagnant);

            // Afficher les mots du gagnant et le meilleur mot de chaque joueur
            List<string> motsGagnant;
            string meilleurMotGagnant;

            if (J1.GetTotalPoints() > J2.GetTotalPoints())
            {
                motsGagnant = J1.GetLesMots();
                meilleurMotGagnant = J1.MotMeilleur();
            }
            else
            {
                motsGagnant = J2.GetLesMots();
                meilleurMotGagnant = J2.MotMeilleur();
            }

            string message = "Mots du gagnant: \n";
            foreach (string mot in motsGagnant)
            {
                message += mot + "\n";
            }
            message += "Meilleur mot: " + meilleurMotGagnant;
            MessageBox.Show(message);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblScoreJoueur2_Click(object sender, EventArgs e)
        {

        }

        private void lblScoreJoueur1_Click(object sender, EventArgs e)
        {

        }

       


      
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotPropose_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomJoueur2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmScrabble_Load(object sender, EventArgs e)
        {

        }
    }
}
