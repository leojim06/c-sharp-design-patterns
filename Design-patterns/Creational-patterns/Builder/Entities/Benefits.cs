namespace Builder.Entities
{
    public class Benefits
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} - Nombre: {Name} - Categoría: {Category}";
        }
    }
}
