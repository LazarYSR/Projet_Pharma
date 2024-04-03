using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class Stock
    {
        [Key]
        [Display(Name = "Quantité")]
        public int quantite { get; set; }

        [Display(Name = "Date de péremption")]
        public DateTime datePeremption { get; set; }

        [Display(Name = "Seuil de réapprovisionnement")]
        public double seuilReaprovisionnement { get; set; }

        public Pharmacie pharmacie { get; set; }

        public string PharmacieId { get; set; }

        public Medicament Medicament { get; set; }

        public string MedicamentId { get; set; }

        public ICollection<Statistique> statistiques { get; set; }

    }
}
