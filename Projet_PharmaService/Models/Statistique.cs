using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Statistique
    {
        [Key]
        public string StatistiqueID { get; set; }
        public string period {  get; set; }

        public int nombreVentes { get; set; }

        public double chifreDaffaire { get; set; }

        public double margeBeneficiaire { get; set; }

        public Stock Stock { get; set; }

        public string StockId { get; set; }

    }
}
