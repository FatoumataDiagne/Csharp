using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORML3IAGE
{
    internal class Personne
    {
        public String nom { get; set; }
        public String prenom { get; set; }
        public String tel { get; set; }
        public String sexe { get; set; }
        public String competences { get; set; }
        public String classe { get; set; }

        public Personne()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
