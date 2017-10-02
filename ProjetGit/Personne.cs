using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGit
{
    public class Personne
    {


        //-----------------------------------------------------  Les Attributs  ----------------------------------------------
        #region Les Attributs
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        #endregion

        //---------------------------------------------------  Les Constructeurs  --------------------------------------------

        #region Les Constructeurs
        public Personne(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        #endregion

        //-----------------------------------------------------  Les Méthodes  ----------------------------------------------
        #region Les Méthodes
        public override string ToString()
        {
            return  $"Cette personne s'apelle {FirstName}  {LastName} et est agée de {Age} ans";
        }
        #endregion
    }
}
