namespace DipMalaPractica
{
    public class EmpleadoLogicaNegocio
    {
        EmpleadoLogicaAccesoDatos _empleadoLogicaAccesoDatos;

        public EmpleadoLogicaNegocio()
        {
            _empleadoLogicaAccesoDatos = FabricaAccesoDatos.ObtenerAccesoDatosEmpleado();
        }

        public Empleado ObtenerDetalleEmpleado(int id)
        {
            return _empleadoLogicaAccesoDatos.ObtenerDetalleEmpleado(id);
        }
    }
}
