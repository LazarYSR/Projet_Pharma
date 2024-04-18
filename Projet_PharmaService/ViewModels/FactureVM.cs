using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class FactureVM
    {
        [Key]
        public int FactureId { get; set; }
        public CommandeVM Commande { get; set; }
        public PaiementVM Paiement { get; set; }
        public string CommandeId { get; set; }
        public int PaiementId { get; set; }

        public DateTime DateFacture { get; set; }
        public double PrixTotalFacture { get; set; }
        public double TvaFacture { get; set; }
    }
}
