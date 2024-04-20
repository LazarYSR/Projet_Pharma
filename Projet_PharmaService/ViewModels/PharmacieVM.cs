
using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Projet_PharmaService.ViewModels
{
    public class PharmacieVM
    {
        [Key]
        public string PharmacieId { get; set; }
        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Enseigne")]
        public string Enseigne { get; set; }

        [Display(Name = "Adresse")]
        public string Adresse { get; set; }

        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Code Postal")]
        public int CodePostal { get; set; }

        [Display(Name = "Ville")]
        public string Ville { get; set; }

        [Display(Name = "Site Web")]
        public string SiteWeb { get; set; }

        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }
    }
}

