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

        public static Commande getCommandeByNumero(int numero)
        {
            Commande commande = null;
            try
            {
                //on ouvre une connexion grace à la classe static () 
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                MySqlCommand commandeBDD = connexion.CreateCommand();
                // On ecris la requête
                
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
            catch (Exception e) { Console.WriteLine(e.Message); }

            return commande;
        }
        public static List<Commande> SelectAllCommandes()
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

        public static List<Commande> SelectAllCommandes(string nomColonne, Object value)
        {
            List<Commande> listeCommandes = new List<Commande>();
            try
            {
                //test qui throw une Exception avec un message pertinant.-->méthode déclaré tout en bas
                CommandeManager.test_NomColonne_Match_ValueType (nomColonne, value);
                //on ouvre une connexion grace à la classe static () 
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                MySqlCommand commandeBDD = connexion.CreateCommand();

                // On ecris la requête en fonction de la colonne
                commandeBDD.CommandText = $"SELECT * FROM Commande WHERE {nomColonne}=@value;";
                commandeBDD.Parameters.AddWithValue("@value", value);
                
                //on execute la commande 
                MySqlDataReader lecteur = commandeBDD.ExecuteReader();
                
                //on recupere les commandes et on les injècte dans la liste à retourner
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
            catch (Exception e){
                Console.WriteLine(e);
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

        private static void test_NomColonne_Match_ValueType (string nomColonne, Object value) {
            switch (nomColonne){
                case "numero":
                    if (!(value is int))
                        throw new Exception($"Erreur, la colonne {nomColonne} est de type int");
                    break;
                case "idUtilisateur":
                    if (!(value is int))
                        throw new Exception($"Erreur, la colonne {nomColonne} est de type int");
                    break;
                case "etat":
                    if (!(value is short))
                        throw new Exception($"Erreur, la colonne {nomColonne} est de type short");
                    break;
                case "dateCommande":
                    if (!(value is DateTime))
                        throw new Exception($"Erreur, la colonne {nomColonne} est de type DateTime");
                    break;
                case "dateExpedition":
                    if (!(value is DateTime))
                        throw new Exception($"Erreur, la colonne {nomColonne} est de type DateTime");
                    break;
                case "commentaire":
                    if (!(value is string))
                        throw new Exception($"Erreur, la colonne {nomColonne} est de type string");
                    break;
                default:
                    throw new Exception("Erreur, nom de la colonne invalide: la colonne n'existe pas");
                    break;
            }      
        }
    }
}
