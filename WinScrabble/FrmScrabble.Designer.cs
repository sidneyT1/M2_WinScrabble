
namespace WinScrabble
{
    partial class FrmScrabble
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtJoueur1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJoueur2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.txtLettres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotPropose = new System.Windows.Forms.TextBox();
            this.nomJoueur1 = new System.Windows.Forms.TextBox();
            this.nomJoueur2 = new System.Windows.Forms.TextBox();
            this.btnProposerMot = new System.Windows.Forms.Button();
            this.lblScoreJoueur1 = new System.Windows.Forms.Label();
            this.lblScoreJoueur2 = new System.Windows.Forms.Label();
            this.lblJoueurEnCours = new System.Windows.Forms.Label();
            this.lblJoueurActuel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir Nom Joueur 1";
            // 
            // txtJoueur1
            // 
            this.txtJoueur1.Location = new System.Drawing.Point(389, 76);
            this.txtJoueur1.Name = "txtJoueur1";
            this.txtJoueur1.Size = new System.Drawing.Size(100, 20);
            this.txtJoueur1.TabIndex = 1;
            this.txtJoueur1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saisir Nom Joueur 2";
            // 
            // txtJoueur2
            // 
            this.txtJoueur2.Location = new System.Drawing.Point(787, 76);
            this.txtJoueur2.Name = "txtJoueur2";
            this.txtJoueur2.Size = new System.Drawing.Size(100, 20);
            this.txtJoueur2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // btnCommencer
            // 
            this.btnCommencer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCommencer.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommencer.Location = new System.Drawing.Point(511, 115);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(271, 42);
            this.btnCommencer.TabIndex = 5;
            this.btnCommencer.Text = "Commencer la partie";
            this.btnCommencer.UseVisualStyleBackColor = false;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // txtLettres
            // 
            this.txtLettres.BackColor = System.Drawing.SystemColors.Info;
            this.txtLettres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLettres.Location = new System.Drawing.Point(634, 314);
            this.txtLettres.Name = "txtLettres";
            this.txtLettres.ReadOnly = true;
            this.txtLettres.Size = new System.Drawing.Size(160, 26);
            this.txtLettres.TabIndex = 6;
            this.txtLettres.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lettres imposées";
            // 
            // txtMotPropose
            // 
            this.txtMotPropose.Location = new System.Drawing.Point(634, 381);
            this.txtMotPropose.Name = "txtMotPropose";
            this.txtMotPropose.Size = new System.Drawing.Size(124, 20);
            this.txtMotPropose.TabIndex = 8;
            this.txtMotPropose.TextChanged += new System.EventHandler(this.txtMotPropose_TextChanged);
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.Location = new System.Drawing.Point(115, 296);
            this.nomJoueur1.Name = "nomJoueur1";
            this.nomJoueur1.ReadOnly = true;
            this.nomJoueur1.Size = new System.Drawing.Size(100, 20);
            this.nomJoueur1.TabIndex = 9;
            this.nomJoueur1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // nomJoueur2
            // 
            this.nomJoueur2.Location = new System.Drawing.Point(1014, 311);
            this.nomJoueur2.Name = "nomJoueur2";
            this.nomJoueur2.ReadOnly = true;
            this.nomJoueur2.Size = new System.Drawing.Size(100, 20);
            this.nomJoueur2.TabIndex = 10;
            this.nomJoueur2.TextChanged += new System.EventHandler(this.nomJoueur2_TextChanged);
            // 
            // btnProposerMot
            // 
            this.btnProposerMot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProposerMot.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProposerMot.Location = new System.Drawing.Point(523, 442);
            this.btnProposerMot.Name = "btnProposerMot";
            this.btnProposerMot.Size = new System.Drawing.Size(207, 48);
            this.btnProposerMot.TabIndex = 11;
            this.btnProposerMot.Text = "Valider Mot";
            this.btnProposerMot.UseVisualStyleBackColor = false;
            this.btnProposerMot.Click += new System.EventHandler(this.btnProposerMot_Click);
            // 
            // lblScoreJoueur1
            // 
            this.lblScoreJoueur1.AutoSize = true;
            this.lblScoreJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreJoueur1.Location = new System.Drawing.Point(118, 356);
            this.lblScoreJoueur1.Name = "lblScoreJoueur1";
            this.lblScoreJoueur1.Size = new System.Drawing.Size(123, 20);
            this.lblScoreJoueur1.TabIndex = 12;
            this.lblScoreJoueur1.Text = "Score Joueur 1";
            this.lblScoreJoueur1.Click += new System.EventHandler(this.lblScoreJoueur1_Click);
            // 
            // lblScoreJoueur2
            // 
            this.lblScoreJoueur2.AutoSize = true;
            this.lblScoreJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreJoueur2.Location = new System.Drawing.Point(1010, 356);
            this.lblScoreJoueur2.Name = "lblScoreJoueur2";
            this.lblScoreJoueur2.Size = new System.Drawing.Size(123, 20);
            this.lblScoreJoueur2.TabIndex = 13;
            this.lblScoreJoueur2.Text = "Score Joueur 2";
            this.lblScoreJoueur2.Click += new System.EventHandler(this.lblScoreJoueur2_Click);
            // 
            // lblJoueurEnCours
            // 
            this.lblJoueurEnCours.AutoSize = true;
            this.lblJoueurEnCours.Location = new System.Drawing.Point(112, 361);
            this.lblJoueurEnCours.Name = "lblJoueurEnCours";
            this.lblJoueurEnCours.Size = new System.Drawing.Size(0, 13);
            this.lblJoueurEnCours.TabIndex = 14;
            // 
            // lblJoueurActuel
            // 
            this.lblJoueurActuel.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueurActuel.Location = new System.Drawing.Point(442, 376);
            this.lblJoueurActuel.Name = "lblJoueurActuel";
            this.lblJoueurActuel.Size = new System.Drawing.Size(143, 25);
            this.lblJoueurActuel.TabIndex = 17;
            this.lblJoueurActuel.Text = "tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(564, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "WinScrabble";
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinScrabble.Properties.Resources.pngtree_words_scrabble_on_wooden_blocks_with_text_written_on_them_picture_image_2679632;
            this.ClientSize = new System.Drawing.Size(1197, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJoueurActuel);
            this.Controls.Add(this.lblJoueurEnCours);
            this.Controls.Add(this.lblScoreJoueur2);
            this.Controls.Add(this.lblScoreJoueur1);
            this.Controls.Add(this.btnProposerMot);
            this.Controls.Add(this.nomJoueur2);
            this.Controls.Add(this.nomJoueur1);
            this.Controls.Add(this.txtMotPropose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLettres);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJoueur2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJoueur1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
            this.Load += new System.EventHandler(this.FrmScrabble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJoueur1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJoueur2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.TextBox txtLettres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotPropose;
        private System.Windows.Forms.TextBox nomJoueur1;
        private System.Windows.Forms.TextBox nomJoueur2;
        private System.Windows.Forms.Button btnProposerMot;
        private System.Windows.Forms.Label lblScoreJoueur1;
        private System.Windows.Forms.Label lblScoreJoueur2;
        private System.Windows.Forms.Label lblJoueurEnCours;
        private System.Windows.Forms.Label lblJoueurActuel;
        private System.Windows.Forms.Label label5;
    }
}

