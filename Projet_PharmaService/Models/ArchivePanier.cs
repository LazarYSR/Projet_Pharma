namespace Projet_PharmaService.Models
{
    public class ArchivePanier
    {

        public int Id { get; set; }

        public DateTime time { get; set; }

        public string motif { get; set; }

        public string statuts { get; set; }

        public double prixTotal { get; set; }

        public int codePromo { get; set; }

        public string livraison { get; set; }

        public string modePaiment { get; set; }

        public Panier panier { get; set; }

        public int IdPanier { get; set; }

    }
}
