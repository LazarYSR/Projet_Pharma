using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class StockVM
    {
        [Key]
        [Display(Name = "Quantité")]
        public int quantite { get; set; }

        [Display(Name = "Date de péremption")]
        public DateTime datePeremption { get; set; }

        [Display(Name = "Seuil de réapprovisionnement")]
        public double seuilReaprovisionnement { get; set; }

        public PharmacieVM pharmacie { get; set; }

        public string PharmacieId { get; set; }

        public MedicamentVM Medicament { get; set; }

        public string MedicamentId { get; set; }

        public ICollection<Statistique> statistiques { get; set; }

    }
}
