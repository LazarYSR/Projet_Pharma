using System.Security.Principal;

namespace Projet_PharmaService.Models
{
    public class Pharmacie
    {
        public String Id_Pharmacie { get; set; }
        public String Enseigne { get; set; }
        public String Adresse { get; set; }
        public String Telephone { get; set; }
        public String Email { get; set; }
        public int CodePostal { get; set; }
        public String Ville { get; set; }
        public String SiteWeb { get; set; }
        public String CodeAPE { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }
    }
}
