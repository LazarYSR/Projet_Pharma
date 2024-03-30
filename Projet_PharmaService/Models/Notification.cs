
namespace Projet_PharmaService.Models
{
    public class Notification
    {
        public int Id_Notification { get; set; }
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
