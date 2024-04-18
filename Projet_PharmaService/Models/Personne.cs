
using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    [NotMapped]
    public class Personne
    {
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private DateTime DateNaissance { get; set; }
        private string Adresse { get; set; }
        private string AdresseEmail { get; set; }
        private string Telephone { get; set; }
        private string Cin { get; set; }

        public Personne(PersonneVM uvm)
        {
            this.Nom = uvm.Nom;
            this.Prenom = uvm.Prenom;
            this.DateNaissance = DateTime.Now;
            this.Adresse = uvm.Adresse;
            this.AdresseEmail = uvm.AdresseEmail;
            this.Telephone = uvm.Telephone;
            this.Cin = uvm.Cin;
        }
    }
}
