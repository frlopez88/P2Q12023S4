using System;
namespace Semana4.Models
{
    public class AlumnoTecnico : Alumno, IAlumno
    {
        public void horasDeVinculacion()
        {

            base.calcularPromedioGraduacion();
            if (base.promedioDeGraduacion < 80)
            {
                base.horasVinculacion = 20;
            }
            else
            {
                base.horasVinculacion = 7;
            }
        

        }
    }
}

