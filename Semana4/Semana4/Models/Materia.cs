using System;
namespace Semana4.Models
{
	public class Materia
	{
		public string nombre { get; set; }
		public double nota { get; set; }
		public bool pasoLaClase { get; set; }
		public List<string> listaTareas { get; set; } = new List<string>();
        public List<DateTime> listaAsistencia { get; set; } = new List<DateTime>();

        public void calcularPasoClase() {

			if (nota >= 60)
			{

				pasoLaClase = true;
			}
			else {
				pasoLaClase = false;
			}

		}
	}
}

