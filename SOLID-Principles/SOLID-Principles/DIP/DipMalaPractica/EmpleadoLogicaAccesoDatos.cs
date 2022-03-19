namespace DipMalaPractica
{
    public class EmpleadoLogicaAccesoDatos
    {
        public Empleado ObtenerDetalleEmpleado(int id)
        {
            Empleado empleado = new Empleado()
            {
                ID = id,
                Nombre = "Jhon Doe",
                Area = "IT",
                Salario = 10_000
            };
            return empleado;
        }
    }
}
