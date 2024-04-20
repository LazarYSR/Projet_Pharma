using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class MedicamentVM
    {
        [Key]
        public string MedicamentId { get; set; }
        [Required]
        public string designation { get; set; }
        [Required]
        public string form { get; set; }
        [Required]
        public string prescription { get; set; }
        [Required]
        public double prixUnitaire { get;}
        [Required]
        public IFormFile image { get; set; }
        [Required]
        public string info { get; set; }
        [Required]
        public Catalog catalog { get; set; }
        public string CatalogId { get; set; }
        [Required]

        public Commande Commande { get; set; }
        public int CommandeId { get; set; }

    }
}
