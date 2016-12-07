using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Social.NET.Web.Data.Migrations
{
	public partial class EntityInfo_Users : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "StringProperty");

			migrationBuilder.AddColumn<int>(
				name: "TagId",
				table: "AspNetUsers",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "TagId",
				table: "AspNetRoles",
				nullable: true);

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUsers_TagId",
				table: "AspNetUsers",
				column: "TagId");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetRoles_TagId",
				table: "AspNetRoles",
				column: "TagId");

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetRoles_Tags_TagId",
				table: "AspNetRoles",
				column: "TagId",
				principalTable: "Tags",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetUsers_Tags_TagId",
				table: "AspNetUsers",
				column: "TagId",
				principalTable: "Tags",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_AspNetRoles_Tags_TagId",
				table: "AspNetRoles");

			migrationBuilder.DropForeignKey(
				name: "FK_AspNetUsers_Tags_TagId",
				table: "AspNetUsers");

			migrationBuilder.DropIndex(
				name: "IX_AspNetUsers_TagId",
				table: "AspNetUsers");

			migrationBuilder.DropIndex(
				name: "IX_AspNetRoles_TagId",
				table: "AspNetRoles");

			migrationBuilder.DropColumn(
				name: "TagId",
				table: "AspNetUsers");

			migrationBuilder.DropColumn(
				name: "TagId",
				table: "AspNetRoles");

			migrationBuilder.CreateTable(
				name: "StringProperty",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					TagId = table.Column<int>(nullable: true),
					TagId1 = table.Column<int>(nullable: true),
					Value = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_StringProperty", x => x.Id);
					table.ForeignKey(
						name: "FK_StringProperty_Tags_TagId",
						column: x => x.TagId,
						principalTable: "Tags",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_StringProperty_Tags_TagId1",
						column: x => x.TagId1,
						principalTable: "Tags",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_StringProperty_TagId",
				table: "StringProperty",
				column: "TagId");

			migrationBuilder.CreateIndex(
				name: "IX_StringProperty_TagId1",
				table: "StringProperty",
				column: "TagId1");
		}
	}
}
