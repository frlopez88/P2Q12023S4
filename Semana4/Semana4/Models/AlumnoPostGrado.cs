using System;
namespace Semana4.Models
{
    public class AlumnoPostGrado : Alumno, IAlumno
    {
        public void horasDeVinculacion()
        {
            base.horasVinculacion = 15;
        }
    }
}

