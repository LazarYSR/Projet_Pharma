using Projet_PharmaService.statistiques;
using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Stock
    {
        [Key]
<<<<<<< HEAD
        public string StockId { get; set; }
        public int quantite { get; set; }
=======
        public int StockId { get; set; }             
        public int quantite {  get; set; }
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac

        public DateTime datePeremption { get; set; }

        public double seuilReaprovisionnement { get; set; }

        public Pharmacie Pharmacie { get; set; }
<<<<<<< HEAD

        public string PharmacieId { get; set; }

        public Medicament Medicament { get; set; }

        public string MedicamentId { get; set; }
=======
       
        public int PharmacieId { get; set; }
       
        public Medicament Medicament { get; set; }
        
        public int MedicamentId { get; set; }
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac

        public ICollection<Statistique> statistiques { get; set; }

        public Stock(StockVM uvm)
        {
            this.quantite = uvm.quantite;
            this.datePeremption = DateTime.Now;
            this.seuilReaprovisionnement = uvm.seuilReaprovisionnement;

        }
    }
}
