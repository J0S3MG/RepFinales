using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final1.Models
{
    public class Alumno: Persona
    {
        private int legajo;

        public Alumno(string legajo,string nom,string dni) : base(dni, nom)
        {
            if (Regex.Match(legajo, "^d/$").Success == false)
            {
                throw new NoNumeroException();
            }
            else
            {
                this.legajo = Convert.ToInt32(legajo);
            }
        }
        public override string ToString()
        {
            return $"{legajo} {base.ToString()}";
        }
    }
}
