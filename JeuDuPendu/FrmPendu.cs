/**
 * Jeu du pendu
 * author : Emds
 * date : 02/07/2020
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class frmPendu : Form
    {

        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public frmPendu()
        {
            InitializeComponent();
        }

        // déclaration globale
        private int phase = 1, erreur = 0;
        private string mot;
        Button btn;

        /// <summary>
        /// Creation des boutons lettres
        /// </summary>
        private void CreerLettres()
        {
            for (int k = 0; k < 26; k++)
            {
                btn = new Button();
                grpTestLettres.Controls.Add(btn);
                // lignes
                if (k < 10)
                {
                    btn.Location = new Point(4 + 27 * k, 27);
                }
                else if (k < 20)
                {
                    btn.Location = new Point(4 + 27 * (k - 10), 57);
                }
                else
                {
                    btn.Location = new Point(4 + 27 * (k - 20), 87);
                }
                btn.Size = new Size(28, 28);
                btn.Text = ((char)('A' + k)).ToString();
                btn.Click += new EventHandler(btn_Click);
            }
        }

        /// <summary>
        /// Active les boutons des lettres
        /// </summary>
        private void ActiveBoutons()
        {
            // active les boutons
            for (int k = 0; k < grpTestLettres.Controls.Count; k++)
            {
                grpTestLettres.Controls[k].Enabled = true;
            }
            grpTestLettres.Controls[0].Focus();
        }

        /// <summary>
        /// gère le focus sur les lettres
        /// </summary>
        private void gestionFocus()
        {
            int k = 0;
            while (!grpTestLettres.Controls[k].Enabled)
            {
                k++;
            }
            grpTestLettres.Controls[k].Focus();
        }

        private void btn_Click(Object sender, EventArgs e)
        {
            Button btnLettre = (Button)sender;
            // désactivation du bouton
            btnLettre.Enabled = false;
            // repositionne le focus sur la première lettre activée
            gestionFocus();
            // récupération de la lettre choisie
            char lettre = Convert.ToChar(btnLettre.Text);
            // test si la lettre apparaît dans le mot
            for (int k = 0, indice = 0; k < mot.Length; k++)
            {
                // remplacement de "-" par la lettre choisie si elle est contenue dans le mot
                if (mot[k] == lettre)
                {
                    txtMot.Text = txtMot.Text.Remove(k, 1);
                    txtMot.Text = txtMot.Text.Insert(k, lettre.ToString());
                    // Partie Gagnée
                    if (txtMot.Text == mot)
                    {
                        lblResultat.Text = "Bravo!";
                        grpTestLettres.Enabled = false;
                        btnLettre.Enabled = true;
                        btnRejouer.Focus();
                    }
                    // Bonne lettre
                    else
                    {
                        lblResultat.Text = "Bonne lettre!";
                    }
                }
                else
                {
                    indice++;
                }
                // incrémentation du nombre d'erreur et changement de l'image si la lettre n'est pas contenue dans le mot
                if (indice == mot.Length)
                {
                    erreur++;
                    lblResultat.Text = "Mauvaise lettre!";
                    afficheImage(erreur);
                    // Partie Perdue
                    if (erreur == 10)
                    {
                        lblResultat.Text = "Perdu!";
                        grpTestLettres.Enabled = false;
                        btnRejouer.Focus();
                    }
                }
            }
        }

        private void initialisation()
        {
            // phase 1 - saisie du mot
            if (phase == 1)
            {
                lblResultat.Text = "C'est parti!";
                txtMot.Text = "";
                txtMot.Enabled = true;
                txtMot.Focus();
                grpTestLettres.Enabled = false;
                afficheImage(erreur);
            }
            // phase 2 - recherche du mot
            else
            {
                txtMot.Enabled = false;
                ActiveBoutons();
                grpTestLettres.Enabled = true;
                grpTestLettres.Controls[0].Focus();
            }
        }

        /// <summary>
        /// affiche l'image en fonction du nombre d'erreur
        /// </summary>
        private void afficheImage(int nb)
        {
            imgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu" + nb);
        }


        /// <summary>
        /// contrôle la saisie du mot et retourne correct si il est constitué uniquement de lettres
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        private bool motCorrect(string mot)
        {
            bool correct = true;
            for (int k = 0; k < mot.Length; k++)
            {
                if (mot[k] < 'A' || mot[k] > 'Z')
                {
                    correct = false;
                }
            }
            return correct;
        }

        /// <summary>
        /// gère la zone de texte mot à chercher, saisie d'un mot puis validation, remplacement des charactères du mot par des underscore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtMot.Text != "" && motCorrect(txtMot.Text))
                {
                    // création d'un char array qui contient le mot entré par l'utilisateur
                    mot = txtMot.Text;
                    // remplace chaque lettres contenues dans le mot par "_"
                    for (int k = 0; k < 26; k++)
                    {
                        char lettre = (char)('A' + k);
                        if (txtMot.Text.Contains(lettre.ToString()))
                        {
                            txtMot.Text = txtMot.Text.Replace(lettre, '-');
                        }
                    }
                    // lancement de la phase 2                  
                    phase = 2;
                    initialisation();
                }
                else
                {
                    MessageBox.Show("Le mot ne doit comporter que des lettres");
                    txtMot.Text = "";
                    txtMot.Focus();
                }
            }
        }

        /// <summary>
        /// Reset l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRejouer_Click(object sender, EventArgs e)
        {
            phase = 1;
            erreur = 0;
            initialisation();
        }

        /// <summary>
        /// Evénement chargement de la fenêtre
        /// création des boutons des lettres de l'alphabet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPendu_Load(object sender, EventArgs e)
        {
            CreerLettres();
            initialisation();
        }
    }
}

