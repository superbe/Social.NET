using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Social.NET.Web.Models.Core;

namespace Social.NET.Web.Data.Migrations
{
	public partial class EntityInfo_Create : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "UserId",
				table: "Templates");

			migrationBuilder.DropColumn(
				name: "UserId",
				table: "PageItems");

			migrationBuilder.DropColumn(
				name: "UserId",
				table: "Pages");

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

			migrationBuilder.AddColumn<string>(
				name: "Owner",
				table: "Templates",
				nullable: true);

			migrationBuilder.AddColumn<byte[]>(
				name: "Version",
				table: "Templates",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Owner",
				table: "PageItems",
				nullable: true);

			migrationBuilder.AddColumn<byte[]>(
				name: "Version",
				table: "PageItems",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Owner",
				table: "Pages",
				nullable: true);

			migrationBuilder.AddColumn<byte[]>(
				name: "Version",
				table: "Pages",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "Access",
				table: "Tags",
				nullable: false,
				defaultValue: AccessType.Draft);

			migrationBuilder.AddColumn<DateTime>(
				name: "CreationTime",
				table: "Tags",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.AddColumn<bool>(
				name: "IsReadOnly",
				table: "Tags",
				nullable: false,
				defaultValue: false);

			migrationBuilder.AddColumn<DateTime>(
				name: "LastAccessTime",
				table: "Tags",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.AddColumn<string>(
				name: "LastEditor",
				table: "Tags",
				nullable: true);

			migrationBuilder.AddColumn<DateTime>(
				name: "LastWriteTime",
				table: "Tags",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.AddColumn<string>(
				name: "Name",
				table: "Tags",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "Owner",
				table: "Tags",
				nullable: true);

			migrationBuilder.AddColumn<byte[]>(
				name: "Version",
				table: "Tags",
				nullable: true);

			migrationBuilder.CreateIndex(
				name: "IX_StringProperty_TagId",
				table: "StringProperty",
				column: "TagId");

			migrationBuilder.CreateIndex(
				name: "IX_StringProperty_TagId1",
				table: "StringProperty",
				column: "TagId1");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "Owner",
				table: "Templates");

			migrationBuilder.DropColumn(
				name: "Version",
				table: "Templates");

			migrationBuilder.DropColumn(
				name: "Owner",
				table: "PageItems");

			migrationBuilder.DropColumn(
				name: "Version",
				table: "PageItems");

			migrationBuilder.DropColumn(
				name: "Owner",
				table: "Pages");

			migrationBuilder.DropColumn(
				name: "Version",
				table: "Pages");

			migrationBuilder.DropColumn(
				name: "Access",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "CreationTime",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "IsReadOnly",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "LastAccessTime",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "LastEditor",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "LastWriteTime",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "Name",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "Owner",
				table: "Tags");

			migrationBuilder.DropColumn(
				name: "Version",
				table: "Tags");

			migrationBuilder.DropTable(
				name: "StringProperty");

			migrationBuilder.AddColumn<string>(
				name: "UserId",
				table: "Templates",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "UserId",
				table: "PageItems",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "UserId",
				table: "Pages",
				nullable: true);
		}
	}
}
