namespace JeuDuPendu
{
    partial class frmPendu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpTestLettres = new System.Windows.Forms.GroupBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMot);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(423, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mot à chercher";
            // 
            // txtMot
            // 
            this.txtMot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMot.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(9, 29);
            this.txtMot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMot.MaxLength = 15;
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(372, 54);
            this.txtMot.TabIndex = 0;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(18, 354);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 47);
            this.lblResultat.TabIndex = 4;
            // 
            // grpTestLettres
            // 
            this.grpTestLettres.Location = new System.Drawing.Point(18, 128);
            this.grpTestLettres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTestLettres.Name = "grpTestLettres";
            this.grpTestLettres.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTestLettres.Size = new System.Drawing.Size(423, 194);
            this.grpTestLettres.TabIndex = 3;
            this.grpTestLettres.TabStop = false;
            this.grpTestLettres.Text = "lettres testées";
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(372, 332);
            this.btnRejouer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(69, 71);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // imgPendu
            // 
            this.imgPendu.Location = new System.Drawing.Point(456, 18);
            this.imgPendu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(375, 385);
            this.imgPendu.TabIndex = 1;
            this.imgPendu.TabStop = false;
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 417);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grpTestLettres);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.imgPendu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPendu";
            this.Text = "Jeu du Pendu";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox grpTestLettres;
    }
}

