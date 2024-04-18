

using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class PanierVM
    {
        [Key]
        public int PanierId { get; set; }

        [Display(Name = "Prix Total")]
        public double prixTotal { get; set; }

        [Display(Name = "Code Promo")]
        public int codePrmo { get; set; }

        [Display(Name = "Statut")]
        public string satuts { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Date de création")]
        public DateTime dateCreation { get; set; }

        public ClientVM client { get; set; }
        public int ClientId { get; set; }

        public PharmacieVM Pharmacy { get; set; }
        public int PharmacyId { get; set; }

        public ICollection<MedicamentVM> Medicaments { get; set; }
    }

}

