﻿namespace Projet_PharmaService.Models
{
    public class Medicament
    {

        public string Id { get; set; }

        public string designation { get; set; }

        public string form { get; set; }

        public string prescription { get; set; }

        public double prixUnitaire { get;}

        public string image { get; set; }

        public string info { get; set; }


        public Catalog catalog { get; set; }

        public string CatalogId { get; set; }

        public ICollection<LigneCommande> commandes { get; set; }
    }
}
