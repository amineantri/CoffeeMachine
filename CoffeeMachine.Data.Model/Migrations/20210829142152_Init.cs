using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMachine.Data.Model.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoissonType",
                columns: table => new
                {
                    TypeID = table.Column<Guid>(nullable: false),
                    BoissonName = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoissonType", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Sugar",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sugar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    CommandID = table.Column<Guid>(nullable: false),
                    HasMug = table.Column<bool>(nullable: false),
                    BoissonTypeID = table.Column<Guid>(nullable: true),
                    SugarID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.CommandID);
                    table.ForeignKey(
                        name: "FK_Commande_BoissonType_BoissonTypeID",
                        column: x => x.BoissonTypeID,
                        principalTable: "BoissonType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Sugar_SugarID",
                        column: x => x.SugarID,
                        principalTable: "Sugar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseHistory",
                columns: table => new
                {
                    HistoryID = table.Column<Guid>(nullable: false),
                    CommandDate = table.Column<DateTime>(nullable: false),
                    BoissonTypeID = table.Column<Guid>(nullable: true),
                    SugarID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseHistory", x => x.HistoryID);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_BoissonType_BoissonTypeID",
                        column: x => x.BoissonTypeID,
                        principalTable: "BoissonType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_Sugar_SugarID",
                        column: x => x.SugarID,
                        principalTable: "Sugar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    badgeID = table.Column<Guid>(nullable: false),
                    HistoryID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.badgeID);
                    table.ForeignKey(
                        name: "FK_Badge_PurchaseHistory_HistoryID",
                        column: x => x.HistoryID,
                        principalTable: "PurchaseHistory",
                        principalColumn: "HistoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<Guid>(nullable: false),
                    PersonName = table.Column<string>(nullable: true),
                    badgeID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Person_Badge_badgeID",
                        column: x => x.badgeID,
                        principalTable: "Badge",
                        principalColumn: "badgeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badge_HistoryID",
                table: "Badge",
                column: "HistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_BoissonTypeID",
                table: "Commande",
                column: "BoissonTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_SugarID",
                table: "Commande",
                column: "SugarID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_badgeID",
                table: "Person",
                column: "badgeID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_BoissonTypeID",
                table: "PurchaseHistory",
                column: "BoissonTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_SugarID",
                table: "PurchaseHistory",
                column: "SugarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Badge");

            migrationBuilder.DropTable(
                name: "PurchaseHistory");

            migrationBuilder.DropTable(
                name: "BoissonType");

            migrationBuilder.DropTable(
                name: "Sugar");
        }
    }
}
