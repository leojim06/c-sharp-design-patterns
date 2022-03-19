namespace LspConsoleApp
{
    public abstract class Fruta
    {
        public abstract string ObtenerColor();
    }

    public class Manzana : Fruta
    {
        public override string ObtenerColor()
        {
            return "Rojo";
        }
    }

    public class Naranja: Fruta
    {
        public override string ObtenerColor()
        {
            return "Naranja";
        }
    }
}
