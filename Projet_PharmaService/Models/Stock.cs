namespace Projet_PharmaService.Models
{
    public class Stock
    {
        public int quantite {  get; set; }

        public DateTime datePeremption { get; set; }

        public double seuilReaprovisionnement { get; set; }

        public Pharmacie pharmacie { get; set; }

        public string PharmacieId { get; set; }

        public Medicament medicament { get; set; }

        public string MedicamentId { get; set; }

        public ICollection<Statistique> statistiques { get; set;}
    }
}
