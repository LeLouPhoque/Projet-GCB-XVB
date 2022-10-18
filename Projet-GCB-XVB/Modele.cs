using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GCB_XVB
{
public static class Modele
    {
        private static GSB_XVBEntities maConnexion;

        private static int action;

        public static int Action { get => action; set=> action = value; }

        public static void init()
        {
            maConnexion = new GSB_XVBEntities();
        }

        public static List<Visiteur> Listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
    }
}
