using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1.Models
{
    public class Docente: Persona
    {
        private string areaEspecialidad;

        public Docente(string ae, string dni,string nom): base(dni, nom)
        {
            areaEspecialidad = ae;
        }
        public override string ToString()
        {
            return $"{areaEspecialidad} {base.ToString()}";
        }
    }
}
