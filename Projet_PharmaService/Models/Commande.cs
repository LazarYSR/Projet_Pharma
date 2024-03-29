namespace PFA1.Models
{
    public class Commande
    {
        public int Id_Commande { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime HeureCommande { get; set; }
        public String AdresseLivraison { get; set; }
        public String SuiviLivraison { get; set; }
        public string QR { get; set; }
        public Livreur Livreur{ get; set; }   
        public int LivreurId { get; set; }
        public ICollection<LigneCommande> LigneCommades { get; set; }


    }
}
