﻿
<<<<<<< HEAD

using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> 82b36668323bb411fcdf6f5da89e6556ebc0b2e6

namespace Projet_PharmaService.Models
{
    public class Client: Personne
    {
        [Key]
        public string Id { get; set; }
        public string Cin { get; set; }
        public string Mutuelle { get; set; }
        public string Etat { get; set; }
        public string Password { get; set; }
 
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }


    }
}
