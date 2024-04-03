using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class LigneCommande
    {
        [ForeignKey(nameof(CommandeId))]
        public Commande Commande { get; set; }
        [ForeignKey(nameof(PharmacieId))]
        public Pharmacie Pharmacie { get; set; }

        public string CommandeId { get; set; }
        public string PharmacieId { get; set; }
        public int Qte { get; set; }
    }
}
