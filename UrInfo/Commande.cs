using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public enum Etat
    {
        ATTENTE_PAIMENT = 1,//"En attente de paiement"
        PAIMENT_VALIDE = 2, //"Paiement validé"
        PREPARATION = 3,    //"En cours de préparation"
        EXPEDIEE = 4,       //"Commande Expédiée"
        NON_RENSEIGNE = 5
    }
    public class Commande
    {

        private int numero;
        private int idUtilisateur;
        private Etat etat;
        private DateTime dateCommande ;
        private DateTime dateExpedition ;
        private string commentaire;

        public Commande(int numero, int idUtilisateur, short etat, DateTime dateCommande, DateTime dateExpedition, string commentaire)
        {
            this.numero = numero;
            this.idUtilisateur = idUtilisateur;
            this.dateCommande = dateCommande;
            this.dateExpedition=dateExpedition;
            this.commentaire = commentaire;
            switch (etat)
            {
                case 1:
                    this.etat = Etat.ATTENTE_PAIMENT;
                    break;
                case 2:
                    this.etat = Etat.PAIMENT_VALIDE;
                    break;
                case 3:
                    this.etat = Etat.PREPARATION;
                    break;
                case 4:
                    this.etat = Etat.EXPEDIEE;
                    break;
                default:
                    this.etat = Etat.NON_RENSEIGNE;
                    break;
            }
        }

        public int Numero { get => numero; set => numero = value; }
        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
        public Etat Etat { get => etat; set => etat = value; }  
        public DateTime DateCommande { get => dateCommande; set => dateCommande = value; }
        public DateTime DateExpedition { get => dateExpedition; set => dateExpedition = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
    }
}
