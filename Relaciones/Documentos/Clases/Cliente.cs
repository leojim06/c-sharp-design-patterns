namespace Documentos.Clases
{
    public class Cliente
    {
        private string _nombre;
        private string _apellido;

        public Cliente(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        public string Presentarse()
        {
            return $"{_nombre} {_apellido}";
        }
    }
}
