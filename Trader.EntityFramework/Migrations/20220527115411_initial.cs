using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trader.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Acounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountHolderId = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acounts_Users_AccountHolderId",
                        column: x => x.AccountHolderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetTransection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcountId = table.Column<int>(type: "int", nullable: false),
                    IsPurchase = table.Column<bool>(type: "bit", nullable: false),
                    Stock_Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock_PricePerShare = table.Column<double>(type: "float", nullable: false),
                    ShareAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTransection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetTransection_Acounts_AcountId",
                        column: x => x.AcountId,
                        principalTable: "Acounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acounts_AccountHolderId",
                table: "Acounts",
                column: "AccountHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTransection_AcountId",
                table: "AssetTransection",
                column: "AcountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTransection");

            migrationBuilder.DropTable(
                name: "Acounts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
