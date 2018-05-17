namespace MiniProjet2018
{
    partial class frmPrincipal
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
            this.grpGroupeActuel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonne = new System.Windows.Forms.Label();
            this.cboIdentifiant = new System.Windows.Forms.ComboBox();
            this.lblCours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExoTermines = new System.Windows.Forms.Label();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.grpGroupeActuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGroupeActuel
            // 
            this.grpGroupeActuel.BackColor = System.Drawing.Color.Transparent;
            this.grpGroupeActuel.Controls.Add(this.btnCommencer);
            this.grpGroupeActuel.Controls.Add(this.lblExoTermines);
            this.grpGroupeActuel.Controls.Add(this.label3);
            this.grpGroupeActuel.Controls.Add(this.label2);
            this.grpGroupeActuel.Controls.Add(this.lblCours);
            this.grpGroupeActuel.Controls.Add(this.label1);
            this.grpGroupeActuel.Controls.Add(this.lblPersonne);
            this.grpGroupeActuel.Controls.Add(this.cboIdentifiant);
            this.grpGroupeActuel.Location = new System.Drawing.Point(308, 242);
            this.grpGroupeActuel.Name = "grpGroupeActuel";
            this.grpGroupeActuel.Size = new System.Drawing.Size(665, 398);
            this.grpGroupeActuel.TabIndex = 0;
            this.grpGroupeActuel.TabStop = false;
            this.grpGroupeActuel.Text = "Cours actuel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Votre cours actuel :";
            // 
            // lblPersonne
            // 
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Location = new System.Drawing.Point(73, 66);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Size = new System.Drawing.Size(107, 17);
            this.lblPersonne.TabIndex = 1;
            this.lblPersonne.Text = "Qui êtes vous ?";
            // 
            // cboIdentifiant
            // 
            this.cboIdentifiant.FormattingEnabled = true;
            this.cboIdentifiant.Location = new System.Drawing.Point(210, 63);
            this.cboIdentifiant.Name = "cboIdentifiant";
            this.cboIdentifiant.Size = new System.Drawing.Size(232, 24);
            this.cboIdentifiant.TabIndex = 0;
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Location = new System.Drawing.Point(207, 142);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(154, 17);
            this.lblCours.TabIndex = 3;
            this.lblCours.Text = "texte avec le bon cours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leçon actuelle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exercices terminés :";
            // 
            // lblExoTermines
            // 
            this.lblExoTermines.AutoSize = true;
            this.lblExoTermines.Location = new System.Drawing.Point(210, 254);
            this.lblExoTermines.Name = "lblExoTermines";
            this.lblExoTermines.Size = new System.Drawing.Size(36, 17);
            this.lblExoTermines.TabIndex = 6;
            this.lblExoTermines.Text = "0/11";
            // 
            // btnCommencer
            // 
            this.btnCommencer.Location = new System.Drawing.Point(464, 337);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(131, 30);
            this.btnCommencer.TabIndex = 7;
            this.btnCommencer.Text = "Commencer";
            this.btnCommencer.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.grpGroupeActuel);
            this.Name = "frmPrincipal";
            this.Text = "La casa de babbel";
            this.grpGroupeActuel.ResumeLayout(false);
            this.grpGroupeActuel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGroupeActuel;
        private System.Windows.Forms.ComboBox cboIdentifiant;
        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExoTermines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Button btnCommencer;
    }
}

