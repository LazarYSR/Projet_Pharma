
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public int Destinatire { get; set; }
        public String Message { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heure { get; set; }
        public String Status { get; set; }
        public Livreur Livreur { get; set; }
        public int LivreurId {  get; set; }
        public  Pharmacie Pharmacie { get; set; }
        public int PharmacieId { get; set; }

    }
}
