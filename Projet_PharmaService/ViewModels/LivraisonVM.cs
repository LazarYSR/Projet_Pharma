using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class LivraisonVM
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime dateLivraison { get; set; }

        [Display(Name = "Client")]
        [Compare(nameof(Commande.QR), ErrorMessage = "QR doit etres equivalent")]
        public string ConfirmationQR { get; set; }

    }
}
