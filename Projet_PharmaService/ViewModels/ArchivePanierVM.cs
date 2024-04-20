using Microsoft.Build.Framework;
using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels
{
    public class ArchivePanierVM
    {

        [Key]
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Identifiant")]
        
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Date et heure")]
        public DateTime time { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Motif")]
        public string motif { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Statut")]
        public string statuts { get; set; }

        [Display(Name = "Prix Total")]
        public double prixTotal { get; set; }

        [Display(Name = "Code Promo")]
        public int codePromo { get; set; }

        [Display(Name = "Livraison")]
        public string livraison { get; set; }

        [Display(Name = "Mode de Paiement")]
        public string modePaiment { get; set; }

        public Panier panier { get; set; }
        public int PanierId { get; set; }

    }
}
