namespace SrpMalaPractica
{
    public class Correo
    {
        private string de;
        private string para;
        private string tema;
        private string mensaje;

        public Correo(string de, string para, string tema, string mensaje)
        {
            this.de = de;
            this.para = para;
            this.tema = tema;
            this.mensaje = mensaje;
        }
    }
}
