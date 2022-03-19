namespace LspConsoleApp
{
    public class ManzanaSinLsp
    {
        public virtual string ObtenerColor()
        {
            return "Rojo";
        }
    }

    public class NaranjaSinLsp : ManzanaSinLsp
    {
        public override string ObtenerColor()
        {
            return "Naranja";
        }
    }
}
