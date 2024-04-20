using Projet_PharmaService.Models;
using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.statistiques
{
    public class StatistiqueVM
    {
            [Key]
            public string StatistiqueID { get; set; }

            [Required(ErrorMessage = "Le champ {0} est requis.")]
            [Display(Name = "Période")]
            public string period { get; set; }

            [Required(ErrorMessage = "Le champ {0} est requis.")]
            [Display(Name = "Nombre de ventes")]
            public int nombreVentes { get; set; }

            [Required(ErrorMessage = "Le champ {0} est requis.")]
            [Display(Name = "Chiffre d'affaires")]
            public double chifreDaffaire { get; set; }

            [Required(ErrorMessage = "Le champ {0} est requis.")]
            [Display(Name = "Marge bénéficiaire")]
            public double margeBeneficiaire { get; set; }

            public Stock Stock { get; set; }
            public string StockId { get; set; }

        }
}
