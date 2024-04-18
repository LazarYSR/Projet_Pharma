using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class LigneCommande
    {
        public CommandeVM Commande { get; set; }
        public PharmacieVM Pharmacie { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Identifiant de la commande")]
        public string CommandeId { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Identifiant de la pharmacie")]
        public string PharmacieId { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Quantité")]
        public int Qte { get; set; }
    }
}
