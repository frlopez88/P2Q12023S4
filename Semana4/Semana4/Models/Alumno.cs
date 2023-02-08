using System;
namespace Semana4.Models
{
    public class Alumno: Persona
    {

        public string nivelEducativo { get; set; }
        public double promedioGeneral { get; set; }
        public double promedioDeGraduacion { get; set; }
        public List<Materia> clasesPasadas { get; set; } = new List<Materia>();
        public List<Materia> clasesReprobadas { get; set; } = new List<Materia>();
        public List<Materia> clasesCanceladas { get; set; } = new List<Materia>();
        public string Carrera { get; set; }
        public List<string> listadoTareas { get; set; } = new List<string>();
        public int horasVinculacion { get; set; }


        public void calcularPromedioGeneral()
        {

            double notasAcum = 0;

            foreach (Materia x in clasesPasadas) {

                notasAcum += x.nota;
            }

            promedioGeneral = notasAcum / clasesPasadas.Count;

        }

        public void calcularPromedioGraduacion()
        {

            double notasAcum = 0;

            foreach (Materia x in clasesPasadas)
            {

                notasAcum += x.nota;
            }

            foreach (Materia x in clasesReprobadas)
            {

                notasAcum += x.nota;
            }

            promedioDeGraduacion = notasAcum / (clasesPasadas.Count  + clasesReprobadas.Count );

        }

        public void cancelarClase(Materia clase)
        {


            clasesCanceladas.Add(clase);

        }

        public void cursarClase(Materia clase)
        {


            clase.calcularPasoClase();

            if (clase.pasoLaClase == true)
            {

                clasesPasadas.Add(clase);

            }
            else {

                clasesReprobadas.Add(clase);
            }


        }

        public void matricularCarrera(string carrera)
        {
            this.Carrera = carrera;
        }

        public override string toString()
        {

            calcularPromedioGeneral();
            calcularPromedioGraduacion();

            return $"{base.toString()} - Promedio General {promedioGeneral} -  Promedio Graduacion {promedioDeGraduacion}";
        }

    }
}

