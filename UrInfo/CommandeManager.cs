using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    internal class CommandeManager
    { 

        public static List<Commande> SelectAllCommande()
        {
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Commande ;";
            List<Commande> listeCommandes = new List<Commande>();
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();
            
            while (lecteur.Read())
            {
                Commande unCommander = new Commande(
                    int.Parse(lecteur["utilisateur"].ToString()),
                    int.Parse(lecteur["idUtilisateur"].ToString()),
                    short.Parse(lecteur["etat"].ToString()),
                    DateTime.Parse(lecteur["dateCommande"].ToString()),
                    DateTime.Parse(lecteur["dateExpedition"].ToString()),
                    lecteur["commentaire"].ToString()
                    ) ;
                listeCommandes.Add(unCommander);
            }
            BddConnexion.FermerConnexion(connexion);
            return listeCommandes;
        }

        
        public static Commande getCommandeByNumero(int numero)
        {
            Commande commande = null;
            try {
                //on ouvre une connexion grace à la classe static () 
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                MySqlCommand commandeBDD = connexion.CreateCommand();
                // On ecris la requête
                commandeBDD.CommandText = "SELECT * FROM Commande WHERE numero=@numero;";
                commandeBDD.Parameters.AddWithValue("@numero", numero);
                MySqlDataReader lecteur = commandeBDD.ExecuteReader();
                commande = new Commande(
                        int.Parse(lecteur["numero"].ToString()),
                        int.Parse(lecteur["idUtilisateur"].ToString()),
                        short.Parse(lecteur["etat"].ToString()),
                        DateTime.Parse(lecteur["dateCommande"].ToString()),
                        DateTime.Parse(lecteur["dateExpedition"].ToString()),
                        lecteur["commentaire"].ToString()
                        );


                BddConnexion.FermerConnexion(connexion);
            }
            catch(Exception e) { Console.WriteLine(e.Message); }
            
            return commande;
        }

        public static List<Commande> getCommandeByUtilisateur(int utilisateur)
        {
            List<Commande> listeCommandes = new List<Commande>();
            try
            {
                //on ouvre une connexion grace à la classe static () 
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                MySqlCommand commandeBDD = connexion.CreateCommand();
                // On ecris la requête
                commandeBDD.CommandText = "SELECT * FROM Commande WHERE idUtilisateur=@utilisateur;";
                commandeBDD.Parameters.AddWithValue("@utilisateur", utilisateur);

                MySqlDataReader lecteur = commandeBDD.ExecuteReader();

                while (lecteur.Read())
                {
                    listeCommandes.Add(new Commande(
                        int.Parse(lecteur["numero"].ToString()),
                        int.Parse(lecteur["idUtilisateur"].ToString()),
                        short.Parse(lecteur["etat"].ToString()),
                        DateTime.Parse(lecteur["dateCommande"].ToString()),
                        DateTime.Parse(lecteur["dateExpedition"].ToString()),
                        lecteur["commentaire"].ToString()
                        )
                    );
                }
                BddConnexion.FermerConnexion(connexion);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listeCommandes;
        }

        public static List<Commande> getCommandeByDateCommande(DateTime dateCommande)
        {
            List<Commande> listeCommandes = new List<Commande>();
            try
            {
                //on ouvre une connexion grace à la classe static () 
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                MySqlCommand commandeBDD = connexion.CreateCommand();
                // On ecris la requête
                commandeBDD.CommandText = "SELECT * FROM Commande WHERE dateCommande=@dateCommande;";
                commandeBDD.Parameters.AddWithValue("@dateCommande", dateCommande);

                MySqlDataReader lecteur = commandeBDD.ExecuteReader();

                while (lecteur.Read())
                {
                    listeCommandes.Add(new Commande(
                        int.Parse(lecteur["numero"].ToString()),
                        int.Parse(lecteur["idUtilisateur"].ToString()),
                        short.Parse(lecteur["etat"].ToString()),
                        DateTime.Parse(lecteur["dateCommande"].ToString()),
                        DateTime.Parse(lecteur["dateExpedition"].ToString()),
                        lecteur["commentaire"].ToString()
                        )
                    );
                }
                BddConnexion.FermerConnexion(connexion);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listeCommandes;
        }

        public static List<Commande> getCommandeByDateExpedition(DateTime dateExpedition)
        {
            List<Commande> listeCommandes = new List<Commande>();
            try
            {
                //on ouvre une connexion grace à la classe static () 
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                MySqlCommand commandeBDD = connexion.CreateCommand();
                // On ecris la requête
                commandeBDD.CommandText = "SELECT * FROM Commande WHERE dateExpedition=@dateExpedition;";
                commandeBDD.Parameters.AddWithValue("@dateExpedition", dateExpedition);

                MySqlDataReader lecteur = commandeBDD.ExecuteReader();

                while (lecteur.Read())
                {
                    listeCommandes.Add(new Commande(
                        int.Parse(lecteur["numero"].ToString()),
                        int.Parse(lecteur["idUtilisateur"].ToString()),
                        short.Parse(lecteur["etat"].ToString()),
                        DateTime.Parse(lecteur["dateCommande"].ToString()),
                        DateTime.Parse(lecteur["dateExpedition"].ToString()),
                        lecteur["commentaire"].ToString()
                        )
                    );
                }
                BddConnexion.FermerConnexion(connexion);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listeCommandes;
        }

        public static bool updateExpedition(int numero, DateTime dateExpedition)
        {
            bool success;
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();

            commandeBDD.CommandText = "UPDATE Commande SET dateExpedition = @dateExpedition WHERE numero = @numero";
            commandeBDD.Parameters.AddWithValue("@dateExpedition", dateExpedition);
            commandeBDD.Parameters.AddWithValue("@numero", numero);
            commandeBDD.ExecuteNonQuery();
            if (commandeBDD.ExecuteNonQuery() == 1)
            {
                // reusite
                success = true;
            }
            else
            {
                // echec
                success = false;
            }
            BddConnexion.FermerConnexion(connexion);
            return success;
        }
    }
}
