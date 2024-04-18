using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class LivraisonVM
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime dateLivraison { get; set; }



    }
}
