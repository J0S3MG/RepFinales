using System;

namespace Final1.Models
{
    [Serializable]
    public class Curso
    {
        public Docente Docente { get; private set; }
        Alumno[] alumnos = new Alumno[20];
        int cont = 0;
        public Curso(string dni, string nom, string esp)
        {
            Docente = new Docente(dni, nom, esp);
        }

        public void AgregarAlumno(Alumno a)
        {
            if(cont < alumnos.Length)
            {
                alumnos[cont] = a;
                cont++;
            }
        }
        public string VerEsp()
        {
            return $"{Docente.VerEsp()}";
        }
        public override string ToString()
        {
            return $"{Docente.ToString()}";
        }
    }
}
