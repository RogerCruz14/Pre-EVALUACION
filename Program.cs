using Pre_Evaluación.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Evaluación
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona();
            Empleados empleados = new Empleados();
            Estudiante estudiante = new Estudiante();
            Profesores profesores = new Profesores();
            ProfesoresPorContrato profesoresPorContrato = new ProfesoresPorContrato();

            //Persona
            Console.WriteLine("Ingrese su Nombre:");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido:");
            persona.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su Número Telefonico:");
            persona.Numero = Console.ReadLine();
            Console.WriteLine("Ingrese su Identificasión:");
            persona.Identificasion = Console.ReadLine();
            Console.WriteLine("Ingrese su Estado Civil:");
            persona.Estadocivil = Console.ReadLine();

            //Empleado
            Console.WriteLine("Ingrese el Año de Incorporación:");
            empleados.Añodeincorporacion = Console.ReadLine();
            Console.WriteLine("Ingrese su Facultad:");
            empleados.Facultad = Console.ReadLine();
            Console.WriteLine("Ingrese el Número de Despacho:");
            empleados.Numerodespacho = Console.ReadLine();

            //Estudiante
            Console.WriteLine("Ingrese el curso en el que esta matriculado:");
            estudiante.Cursomatriculado = Console.ReadLine();

            //Profesores
            Console.WriteLine("Ingrese su departamento:");
            profesores.Departamento = Console.ReadLine();

            //
            Console.WriteLine("Seleccione 1 para cambiar el estado civil de la persona");
            Console.WriteLine("Seleccione 2 para cambiar el despacho de un empleado");
            Console.WriteLine("Seleccione 3 matricular a un estudiante en un nuevo curso");
            Console.WriteLine("Seleccione 4 cambio de departamento a un profesor");
            Console.WriteLine("Seleccione 5 traslado de un empleado a un personal de servicio");
            Console.WriteLine("Seleccione 6 imprimir toda la informacion");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("Escriba el nuevo estado de la persona");
                    persona.Estadocivil = Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("escriba el nuevo despacho del empleado");
                    empleados.Añodeincorporacion = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("matricule al nuevo estudiante");
                    estudiante.Cursomatriculado = Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("cambie al profesor");
                    profesores.Departamento = Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("traslade al empleado ");
                    profesoresPorContrato.Datospersonales = Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("imprimir toda la informacion");
                    Console.WriteLine(persona.Nombre);
                    Console.WriteLine(persona.Identificasion);
                    Console.WriteLine(persona.Estadocivil);
                    Console.WriteLine(persona.Apellido);
                    Console.WriteLine(estudiante.Cursomatriculado);
                    Console.WriteLine(empleados.Añodeincorporacion);
                    Console.WriteLine(empleados.Facultad);
                    Console.WriteLine(empleados.Numerodespacho);
                    Console.WriteLine(profesores.Departamento);
                    break;
                default:
                    Console.WriteLine("listo");
                    break;
            }
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
