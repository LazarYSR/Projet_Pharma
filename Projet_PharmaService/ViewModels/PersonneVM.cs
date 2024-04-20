using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Projet_PharmaService.ViewModels
{
  
    public class PersonneVM
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string AdresseEmail { get; set; }
        public string Telephone { get; set; }
   
        public string Cin { get; set; }

    }
}
