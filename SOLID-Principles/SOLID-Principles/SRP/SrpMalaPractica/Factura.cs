using System;

namespace SrpMalaPractica
{
    public class Factura
    {
        public long PrecioFactura { get; set; }
        public DateTime FechaFactura { get; set; }

        public void AgregarFactura()
        {
            try
            {
                Console.WriteLine("Agregando la factura a algun repositorio");
                // Agregar la factura en algun repositorio

                Correo correo = new Correo("EmailDe", "EmailPara", "EmailTema", "EmailMensaje");
                EnviarCorreo(correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void BorrarFactura()
        {
            try
            {
                Console.WriteLine("Eliminando la factura de algun repositorio");
                // Eliminar la factura en algun repositorio
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void EnviarCorreo(Correo correo)
        {
            try
            {
                // Enviando correo
                Console.WriteLine("Enviando correo");
                Enviar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Enviar()
        {
            Random rand = new Random();
            if (rand.NextDouble() >= 0.5)
            {
                throw new Exception("Error enviando correo");
            }
        }
    }
}
