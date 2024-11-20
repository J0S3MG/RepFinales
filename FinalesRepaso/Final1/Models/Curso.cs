using System.Collections.Generic;
using System.Security.Principal;

namespace Final1.Models
{
    public class Curso
    {
        public Docente Docente {  get; private set; }
        List<Alumno> alumnos = new List<Alumno>();
        public Curso(string dni, string nom, string esp) 
        {
            Docente = new Docente(dni, nom, esp);
        }

        public void AgregarAlumno(Alumno a)
        {
            alumnos.Add(a);
        }
        public override string ToString()
        {
            return $"{Docente.ToString()}";
        }
    }
}
