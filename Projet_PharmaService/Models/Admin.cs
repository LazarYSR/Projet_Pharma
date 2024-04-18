using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Projet_PharmaService.Models
{
    public class Admin : Personne
    {

        [Key]
        public int Id { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public DateTime DateCreation { get; set; }

        public Admin(AdminVM uvm)
        {
            this.login = uvm.login;
            this.password = uvm.password;
            this.DateCreation = DateTime.Now;
        }

    }
}
