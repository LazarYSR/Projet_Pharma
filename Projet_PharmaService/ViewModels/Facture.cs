using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class Facture
    {
        [Key]
        public int FactureId { get; set; }
        public Commande Commande { get; set; }
        public Paiement Paiement { get; set; }
        public string CommandeId { get; set; }
        public int PaiementId { get; set; }

        public DateTime DateFacture { get; set; }
        public double PrixTotalFacture { get; set; }
        public double TvaFacture { get; set; }
    }
}
