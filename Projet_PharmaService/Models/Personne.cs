
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

    }
}
