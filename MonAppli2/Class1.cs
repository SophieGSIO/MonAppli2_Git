using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAppli2
{
    public class Class1
    {
        // attributs privés
        private int id;
        private string nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="unNom"></param>
        public Class1(int unId, string unNom)
        {
            this.id = unId;
            this.nom = unNom;
        }
    }
}
