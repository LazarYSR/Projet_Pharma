namespace PFA1.Models
{
    public class Livreur
    {
           public string Id_Livreur { get; set; }
           public string Password { get; set; }
           public string VehiculeUtilise { get; set; }
           public string ZoneLivraison { get; set; }
           public string Status { get; set; }
           public string NoteSatisfais { get; set; }
           public string Permis { get; set; }
           public string Photo { get; set; }

        public ICollection<Commande> Commandes { get; set; }
    }
}
