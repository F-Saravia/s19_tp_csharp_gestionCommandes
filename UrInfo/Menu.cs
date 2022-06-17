using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrInfo
{
    public partial class Menu : Form
    {
        private string type = "";
        private Employe loggedEmploye;
        private Connexion retour;

        /// <summary>
        /// Important!!! le deuxième paramètre caller c'est le WinForm "Connexion" qui a appelé ce WinForm "Menu",
        /// comme ça je peux simmuler une navigation en faisant caller.Show() tout en faisant this.Close() lors de la déconnexion
        /// du moins je l'espère que cela marchera xD
        /// 
        /// </summary>
        /// <param name="loggedEmploye"></param>
        /// <param name="caller"></param>
        public Menu(Employe loggedEmploye, Connexion caller)
        {
            InitializeComponent();
            this.retour = caller;
            this.type = loggedEmploye.Type;
            this.loggedEmploye = loggedEmploye;

            //affichage des informations de l'employée en haut de la page
            label_loggedEmploye_Type.Text = loggedEmploye.Type;
            label_loggedEmploye_Name.Text = loggedEmploye.Name;
            centrerEmployeNameLabel(ref label_loggedEmploye_Name);
            
            
            //ajout des options dans la combobox pour la recherche
            comboBox_ChercherPar.Items.AddRange(new String[] {
                "Numéro",
                "Utilisateur",
                "Date de Commande",
                "Date d'expédition",
            });
            
            
        }
        private void btn_seDeconnecter_Click(object sender, EventArgs e)
        {
            this.loggedEmploye = null;
            retour.Show();
            this.Close();
        }

        private void btn_listeCommandes_Click(object sender, EventArgs e)
        {
            //1-hide les boutons btn_listeCommandes et btn_rechercherCommande
            //2-show btn_retourAuMenu
            //3-replacer btn_retourAuMenu
            //4-show dataGridView_listeCommandes
            //5-replacer dataGridView_listeCommandes à la place des boutons
            //6-charger dateGridView_listeCommandes avec CommandesManager.SelectAllCommande()
        }

        private void btn_rechercherCommande_Click(object sender, EventArgs e)
        {
            //1-hide les boutons btn_listeCommandes et btn_rechercherCommande
            //2-show btn_retourAuMenu
            //3-replacer btn_retourAuMenu
            //4-show 
            //5-replacer dataGridView_listeCommandes à la place des boutons
            //6-charger dateGridView_listeCommandes avec CommandesManager.SelectAllCommande()

        }

        private void btn_lancerRecherche_Click(object sender, EventArgs e)
        {
            string input = textBox_inputRecherche.Text.ToString().Trim();

            if (input != "")
            {

            }
        }

        private void centrerEmployeNameLabel (ref Label label)
        {
            label.Location = new Point( (this.Width - label.Width) / 2 , 25);
        }
        private void toggleMenuButtons(bool showOrHide)
        {
            if (showOrHide)
            {
                btn_listeCommandes.Show();
                btn_rechercherCommande.Show();
                btn_RetourAuMenu.Hide();
            }
            else
            {
                btn_listeCommandes.Hide();
                btn_rechercherCommande.Hide();
                btn_RetourAuMenu.Show();
            }
        }
        private void centrerMenuButtons (ref Button button)
        {
            button.Location = new Point(
                (this.Width - button.Width) / 2,
                25 + label_loggedEmploye_Name.Height + 2
            );
        }
        private void centrerMenuButtons(ref Button button1, ref Button button2)
        {
            button1.Location = new Point(
                (this.Width - button1.Width) / 2,
                25 + label_loggedEmploye_Name.Height + 2
            );
            button2.Location = new Point(
                (this.Width - button2.Width) / 2,
                25 + button1.Location.Y + 2
            );
        }
    }
}
