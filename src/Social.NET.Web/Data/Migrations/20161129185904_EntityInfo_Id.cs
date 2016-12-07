using Microsoft.EntityFrameworkCore.Migrations;

namespace Social.NET.Web.Data.Migrations
{
	public partial class EntityInfo_Id : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Tags",
				nullable: false);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Tags",
				nullable: true);
		}
	}
}