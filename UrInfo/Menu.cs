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
        private Employe loggedEmploye = new Employe();
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
            this.loggedEmploye = loggedEmploye;

            //1- affichage des informations de l'employée en haut de la page
            label_loggedEmploye_Type.Text = loggedEmploye.Type;
            label_loggedEmploye_Name.Text = loggedEmploye.Name;
            centrerEmployeNameLabel(ref label_loggedEmploye_Name);

            //2- show les boutons "Liste des commandes" et "Chercher une commande"
            //3- hide bouton "Retour au menu"
            toggleMenuButtons(true);

            //4- ajout des options dans la combobox du panel pour la recherche d'une commande
            comboBox_ChercherPar.Items.AddRange(new String[] {
                "Numéro",
                "Utilisateur",
                "Date de Commande",
                "Date d'expédition",
            });

            //5- hide panel pour rechercher d'un commande ET 
            // ET hide dataGridView_listeCommandes
            flowLayoutPanel_Recherche.Hide();
            dataGridView_listeCommandes.Hide();
        }

        
        
        private void btn_seDeconnecter_Click(object sender, EventArgs e)
        {
            this.loggedEmploye = new Employe();
            retour.Show();
            this.Close();
        }

        private void btn_listeCommandes_Click(object sender, EventArgs e)
        {
            /*
             * 1-hide les boutons btn_listeCommandes et btn_rechercherCommande
             * 2-show ET placer btn_retourAuMenu
             * 3-show ET placer dataGridView_listeCommandes
             * 4-charger dateGridView_listeCommandes avec defaultListeCommandes( loggedEmploye.type)
             */

            //1-hide les boutons btn_listeCommandes et btn_rechercherCommande
            //2-show ET placer btn_retourAuMenu
            toggleMenuButtons(false);

            //3-show ET placer dataGridView_listeCommandes
            dataGridView_listeCommandes.Show();
            placerContainer(ref dataGridView_listeCommandes);

            //4-charger dateGridView_listeCommandes avec defaultListeCommandes( loggedEmploye.type)
            defaultListeCommandes(loggedEmploye.Type);
        }

        private void btn_chercherUneCommande_Click(object sender, EventArgs e)
        {
            /*
             * 1-hide les boutons "Liste de Commandes" et "Chercher une Commande"
             * 2-show ET placer le bouton "Retour au menu"
             * 3-show ET placer le layour contenant les outils pour une recherche
             */

            //1-hide les boutons btn_listeCommandes et btn_rechercherCommande
            //2-show ET placer btn_retourAuMenu
            toggleMenuButtons(false);
            //3-show ET placer flowLayoutPanel_Recherche suivi du dataGridViw qui restera caché jusqu'à l'obtention de résultat d'un recherche
            flowLayoutPanel_Recherche.Show();
            placerContainer(ref flowLayoutPanel_Recherche, ref dataGridView_listeCommandes);
        }

        private void btn_RetourAuMenu_Click(object sender, EventArgs e)
        {
            /*
             * 1-hide dataGridView_listeCommandes
             * 2-hide flowLayoutPanel_Recherche si besoin
             * 3-hide btn_retourAuMenu
             * 4-show les boutons btn_listeCommandes et btn_rechercherCommande
             */
            //1-clear ET hide dataGridView_listeCommandes
            dataGridView_listeCommandes.Hide();
            //2-hide flowLayoutPanel_Recherche si besoin
            if (flowLayoutPanel_Recherche.Visible)
            {
                flowLayoutPanel_Recherche.Hide();
            }
            //3-hide btn_retourAuMenu
            //4-show les boutons btn_listeCommandes et btn_rechercherCommande
            toggleMenuButtons(true);
        }

        private void btn_lancerRecherche_Click(object sender, EventArgs e)
        {
            /*
             * 1- capter le choix du champ de recherche de la combobox
             * 2- capter l'input de la TextBox et s'assurer de sa validité en accord avec le choix de la combobox
             * 3- faire appel à la méthode de CommandeManager correspondante
             * 4- afficher le résultat dans le dataGridView_listeCommandes
             */

            //1- capter le choix du champ de recherche de la combobox
            string choix = comboBox_ChercherPar.SelectedItem.ToString();
            //2- capter l'input de la TextBox 
            string input = textBox_inputRecherche.Text;
            //3- faire appel à la méthode de CommandeManager correspondante
            List<Commande> resultats = new List<Commande>();
            switch (choix)
            {
                case "Numéro":
                    if (int.TryParse(input, out int numero))
                    {
                        resultats = CommandeManager.SelectAllCommandes("numero", numero);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un numéro valide");
                    }
                    break;
                case "Utilisateur":
                    if (int.TryParse(input, out int idUtilisateur))
                    {
                        resultats = CommandeManager.SelectAllCommandes("idUtilisateur", idUtilisateur);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un id utilisateur valide");
                    }
                    break;
                case "Date de Commande":
                    if (DateTime.TryParse(input, out DateTime dateCommande))
                    {
                        resultats = CommandeManager.SelectAllCommandes("dateCommande", dateCommande);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer une date valide");
                    }
                    break;
                case "Date d'expédition":
                    if (DateTime.TryParse(input, out DateTime dateExpedition))
                    {
                        resultats = CommandeManager.SelectAllCommandes("dateExpedition", dateExpedition);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer une date valide");
                    }
                    break;
            }
            //4- afficher le résultat dans le dataGridView_listeCommandes
            dataGridView_listeCommandes.DataSource = resultats;
        }

        
        ////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////A PARTIR D'ICI CE SONT DES MÉTHODES UTILITAIRES////////////////////// 
        //////////////////////POUR QUE LE CODE DU HAUT SOIT PLUS FACILE A LIRE//////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////
        private void defaultPositioningANDSizing()
        {
            int fenetre_Width = this.Width;
            int fenetre_Height = this.Height;
            //employe labels & logout button

            //menu buttons

            //retour au menu button

            //research panel container

            //dataGridView
        }

        private void centrerEmployeNameLabel(ref Label label)
        {
            label.Location = new Point((this.Width - label.Width) / 2, 25);
        }

        private void toggleMenuButtons(bool showOrHide)
        {
            if (showOrHide)
            {
                btn_listeCommandes.Show();
                btn_chercherUneCommande.Show();
                btn_RetourAuMenu.Hide();
                centrerMenuButtons(ref btn_listeCommandes, ref btn_chercherUneCommande);
            }
            else
            {
                btn_listeCommandes.Hide();
                btn_chercherUneCommande.Hide();
                btn_RetourAuMenu.Show();
                centrerBtnRetourMenu(ref btn_RetourAuMenu);
            }
        }

        //je passe par référence les éléments plutôt que d'y acceder directement comme ça je peux pratiquer le passage par ref
        private void centrerBtnRetourMenu(ref Button button1)
        {
            //coordonnées XY du coin supérieur gauche
            int position_X = (this.Width - button1.Width) / 2;
            int position_Y = 25 + label_loggedEmploye_Name.Height + 2;

            //placement du button
            button1.Location = new Point(position_X, position_Y);
        }

        //je passe par référence les éléments plutôt que d'y acceder directement comme ça je peux pratiquer le passage par ref
        private void centrerMenuButtons(ref Button button1, ref Button button2)
        {
            //coordonnées XY de mes boutons
            int positionBtn1_X = (this.Width - button1.Width) / 2;
            int positionBtn1_Y = 25 + label_loggedEmploye_Name.Height + 2;
            int positionBtn2_X = (this.Width - button2.Width) / 2;
            int positionBtn2_Y = 25 + button1.Location.Y + button1.Height + 2;

            //placement de mes boutons
            button1.Location = new Point(positionBtn1_X, positionBtn1_Y);
            button2.Location = new Point(positionBtn2_X, positionBtn2_Y);
        }

        //je passe par référence les éléments plutôt que d'y acceder directement comme ça je peux pratiquer le passage par ref
        private void placerContainer(ref DataGridView containerListeCommandes)
        {

            //coordonnées XY du coin supérieur gauche de l'élement.
            int position_X = (this.Width - containerListeCommandes.Width) / 2;
            int position_Y = 25 + label_loggedEmploye_Name.Height + 2 + btn_RetourAuMenu.Height + 2;

            //taille du DataGridView
            containerListeCommandes.Size = new Size(
                this.Width - 50,
                this.Height - position_Y
            );
            //placement du DataGridView
            containerListeCommandes.Location = new Point(position_X, position_Y);
        }

        //je passe par référence les éléments plutôt que d'y acceder directement comme ça je peux pratiquer le passage par ref
        private void placerContainer(ref FlowLayoutPanel containerPanelRecherche, ref DataGridView containerListeCommandes)
        {
            //coordonnées XY du coin supérieur gauche de l'élement.
            int panelRecherche_X = (this.Width - containerPanelRecherche.Width) / 2;
            int panelRecherche_Y = 25 + label_loggedEmploye_Name.Height + 2 + btn_RetourAuMenu.Height + 2;
            int gridListeCommandes_X = (this.Width - containerListeCommandes.Width) / 2;
            int gridListeCommandes_Y = panelRecherche_Y + containerPanelRecherche.Height + 2;

            //taille des élements
            containerPanelRecherche.Size = new Size(this.Width - 50, 35);
            containerListeCommandes.Size = new Size(
                this.Width - 50,
                this.Height - gridListeCommandes_Y - 25
            );

            //placement des éléments
            containerPanelRecherche.Location = new Point(panelRecherche_X, panelRecherche_Y);
            containerListeCommandes.Location = new Point(gridListeCommandes_X, gridListeCommandes_Y);
        }

        private void defaultListeCommandes(string role)
        {
            switch (role)
            {
                case "comptable":
                    List<Commande> commandesComptable = CommandeManager.SelectAllCommandes("etat", 1);
                    dataGridView_listeCommandes.DataSource = commandesComptable;
                    break;

                case "preparateurs":
                    List<Commande> commandesPreparateur = CommandeManager.SelectAllCommandes("etat", 2);
                    dataGridView_listeCommandes.DataSource = commandesPreparateur;
                    break;

                default:
                    break;
            }
        }

        
    }
}
