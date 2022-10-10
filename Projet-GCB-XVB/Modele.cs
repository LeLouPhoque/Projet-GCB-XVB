using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GCB_XVB
{
    public static class Modele
    {
        private static connectXVB maConnexion;

        public static void init()
        {
            maConnexion = new connectXVB();
        }
    }
}
