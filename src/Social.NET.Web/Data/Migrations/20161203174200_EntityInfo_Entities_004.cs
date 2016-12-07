using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Social.NET.Web.Data.Migrations
{
	public partial class EntityInfo_Entities_004 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "PageId",
				table: "Menu",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "PageURL",
				table: "Menu",
				nullable: true);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "PageId",
				table: "Menu");

			migrationBuilder.DropColumn(
				name: "PageURL",
				table: "Menu");
		}
	}
}
