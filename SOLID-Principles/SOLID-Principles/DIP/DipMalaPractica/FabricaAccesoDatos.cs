namespace DipMalaPractica
{
    public class FabricaAccesoDatos
    {
        public static EmpleadoLogicaAccesoDatos ObtenerAccesoDatosEmpleado()
        {
            return new EmpleadoLogicaAccesoDatos();
        }
    }
}
