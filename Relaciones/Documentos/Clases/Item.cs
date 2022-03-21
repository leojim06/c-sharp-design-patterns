namespace Documentos.Clases
{
    public class Item
    {
        private readonly string _descripcion;
        private readonly double _precio;
        private readonly int _cantidad;

        public Item(string descripcion, double precio, int cantidad)
        {
            _descripcion = descripcion;
            _precio = precio;
            _cantidad = cantidad;
        }
    }
}
