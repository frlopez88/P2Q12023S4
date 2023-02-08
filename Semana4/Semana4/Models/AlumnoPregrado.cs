using System;
namespace Semana4.Models
{
    public class AlumnoPregrado : Alumno, IAlumno
    {
        public void horasDeVinculacion()
        {
            base.horasVinculacion = 10;
        }
    }
}

