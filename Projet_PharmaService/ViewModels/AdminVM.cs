using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class AdminVM : PersonneVM
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }

    }
}
