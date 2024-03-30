namespace Projet_PharmaService.Models
{
    public class LigneCommande
    {
        public Commande Commande { get; set; }
        public Pharmacie Pharmacie { get; set; }
        public string CommandeId { get; set; }
        public string PharmacieId { get; set; }
        public int Qte { get; set; }
    }
}
