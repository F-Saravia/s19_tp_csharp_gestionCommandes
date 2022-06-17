using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public static class BddConnexion
    {
        private static string server = "localhost";
        private static string port = "3306";
        private static string database = "urinfostock";
        private static string UserId = "root";
        private static string password = "";


        /// <summary>
        /// private static string infosConnex = "server=localhost;port=3306;database=bdd_urinfo;User Id=urInfoApplication;password=remi";
        /// </summary>
        /// <returns></returns>

        public static MySqlConnection OuvrirConnexion()
        {
            string infosConnex = $"server={server};port={port};database{database};User Id={UserId};password={password};";
            MySqlConnection connexion;
            connexion = new MySqlConnection(infosConnex);
            try
            {
                connexion.Open();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                //A voir ce que l’on fait en cas d'exception ...
            }
            return connexion;
        }
        public static void FermerConnexion(MySqlConnection connexion)
        {
            try
            {
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //A voir ce que l’on fait en cas d'exception ...
            }

        }
    }
}
