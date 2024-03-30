namespace Projet_PharmaService.Models
{
    public class Catalog
    {
        public int Id { get; set; }

        public string category { get; set; }

        public ICollection<Medicament> medicaments { get; set; }
    }
}
