using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final1.Models
{
    public abstract class Persona
    {
        private int dni;
        private string nom;

        public Persona(string d,string n) 
        {
            this.nom = n;
            if(Regex.Match(d,"^d/$").Success == false) 
            {
               throw new NoNumeroException();   
            }
            else
            {
                dni = Convert.ToInt32(d);
            }
        }

        public override string ToString()
        {
            return $"{dni} {nom}";
        }

    }
}
