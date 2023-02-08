using Semana4.Models;

AlumnoTecnico v1 = new AlumnoTecnico() {

    nombre = "Cristiano",
    apellido = "Ronaldo",
    fechaNacimiento = new DateTime(1985, 2, 6),
    nivelEducativo = "Secundaria"

};

v1.matricularCarrera("Desarrollo Web");

Materia m1 = new Materia() {
    nombre = "Programacion 1",
    nota = 89.00
};

m1.calcularPasoClase();
m1.listaAsistencia.Add( new DateTime(2023, 01, 01) );
m1.listaAsistencia.Add(new DateTime(2023, 01, 02));
m1.listaAsistencia.Add(new DateTime(2023, 01, 03));
m1.listaAsistencia.Add(new DateTime(2023, 01, 04));

m1.listaTareas.Add("Tarea Semana 1");
m1.listaTareas.Add("Tarea Semana 2");
m1.listaTareas.Add("Tarea Semana 3");

v1.cursarClase(m1);

Console.WriteLine(v1.toString());