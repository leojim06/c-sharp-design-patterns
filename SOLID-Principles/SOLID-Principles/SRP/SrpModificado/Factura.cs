using System;

namespace SrpModificado
{
    public class Factura 
    {
        public long PrecioFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        private ILogger logger;
        private Correo email;

        public Factura()
        {
            logger = new ConsoleLogger();
        }

        public void AgregarFactura()
        {
            try
            {
                logger.Info("Agregando la factura a algun repositorio");
                // Agregar la factura en algun repositorio

                Correo correo = new Correo("EmailDe", "EmailPara", "EmailTema", "EmailMensaje");
                correo.EnviarCorreo();

            }
            catch (Exception ex)
            {
                logger.Error("Ocurrio un error mientras se generaba la factura", ex);
            }
        }

        public void BorrarFactura()
        {
            try
            {
                logger.Info("Eliminando la factura de algun repositorio");
                // Eliminar la factura en algun repositorio

            }
            catch (Exception ex)
            {
                logger.Error("Ocurrio un error mientras se borraba la factura", ex);
            }
        }
    }
}
