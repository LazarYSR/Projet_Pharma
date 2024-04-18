using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class PaiementVM
    {
        [Key]
        public int PaiementId { get; set; }
        public String PaiementMode { get; set; }
        public ICollection<FactureVM> Factures { get; set; }
    }
}
