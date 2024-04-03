﻿using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class Paiement
    {
        [Key]
        public int PaiementId { get; set; }
        public String PaiementMode { get; set; }
        public ICollection<Facture> Factures { get; set; }
    }
}
