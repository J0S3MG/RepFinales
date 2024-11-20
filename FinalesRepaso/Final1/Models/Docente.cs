using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1.Models
{
    [Serializable]
    public class Docente: Persona
    {
        private string areaEspecialidad;

        public Docente(string dni, string nom,string ae): base(dni, nom)
        {
            areaEspecialidad = ae;
        }
        public string VerEsp()
        {
            return areaEspecialidad;
        }
        public override string ToString()
        {
            return $"{areaEspecialidad} {base.ToString()}";
        }
    }
}
