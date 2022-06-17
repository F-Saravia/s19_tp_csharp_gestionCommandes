using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public class EmployeManager
    {
        public static List<Employe> SelectAllEmploye()
        {
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Employe ;";
            List<Employe> listeEmployes = new List<Employe>();
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();
            /*
             while (lecteur.Read())
                {
                    Console.WriteLine(lecteur[0].ToString()); // Première colonne.
                    Console.WriteLine(lecteur[1].ToString()); // Seconde colonne.
                    Console.WriteLine(lecteur[2].ToString()); // Troisième colonne.
                    // ...
                }
            */

            while (lecteur.Read())
            {
                // Accéder avec le nom de la colonne.
                // Console.WriteLine(lecteur["id"].ToString());
                // Console.WriteLine(lecteur["login"].ToString());
                // Console.WriteLine(lecteur["mdp"].ToString());
                // Console.WriteLine(lecteur["type"].ToString());
                Employe unEmployer = new Employe(int.Parse(lecteur["id"].ToString()), lecteur["login"].ToString(), lecteur["mdp"].ToString(), lecteur["type"].ToString());
                listeEmployes.Add(unEmployer);
            }
            BddConnexion.FermerConnexion(connexion);
            return listeEmployes;
        }

        public static Employe getEmploye(string login)
        {
            Employe employe = null;
            try {
                //pour recuperer mon user avec le login en input
                //1- connexion a la db
                MySqlConnection connexion = BddConnexion.OuvrirConnexion();
                //2- la requête sql
                MySqlCommand commandeBDD = connexion.CreateCommand();
                commandeBDD.CommandText = "SELECT * FROM Employe WHERE login=@login;";
                commandeBDD.Parameters.AddWithValue("@login", login);
                //3- on execute la requete
                MySqlDataReader lecteur = commandeBDD.ExecuteReader();
                //on recupere le resultat de la requete
                employe = new Employe(int.Parse(lecteur["id"].ToString()), lecteur["login"].ToString(), lecteur["mdp"].ToString(), lecteur["type"].ToString());
                //4- on ferme la connexion à la db
                BddConnexion.FermerConnexion(connexion);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return employe;
        }
        public static bool updateType(string id, string valeur)
        {
            bool success;
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();

            commandeBDD.CommandText = "UPDATE Employe SET type = @valeur WHERE id = @id";
            commandeBDD.Parameters.AddWithValue("@valeur", valeur);
            commandeBDD.Parameters.AddWithValue("@id", int.Parse(id));
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
