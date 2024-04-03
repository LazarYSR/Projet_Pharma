using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Commande
    {
        [Key]
        public string CommandeId { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime HeureCommande { get; set; }
        public string AdresseLivraison { get; set; }
        public string SuiviLivraison { get; set; }
        public string QR { get; set; }
        public Livreur Livreur{ get; set; }
        [ForeignKey(nameof(Livreur))]
        public int LivreurId { get; set; }
        [NotMapped]
        public ICollection<LigneCommande> LigneCommades { get; set; }


    }
}
