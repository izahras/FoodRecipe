using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class addtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Reciepes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "AlergicMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reciepes_MaterialId",
                table: "Reciepes",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_AlergicMaterials_MaterialId",
                table: "AlergicMaterials",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlergicMaterials_Materials_MaterialId",
                table: "AlergicMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepes_Materials_MaterialId",
                table: "Reciepes",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlergicMaterials_Materials_MaterialId",
                table: "AlergicMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_Reciepes_Materials_MaterialId",
                table: "Reciepes");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Reciepes_MaterialId",
                table: "Reciepes");

            migrationBuilder.DropIndex(
                name: "IX_AlergicMaterials_MaterialId",
                table: "AlergicMaterials");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Reciepes");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "AlergicMaterials");
        }
    }
}
