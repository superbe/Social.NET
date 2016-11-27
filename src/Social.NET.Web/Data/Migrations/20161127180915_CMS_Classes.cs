using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Social.NET.Web.Data.Migrations
{
	public partial class CMS_Classes : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Tags",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Word = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Tags", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Templates",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Changed = table.Column<DateTime>(nullable: false),
					Context = table.Column<string>(nullable: true),
					Created = table.Column<DateTime>(nullable: false),
					UserId = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Templates", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Pages",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Changed = table.Column<DateTime>(nullable: false),
					Created = table.Column<DateTime>(nullable: false),
					Description = table.Column<string>(nullable: true),
					Name = table.Column<string>(nullable: true),
					Script = table.Column<string>(nullable: true),
					Style = table.Column<string>(nullable: true),
					TemplateId = table.Column<int>(nullable: true),
					Text = table.Column<string>(nullable: true),
					Title = table.Column<string>(nullable: true),
					UserId = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Pages", x => x.Id);
					table.ForeignKey(
						name: "FK_Pages_Templates_TemplateId",
						column: x => x.TemplateId,
						principalTable: "Templates",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "PageItems",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Changed = table.Column<DateTime>(nullable: false),
					Context = table.Column<string>(nullable: true),
					Created = table.Column<DateTime>(nullable: false),
					Key = table.Column<string>(nullable: true),
					PageId = table.Column<int>(nullable: true),
					UserId = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_PageItems", x => x.Id);
					table.ForeignKey(
						name: "FK_PageItems_Pages_PageId",
						column: x => x.PageId,
						principalTable: "Pages",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Pages_TemplateId",
				table: "Pages",
				column: "TemplateId",
				unique: true);

			migrationBuilder.CreateIndex(
				name: "IX_PageItems_PageId",
				table: "PageItems",
				column: "PageId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "PageItems");

			migrationBuilder.DropTable(
				name: "Tags");

			migrationBuilder.DropTable(
				name: "Pages");

			migrationBuilder.DropTable(
				name: "Templates");
		}
	}
}