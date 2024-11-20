using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1.Models
{
    public class Alumnado
    {
        List<Curso> ListaCursos = new List<Curso>();
        public Curso this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < ListaCursos.Count)
                {
                    return ListaCursos[idx];
                }
                return null;
            }
        }
        public Curso CrearCurso(string dni,string nom, string esp)
        {
            Curso curso = new Curso(dni, nom, esp);
            ListaCursos.Add(curso); 
            return curso;
        }
        public void AgregarAlumno(string dni,string nom,string legajo)
        {
            Alumno a = new Alumno(legajo, nom, dni);

        }
    }
}
