using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class Admin : Personne
    {

        [Required]
        public int Id { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public DateTime DateCreation { get; set; }

        

    }
}
