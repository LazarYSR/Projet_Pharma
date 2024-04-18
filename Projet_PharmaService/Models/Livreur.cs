using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Livreur : Personne
    {
        [Key]
        public string LivreurId { get; set; }
           public string Password { get; set; }
           public string VehiculeUtilise { get; set; }
           public string ZoneLivraison { get; set; }
           public string Status { get; set; }
           public string NoteSatisfais { get; set; }
           public string Permis { get; set; }
           public IFormFile Photo { get; set; }

        public ICollection<Commande> Commandes { get; set; }


        public Livreur(LivreurVM uvm)
        {
            this.Password = uvm.Password;
            this.VehiculeUtilise = uvm.VehiculeUtilise;
            this.ZoneLivraison = uvm.ZoneLivraison;
            this.Status = uvm.Status;
            this.NoteSatisfais = uvm.NoteSatisfais;
            this.Permis = uvm.Permis;
            this.Photo = uvm.Photo;

        }
    }
}
