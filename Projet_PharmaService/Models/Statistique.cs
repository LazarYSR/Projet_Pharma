namespace Projet_PharmaService.Models
{
    public class Statistique
    {

        public string period {  get; set; }

        public int nombreVentes { get; set; }

        public double chifreDaffaire { get; set; }

        public double margeBeneficiaire { get; set; }

        public Stock stock { get; set; }

        public string StockId { get; set; }

    }
}
