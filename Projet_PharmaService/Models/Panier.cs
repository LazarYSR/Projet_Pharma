

namespace Projet_PharmaService.Models
{
    public class Panier
    {

        public int Id { get; set; }

        public double prixTotal { get; set; }

        public int codePrmo { get; set; }

        public string satuts { get; set; }

        public DateTime dateCreation { get; set; }

        public Client client { get; set; }

        public int ClientId { get; set; }

        public Pharmacie pharmacy { get; set; }

        public int PharmaciyId { get; set; }

        public ICollection<Medicament> medicaments { get; set; }

    }
}
