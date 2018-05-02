using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleado
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Sueldo { get; set; }
        public string Cargo { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine("Me llamo {0} , mi sueldo es de {1} y mi cargo es {2}",
                Nombre, Sueldo, Cargo);
        }
        //creamos el constructor para la parte fija
        public Empleado()
        {
            Nombre = "Nuevo empleado";
            Sueldo = 1000;
            Cargo = "Empleado base";
        }
    }
}
