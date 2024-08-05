using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "94d76e20-f4d8-4386-b68f-1e611512f683", null, "seller", null },
                    { "9a44f873-e582-4df3-a71a-a9cc5f944e33", null, "admin", "seller" },
                    { "a7734ccb-92aa-44ba-9e67-32c1ba463dae", null, "client", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94d76e20-f4d8-4386-b68f-1e611512f683");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a44f873-e582-4df3-a71a-a9cc5f944e33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7734ccb-92aa-44ba-9e67-32c1ba463dae");
        }
    }
}
