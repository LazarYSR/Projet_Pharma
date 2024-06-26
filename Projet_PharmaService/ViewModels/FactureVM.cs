﻿using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class FactureVM
    {
        [Key]
        public int FactureId { get; set; }

        [Required]
        public Commande Commande { get; set; }
        public string CommandeId { get; set; }

        [Required]
        public Paiement Paiement { get; set; }
        public int PaiementId { get; set; }

        [Required]
        public DateTime DateFacture { get; set; }

        [Required]
        public double PrixTotalFacture { get; set; }

        [Required]
        public double TvaFacture { get; set; }
    }
}
