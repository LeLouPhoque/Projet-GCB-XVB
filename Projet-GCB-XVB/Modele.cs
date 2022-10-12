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

        public static string validConnexion(string id, string mp)
        {
            string message = "";
            connexionValide = false;
                foreach (Visiteur leVisiteur in maConnexion.Visiteur)
                {
                    while (!connexionValide)
                    {
                        if (id == leVisiteur.identifiant)
                        {
                            if (mp == leVisiteur.password)
                            {
                                connexionValide = true;
                            }
                        }
                    }
                }
            return message;
        }

    }
}
