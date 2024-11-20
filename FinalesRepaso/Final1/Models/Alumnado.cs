using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final1.Models
{
    [Serializable]
    public class Alumnado
    {
        List<Curso> ListaCursos = new List<Curso>();
        public int CantCurso
        { 
            get
            {
                return ListaCursos.Count;
            }
        }
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
        public void AgregarAlumno(string dni,string nom,string legajo,int idx)
        {
            Alumno a = new Alumno(legajo, nom, dni);
            Curso c = this[idx];
            if (c != null) c.AgregarAlumno(a);
        }
        public string ValorMalo(string dni, string legajo)
        {
            string p = @"^\d{5}$";
            string patron = @"^\d{8}$";
            string vm = "";
            if (Regex.Match(legajo, p).Success == false)
            {
                vm = legajo;
            }
            else if (Regex.Match(dni, patron).Success == false)
            {
               vm = dni;
            }
            return vm;
        }
    }
}
