﻿using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Catalog
    {
        [Key]
        public string Id { get; set; }

        public string category { get; set; }


        public ICollection<Medicament> medicaments { get; set; }
        public Catalog(CatalogVM uvm)
        {
            this.category = uvm.category;
        }
    }
}
