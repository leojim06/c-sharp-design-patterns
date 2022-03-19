using System;

namespace SrpModificado
{
    internal class Correo
    {
        public string De { get; set; }
        public string Para { get; set; }
        public string Tema { get; set; }
        public string Mensaje { get; set; }

        public Correo(string de, string para, string tema, string mensaje)
        {
            De = de;
            Para = para;
            Tema = tema;
            Mensaje = mensaje;
        }

        public void EnviarCorreo()
        {
            Console.WriteLine("Enviando correo");
            Random rand = new Random();
            if (rand.NextDouble() >= 0.5)
            {
                throw new Exception("Error enviando correo");
            }
        }
    }
}
