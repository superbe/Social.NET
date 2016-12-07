using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Social.NET.Web.Data.Migrations
{
	public partial class EntityInfo_Entities_003 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Menu",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Access = table.Column<int>(nullable: false),
					CreationTime = table.Column<DateTime>(nullable: false),
					IsReadOnly = table.Column<bool>(nullable: false),
					LastAccessTime = table.Column<DateTime>(nullable: false),
					LastEditor = table.Column<string>(nullable: true),
					LastWriteTime = table.Column<DateTime>(nullable: false),
					Name = table.Column<string>(nullable: false),
					Owner = table.Column<string>(nullable: true),
					ParentId = table.Column<int>(nullable: true),
					Title = table.Column<string>(nullable: true),
					Version = table.Column<byte[]>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Menu", x => x.Id);
					table.ForeignKey(
						name: "FK_Menu_Menu_ParentId",
						column: x => x.ParentId,
						principalTable: "Menu",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.AddColumn<int>(
				name: "MenuItemId",
				table: "AspNetUsers",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "MenuItemId",
				table: "AspNetRoles",
				nullable: true);

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUsers_MenuItemId",
				table: "AspNetUsers",
				column: "MenuItemId");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetRoles_MenuItemId",
				table: "AspNetRoles",
				column: "MenuItemId");

			migrationBuilder.CreateIndex(
				name: "IX_Menu_ParentId",
				table: "Menu",
				column: "ParentId");

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetRoles_Menu_MenuItemId",
				table: "AspNetRoles",
				column: "MenuItemId",
				principalTable: "Menu",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetUsers_Menu_MenuItemId",
				table: "AspNetUsers",
				column: "MenuItemId",
				principalTable: "Menu",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_AspNetRoles_Menu_MenuItemId",
				table: "AspNetRoles");

			migrationBuilder.DropForeignKey(
				name: "FK_AspNetUsers_Menu_MenuItemId",
				table: "AspNetUsers");

			migrationBuilder.DropIndex(
				name: "IX_AspNetUsers_MenuItemId",
				table: "AspNetUsers");

			migrationBuilder.DropIndex(
				name: "IX_AspNetRoles_MenuItemId",
				table: "AspNetRoles");

			migrationBuilder.DropColumn(
				name: "MenuItemId",
				table: "AspNetUsers");

			migrationBuilder.DropColumn(
				name: "MenuItemId",
				table: "AspNetRoles");

			migrationBuilder.DropTable(
				name: "Menu");
		}
	}
}
