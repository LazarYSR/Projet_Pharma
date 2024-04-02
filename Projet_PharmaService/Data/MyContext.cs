using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class MyContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ArchivePanier> ArchivePanier { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LigneCommande> LigneCommandes { get; set; }
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Livreur> Livreur { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Pharmacie> Pharmacies { get; set; }
        public DbSet<Statistique> Statistiques { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public MyContext(DbContextOptions<MyContext> My):base(My)
        {
        }
    }

   
}
