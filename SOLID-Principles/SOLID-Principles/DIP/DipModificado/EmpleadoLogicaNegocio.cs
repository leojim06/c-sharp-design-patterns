namespace DipModificado
{
    public class EmpleadoLogicaNegocio
    {
        IEmpleadoLogicaAccesoDatos _empleadoLogicaAccesoDatos; 
        
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
