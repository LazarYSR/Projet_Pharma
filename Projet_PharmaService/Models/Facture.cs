namespace Projet_PharmaService.Models
{
    public class Facture
    {
        public int IdFacture { get; set; }
        //public Commande Commande { get; set; }
        //public Paiement Paiement { get; set; }
        public string CommandeId { get; set; }
        public int PaiementId { get; set; }

        public DateTime DateFacture { get; set; }
        public double PrixTotalFacture { get; set; }
        public double TvaFacture { get; set; }
    }
}
