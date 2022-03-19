namespace DipModificado
{
    public class FabricaAccesoDatos
    {
        public static IEmpleadoLogicaAccesoDatos ObtenerAccesoDatosEmpleado()
        {
            return new EmpleadoLogicaAccesoDatos();
        }
    }
}
