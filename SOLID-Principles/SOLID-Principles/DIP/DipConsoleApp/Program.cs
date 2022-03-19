using System;

namespace DipConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principio de inversion de dependencia");
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de empleado sin DIP");
            ObtenerEmpleadoSinDIP();
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine("Ejemplo de empleado con DIP");
            ObtenerEmpleadoConDIP();
        }
        private static void ObtenerEmpleadoSinDIP()
        {
            DipMalaPractica.EmpleadoLogicaNegocio empleadoLogicaNegocio = new DipMalaPractica.EmpleadoLogicaNegocio();
            DipMalaPractica.Empleado empleado = empleadoLogicaNegocio.ObtenerDetalleEmpleado(1);
            Console.WriteLine("Empleado obtenido: " + empleado.Nombre);
        }

        private static void ObtenerEmpleadoConDIP()
        {
            DipModificado.EmpleadoLogicaNegocio empleadoLogicaNegocio = new DipModificado.EmpleadoLogicaNegocio();
            DipModificado.Empleado empleado = empleadoLogicaNegocio.ObtenerDetalleEmpleado(1);
            Console.WriteLine("Empleado obtenido: " + empleado.Nombre);
        }
    }
}
