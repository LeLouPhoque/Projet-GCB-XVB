using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projet_GCB_XVB
{
    public static class Modele
    {
        private static Visiteur visiteurConnecte;
        public static bool connexionValide;

        private static connectXVB maConnexion;

        public static void init()
        {
            maConnexion = new connectXVB();
        }

         public static List<Visiteur> Listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        
        public static string validConnexion(string id, string mp)
        {
            string message = "";
            connexionValide = false;
                foreach (Visiteur leVisiteur in maConnexion.Visiteur)
                {
                    if (!connexionValide)
                    {
                        if (id == leVisiteur.identifiant)
                        {
                            if (mp == leVisiteur.password)
                            {
                                connexionValide = true;
                            }
                        }
                    message = "Identifiant ou mot de passe incorect";
                    }
                }
            return message;
        }
    }
}
