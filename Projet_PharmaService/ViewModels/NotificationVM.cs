using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class NotificationVM
    {
        [Key]
        public int NotificationId { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Destinataire")]
        public int Destinataire { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Heure")]
        public DateTime Heure { get; set; }

        [Display(Name = "Statut")]
        public string Status { get; set; }

        public LivreurVM Livreur { get; set; }
        public int LivreurId { get; set; }

        public PharmacieVM Pharmacie { get; set; }
        public int PharmacieId { get; set; }
    }
}
