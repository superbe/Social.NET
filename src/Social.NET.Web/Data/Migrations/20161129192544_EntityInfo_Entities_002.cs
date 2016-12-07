using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Social.NET.Web.Data.Migrations
{
    public partial class EntityInfo_Entities_002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_EntityInfos_EntityInfoId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_EntityInfos_EntityInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EntityInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_EntityInfoId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "EntityInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EntityInfoId",
                table: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EntityInfos");

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    Name = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Version = table.Column<byte[]>(nullable: true),
                    Word = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.CreateTable(
                name: "EntityInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Access = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    LastAccessTime = table.Column<DateTime>(nullable: false),
                    LastEditor = table.Column<string>(nullable: true),
                    LastWriteTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Version = table.Column<byte[]>(nullable: true),
                    Word = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityInfos", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "EntityInfoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityInfoId",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EntityInfoId",
                table: "AspNetUsers",
                column: "EntityInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_EntityInfoId",
                table: "AspNetRoles",
                column: "EntityInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_EntityInfos_EntityInfoId",
                table: "AspNetRoles",
                column: "EntityInfoId",
                principalTable: "EntityInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_EntityInfos_EntityInfoId",
                table: "AspNetUsers",
                column: "EntityInfoId",
                principalTable: "EntityInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
