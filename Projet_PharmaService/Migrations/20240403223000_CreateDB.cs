using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_PharmaService.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    CommandeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresseLivraison = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuiviLivraison = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivreurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.CommandeId);
                });

            migrationBuilder.CreateTable(
                name: "Livraisons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateLivraison = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livraisons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paiements",
                columns: table => new
                {
                    PaiementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaiementMode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiements", x => x.PaiementId);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    PharmacieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Enseigne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<int>(type: "int", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteWeb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeAPE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.PharmacieId);
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    FactureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommandeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaiementId = table.Column<int>(type: "int", nullable: false),
                    DateFacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrixTotalFacture = table.Column<double>(type: "float", nullable: false),
                    TvaFacture = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => x.FactureId);
                    table.ForeignKey(
                        name: "FK_Factures_Commandes_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commandes",
                        principalColumn: "CommandeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factures_Paiements_PaiementId",
                        column: x => x.PaiementId,
                        principalTable: "Paiements",
                        principalColumn: "PaiementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LigneCommandes",
                columns: table => new
                {
                    CommandeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PharmacieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LigneCommandes_Commandes_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commandes",
                        principalColumn: "CommandeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LigneCommandes_Pharmacies_PharmacieId",
                        column: x => x.PharmacieId,
                        principalTable: "Pharmacies",
                        principalColumn: "PharmacieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destinatire = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivreurId = table.Column<int>(type: "int", nullable: false),
                    PharmacieId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Pharmacies_PharmacieId",
                        column: x => x.PharmacieId,
                        principalTable: "Pharmacies",
                        principalColumn: "PharmacieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paniers",
                columns: table => new
                {
                    PanierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prixTotal = table.Column<double>(type: "float", nullable: false),
                    codePrmo = table.Column<int>(type: "int", nullable: false),
                    satuts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PharmacyPharmacieId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PharmacyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paniers", x => x.PanierId);
                    table.ForeignKey(
                        name: "FK_Paniers_Pharmacies_PharmacyPharmacieId",
                        column: x => x.PharmacyPharmacieId,
                        principalTable: "Pharmacies",
                        principalColumn: "PharmacieId");
                });

            migrationBuilder.CreateTable(
                name: "ArchivePanier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    motif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    statuts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prixTotal = table.Column<double>(type: "float", nullable: false),
                    codePromo = table.Column<int>(type: "int", nullable: false),
                    livraison = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modePaiment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivePanier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchivePanier_Paniers_PanierId",
                        column: x => x.PanierId,
                        principalTable: "Paniers",
                        principalColumn: "PanierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    MedicamentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    form = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalogId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PanierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.MedicamentId);
                    table.ForeignKey(
                        name: "FK_Medicaments_Catalogs_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "Catalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicaments_Paniers_PanierId",
                        column: x => x.PanierId,
                        principalTable: "Paniers",
                        principalColumn: "PanierId");
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quantite = table.Column<int>(type: "int", nullable: false),
                    datePeremption = table.Column<DateTime>(type: "datetime2", nullable: false),
                    seuilReaprovisionnement = table.Column<double>(type: "float", nullable: false),
                    PharmacieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicamentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "MedicamentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Pharmacies_PharmacieId",
                        column: x => x.PharmacieId,
                        principalTable: "Pharmacies",
                        principalColumn: "PharmacieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statistiques",
                columns: table => new
                {
                    StatistiqueID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreVentes = table.Column<int>(type: "int", nullable: false),
                    chifreDaffaire = table.Column<double>(type: "float", nullable: false),
                    margeBeneficiaire = table.Column<double>(type: "float", nullable: false),
                    StockId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistiques", x => x.StatistiqueID);
                    table.ForeignKey(
                        name: "FK_Statistiques_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchivePanier_PanierId",
                table: "ArchivePanier",
                column: "PanierId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_CommandeId",
                table: "Factures",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_PaiementId",
                table: "Factures",
                column: "PaiementId");

            migrationBuilder.CreateIndex(
                name: "IX_LigneCommandes_CommandeId",
                table: "LigneCommandes",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_LigneCommandes_PharmacieId",
                table: "LigneCommandes",
                column: "PharmacieId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_CatalogId",
                table: "Medicaments",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_PanierId",
                table: "Medicaments",
                column: "PanierId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PharmacieId",
                table: "Notifications",
                column: "PharmacieId");

            migrationBuilder.CreateIndex(
                name: "IX_Paniers_PharmacyPharmacieId",
                table: "Paniers",
                column: "PharmacyPharmacieId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistiques_StockId",
                table: "Statistiques",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_MedicamentId",
                table: "Stocks",
                column: "MedicamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_PharmacieId",
                table: "Stocks",
                column: "PharmacieId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchivePanier");

            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "LigneCommandes");

            migrationBuilder.DropTable(
                name: "Livraisons");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Statistiques");

            migrationBuilder.DropTable(
                name: "Paiements");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Paniers");

            migrationBuilder.DropTable(
                name: "Pharmacies");
        }
    }
}
