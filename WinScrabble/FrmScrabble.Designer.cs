
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.nomJoueur1 = new System.Windows.Forms.TextBox();
            this.nomJoueur2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir Nom Joueur 1";
            // 
            // txtJoueur1
            // 
            this.txtJoueur1.Location = new System.Drawing.Point(264, 72);
            this.txtJoueur1.Name = "txtJoueur1";
            this.txtJoueur1.Size = new System.Drawing.Size(100, 20);
            this.txtJoueur1.TabIndex = 1;
            this.txtJoueur1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saisir Nom Joueur 1";
            // 
            // txtJoueur2
            // 
            this.txtJoueur2.Location = new System.Drawing.Point(590, 69);
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
            this.btnCommencer.Location = new System.Drawing.Point(319, 122);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(198, 23);
            this.btnCommencer.TabIndex = 5;
            this.btnCommencer.Text = "Commencer la partie";
            this.btnCommencer.UseVisualStyleBackColor = false;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lettres imposées";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.Location = new System.Drawing.Point(146, 194);
            this.nomJoueur1.Name = "nomJoueur1";
            this.nomJoueur1.ReadOnly = true;
            this.nomJoueur1.Size = new System.Drawing.Size(100, 20);
            this.nomJoueur1.TabIndex = 9;
            this.nomJoueur1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // nomJoueur2
            // 
            this.nomJoueur2.Location = new System.Drawing.Point(469, 194);
            this.nomJoueur2.Name = "nomJoueur2";
            this.nomJoueur2.ReadOnly = true;
            this.nomJoueur2.Size = new System.Drawing.Size(100, 20);
            this.nomJoueur2.TabIndex = 10;
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 628);
            this.Controls.Add(this.nomJoueur2);
            this.Controls.Add(this.nomJoueur1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJoueur2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJoueur1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox nomJoueur1;
        private System.Windows.Forms.TextBox nomJoueur2;
    }
}

