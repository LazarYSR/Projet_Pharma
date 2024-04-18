using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class Livraison
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime dateLivraison { get; set; }



    }
}
