using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Medicament
    {
        [Key]
        public int MedicamentId { get; set; }

        public string designation { get; set; }

        public string form { get; set; }

        public string prescription { get; set; }

        public double prixUnitaire { get;}

        public IFormFile image { get; set; }

        public string info { get; set; }

        
        public Catalog catalog { get; set; }
        [ForeignKey("catalog")]

<<<<<<< HEAD
        public string CatalogId { get; set; }
        [NotMapped]
        public ICollection<LigneCommande> Lignecommandes { get; set; }

        public Medicament(MedicamentVM uvm)
        {
            this.designation = uvm.designation;
            this.form = uvm.form;
            this.prescription = uvm.prescription;
            this.image = uvm.image;
            this.info = uvm.info;
        }
=======
        public int CatalogId { get; set; }
        
        public Commande Commande { get; set; }
        public int CommandeId { get; set; }
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac
    }
}
