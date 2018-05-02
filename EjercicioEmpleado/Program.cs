using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Console.WriteLine("Dime tu nombre");
            string Nombre = Console.ReadLine();

            if (Nombre == string.Empty)
            {
                empleado.MostrarDatos();
            }
            else
            {
                empleado.Nombre = Nombre;

                Console.WriteLine("Dime tu sueldo");
                empleado.Sueldo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dime tu cargo");
                empleado.Cargo = Console.ReadLine();

                empleado.MostrarDatos();
            }
            

            Console.Read();

        }
    }
}


////(3.5). Crear un programa que contenga la clase ‘Empleado.cs’ con tres atributos “nombre”
//,“sueldo” y “cargo” y un método
//“imprimir”. 
////El programa cliente solicitará al usuario su nombre y en caso de que el usuario haga
//intro el programa construirá el objeto con unos datos fijos o constantes:
//(nombre =“Nuevo Empleado”,sueldo = 1000,cargo=“Empleado Base”), si introduce el nombre 
//    procederá a solicitar el resto de datos.
////Al final el programa imprimirá “El nombre del empleado es XXXX y su sueldo es de 
//XXXX” cuyo cargo es “XXXXX