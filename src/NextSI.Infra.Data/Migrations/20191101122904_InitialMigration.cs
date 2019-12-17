using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NextSI.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Inserted_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Inserted_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Deleted_at", "Email", "Inserted_at", "Name", "Updated_at" },
                values: new object[] { new Guid("a68dda48-7f88-46be-a008-b769a94b58e5"), new DateTime(2019, 11, 1, 9, 29, 4, 98, DateTimeKind.Local).AddTicks(5523), null, "danielbuona@hotmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel Buona", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Deleted_at", "Email", "FirstName", "Inserted_at", "LastName", "Password", "Phone", "Updated_at" },
                values: new object[] { new Guid("e580fb9f-72bf-42bc-aba7-0f785458f47c"), null, "super.admin@nextsi.com.br", "Super", new DateTime(2019, 11, 1, 9, 29, 4, 91, DateTimeKind.Local).AddTicks(2577), "Admin", "36n54v6CzXkFI0A7GjbH1MmI/FjeoRLDzKMpKT6ed60=", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
