using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class CatalogVM
    {
        [Key]
        public int Id { get; set; }
      
        [Required(ErrorMessage = "Le champ est invalid.")]
        [Display(Name = "Catégorie")]
        public string category { get; set; }
      
        [Display(Name = "Médicaments")]
        public ICollection<MedicamentVM> medicaments { get; set; }
    }
}
