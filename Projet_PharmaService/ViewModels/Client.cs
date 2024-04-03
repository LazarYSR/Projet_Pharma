using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class Client: Personne
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Le champ est invali d. ")]
        [Display(Name = "CIN")]
        public string Cin { get; set; }
       
        [Display(Name = "Mutuelle")]
        public string Mutuelle { get; set; }


        [Display(Name = "État")]
        public string Etat { get; set; }


        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
 
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }


    }
}
