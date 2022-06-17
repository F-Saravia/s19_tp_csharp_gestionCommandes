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
    public partial class Connexion : Form
    {

        private string login = "";
        private string loginErrorMessage = "";
        private string password = "";
        private string passwordErrorMessage = "";
        private Employe loggedEmploye;

        public Connexion()
        {
            InitializeComponent();
            textBox_login.Text = "Saisir votre login";
            textBox_password.Text = "Saisir votre password";
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            //c'est une vérification inutile mais juste pour le fun de s'entrainer
            if (sender is TextBox)
            {
                this.login = (sender as TextBox).Text;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            //c'est une vérification inutile mais juste pour le fun de s'entrainer
            if (sender is TextBox)
            {
                this.password = (sender as TextBox).Text;
            }
        }

        private void button_seConnecter_Click(object sender, EventArgs e)
        {
            bool testLogin = validationLogin(this.login);
            bool testPassword = validationLogin(this.password);
            if(testLogin && testPassword)
            {
                Menu commandes = new Menu(this.loggedEmploye, this );
                commandes.Show();
                textBox_login.Text = "";
                label_loginError.Text = "";
                textBox_password.Text = "";
                label_passwordError.Text = "";

                this.Hide();
            }
            else
            {
                label_loginError.Text = this.loginErrorMessage;
                label_passwordError.Text = this.passwordErrorMessage;
            }
        }

        private bool validationLogin( string login)
        {
            if(login.Trim().Length == 0) {
                this.loginErrorMessage= "Login invalide trop court!";
                return false;
            }
            loggedEmploye = EmployeManager.getEmploye(login);
            if (loggedEmploye !=null)
            {
                return true;
            }
            else {
                this.loginErrorMessage = "utilisateur introuvable, merci de vérifier le login saisi";
                return false;
            }

        }
        private bool validationPassword(string password)
        {
            if (password.Trim().Length == 0)
            {
                this.passwordErrorMessage= "Mot de passe trop court!";
                return false;
            }
            if (loggedEmploye is Employe && loggedEmploye.Mdp==this.password)
            {
                return true;
            }
            else
            {
                this.passwordErrorMessage = "mot de passe incorrect, merci de vérifier le mot de passe saisi";
                return false;
            }
        }

        
    }
}
