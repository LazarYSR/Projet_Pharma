using Microsoft.EntityFrameworkCore;
using Projet_PharmaService.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Xml;

namespace Projet_PharmaService.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {
            
        }
        

        public DbSet<Client> Clients { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ArchivePanier> ArchivePaniers { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
<<<<<<< HEAD
=======
     
>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Pharmacie> Pharmacies { get; set; }
        public DbSet<Statistique> Statistiques { get; set; }
        public DbSet<Stock> Stocks { get; set; }

      
    }


}
