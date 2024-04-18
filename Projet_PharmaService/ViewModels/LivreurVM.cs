using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class LivreurVM : PersonneVM
    {
        [Key]
        public string LivreurId { get; set; }

        [Required(ErrorMessage = "Le Password est obliger.")]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Display(Name = "Véhicule utilisé")]
        public string VehiculeUtilise { get; set; }

        [Display(Name = "Zone de livraison")]
        public string ZoneLivraison { get; set; }

        [Display(Name = "Statut")]
        public string Status { get; set; }

        [Display(Name = "Note de satisfaction")]
        public string NoteSatisfais { get; set; }

        [Display(Name = "Permis")]
        public string Permis { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }
<<<<<<< HEAD:Projet_PharmaService/ViewModels/LivreurVM.cs

        public ICollection<CommandeVM> Commandes { get; set; }
=======
        [Required]
        public int CommandeId { get; set; }
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac:Projet_PharmaService/ViewModels/Livreur.cs
    }
}

