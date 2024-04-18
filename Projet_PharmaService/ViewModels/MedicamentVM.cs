using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class MedicamentVM
    {
        [Key]
        public string MedicamentId { get; set; }

        public string designation { get; set; }

        public string form { get; set; }

        public string prescription { get; set; }

        public double prixUnitaire { get;}

        public string image { get; set; }

        public string info { get; set; }


        public CatalogVM catalog { get; set; }

        public string CatalogId { get; set; }

        
    }
}
