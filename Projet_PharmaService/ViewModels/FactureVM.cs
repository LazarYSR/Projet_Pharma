using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class FactureVM
    {
        [Key]
        public int FactureId { get; set; }
<<<<<<< HEAD:Projet_PharmaService/ViewModels/FactureVM.cs
        public CommandeVM Commande { get; set; }
        public PaiementVM Paiement { get; set; }
=======
        [Required]
        public Commande Commande { get; set; }
        [Required]
        public Paiement Paiement { get; set; }
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac:Projet_PharmaService/ViewModels/Facture.cs
        public string CommandeId { get; set; }
        public int PaiementId { get; set; }
        [Required]
        public DateTime DateFacture { get; set; }
        [Required]
        public double PrixTotalFacture { get; set; }
        [Required]
        public double TvaFacture { get; set; }
    }
}
