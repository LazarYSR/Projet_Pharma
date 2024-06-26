﻿using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.ViewModels

{
    public class CommandeVM
    {
        [Key]
        public int CommandeId { get; set; }

        [Required(ErrorMessage = "Le champ est invalid.")]
        [Display(Name = "Date de commande")]
        public DateTime DateCommande { get; set; }

        [Required(ErrorMessage = "Le champ est invalid.")]
        [Display(Name = "Heure de commande")]
        public DateTime HeureCommande { get; set; }

        [Required(ErrorMessage = "Le champ {0} est requis.")]
        [Display(Name = "Adresse de livraison")]
        public string AdresseLivraison { get; set; }

        [Display(Name = "Suivi de livraison")]
        public string SuiviLivraison { get; set; }

        [Display(Name = "QR")]
        public string QR { get; set; }

        [Required]
        public Livreur Livreur { get; set; }
        public int LivreurId { get; set; }

        public ICollection<Medicament> Medicaments { get; set; }
    }


}

