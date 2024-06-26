﻿

using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Panier
    {
        [Key]
        public int PanierId { get; set; }

        public double prixTotal { get; set; }

        public string satuts { get; set; }

        public DateTime dateCreation { get; set; }

        public Client client { get; set; }

        public int ClientId { get; set; }

        public Pharmacie Pharmacy { get; set; }

        public int PharmacyId { get; set; }

        public ICollection<Medicament> Medicaments { get; set; }


        public Panier(PanierVM uvm)
        {
            this.prixTotal = uvm.prixTotal;
            this.satuts = uvm.satuts;
            this.dateCreation = DateTime.Now;
        }
    }
}
