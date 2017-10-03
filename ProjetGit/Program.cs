using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGit
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne obj1 = new Personne();
            Personne obj2 = new Personne(87);

            Console.WriteLine(obj1 + "\n");
            Console.WriteLine(obj2 + "\n");
            

            Console.ReadKey();

            

        }
    }
}
