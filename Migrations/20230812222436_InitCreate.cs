using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace JQueryDataTables.Migrations
{
	public partial class InitCreate : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Customers",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
					LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
					Contact = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
					Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
					BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Customers", x => x.Id);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Customers");
		}
	}
}
