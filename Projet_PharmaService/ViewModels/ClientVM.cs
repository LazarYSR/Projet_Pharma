using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class ClientVM: PersonneVM
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Le champ est invalid. ")]
        [Display(Name = "CIN")]
        public string Cin { get; set; }
       
        [Display(Name = "Mutuelle")]
        public string Mutuelle { get; set; }


        [Display(Name = "État")]
        public string Etat { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public ICollection<Notification> Notifications { get; set; }

        [Required]
        public ICollection<Panier> Paniers { get; set; }


    }
}
