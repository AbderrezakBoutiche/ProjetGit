using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGit
{
    public class Salarie : Personne
    {
        //-----------------------------------------------  Les Attributs  -------------------------------------------------
        #region Les Attributs
        public string Service { get; set; }
        public int Salaire { get; set; }
        #endregion


        //---------------------------------------------  Les Constructeurs  -----------------------------------------------
        #region Les Constructeurs
        public Salarie(string firstName, string lastName, string service, int salaire) : base(firstName,lastName)
        {
            this.Salaire = salaire;
            this.Service = service;
        }

        public Salarie(string firstName, string lastName,int age, string service, int salaire) : base(firstName, lastName, age)
        {
            this.Salaire = salaire;
            this.Service = service;
        }
        #endregion

        //-----------------------------------------------  Les Méthodes  -------------------------------------------------
        #region Les Méthodes
        public override string ToString()
        {
            return base.ToString() + $" sont service est {Service} et son salaire est de {Salaire}";
        }
        #endregion
    }
}
