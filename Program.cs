using System;
using System.Collections.Generic;

namespace PromedioNotasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int nAlumnos=0;

            double promedioAlumnos;


            Console.WriteLine("Promedio Notas App \n El siguiente programa calcula el promedio de 3 notas dado un número n de alumnos y también devuelve el promedio del salón");

            Console.WriteLine("Por favor digite un número de alumnos seguido de la tecla intro: ");

            try
            {
                nAlumnos = int.Parse(Console.ReadLine());
            }
            catch (FormatException eF)
            {
                Console.WriteLine("Sólo se adminte un valor entero para el número de alumnos");
                Environment.Exit(0);
            }
            catch (OverflowException oE)
            {
                Console.WriteLine("Se ha introducido un valor muy alto , intente nuevamente");
                Environment.Exit(0);
            }

            List<double> listaPromedios = new List<double>();

            if (nAlumnos != 0)
            {

                for (int i = 1; i <= nAlumnos; i++)
                {
                Alumno Alumno = new Alumno();

                Console.WriteLine("Por favor introduza un nombre para el alumno: " + i);

                Alumno.SetNombreAlumno(Console.ReadLine());

                 Console.WriteLine("Por favor digite un valor de 0 a 5 para la nota1 del Alumno:" + Alumno.GetNombreAlumno());

                 Alumno.SetNota1(ValidaNumero(Console.ReadLine()));

                Console.WriteLine("Por favor digite un valor de 0 a 5 para la nota2 del Alumno:" + Alumno.GetNombreAlumno());

                Alumno.SetNota2(ValidaNumero(Console.ReadLine()));

                Console.WriteLine("Por favor digite un valor de 0 a 5 para la nota3 del Alumno:" + Alumno.GetNombreAlumno());

                Alumno.SetNota3(ValidaNumero(Console.ReadLine()));

                Console.WriteLine("El promedio del alumno: " + Alumno.GetNombreAlumno() + " es: " + Alumno.PromedioNotasAlumno());

                listaPromedios.Add(Alumno.PromedioNotasAlumno());

                }

                double sumaPromedios=0;

                foreach(var num in listaPromedios)
                {
                    sumaPromedios = num + sumaPromedios;
                }

                Console.WriteLine("El promedio del salón es: " + sumaPromedios / nAlumnos);

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Debe ingresar un valor mayor de 0 para el número de alumnos");
            }
        }
        

        public static double ValidaNumero(string numeroEntrada)
        {
            
            try
            {
                var numSalida = double.Parse(numeroEntrada);

                if(numSalida > 0 && numSalida <=5)
                {
                    return numSalida;
                }
                else
                {
                    Console.WriteLine("Sólo se adminte un valor númerico para las notas entre 0 y 5");
                    Environment.Exit(0);
                    return 0;
                }

                
            }            
            catch (FormatException eF)
            {
                Console.WriteLine("Sólo se adminte un valor númerico para las notas de los alumnos");
                
                Environment.Exit(0);
                return 0;
            }
            catch (OverflowException oE)
            {
                Console.WriteLine("Se ha introducido un valor muy alto , intente nuevamente");
                
                Environment.Exit(0);
                return 0;
            }


        }
    }
}
