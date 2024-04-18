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

<<<<<<< HEAD:Projet_PharmaService/ViewModels/MedicamentVM.cs

        public CatalogVM catalog { get; set; }

        public string CatalogId { get; set; }

        
=======
        [Required]
        public Catalog catalog { get; set; }
        [Required]
        public string CatalogId { get; set; }
        [Required]
        public int CommandeId { get; set; }
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac:Projet_PharmaService/ViewModels/Medicament.cs
    }
}
