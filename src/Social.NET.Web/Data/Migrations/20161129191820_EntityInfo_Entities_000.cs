using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Social.NET.Web.Data.Migrations
{
    public partial class EntityInfo_Entities_000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_Entities_EntityInfoId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Entities_EntityInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entities",
                table: "Entities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Entities",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityInfo",
                table: "Entities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_EntityInfo_EntityInfoId",
                table: "AspNetRoles",
                column: "EntityInfoId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_EntityInfo_EntityInfoId",
                table: "AspNetUsers",
                column: "EntityInfoId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameTable(
                name: "Entities",
                newName: "EntityInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_EntityInfo_EntityInfoId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_EntityInfo_EntityInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityInfo",
                table: "EntityInfo");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EntityInfo",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entities",
                table: "EntityInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_Entities_EntityInfoId",
                table: "AspNetRoles",
                column: "EntityInfoId",
                principalTable: "EntityInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Entities_EntityInfoId",
                table: "AspNetUsers",
                column: "EntityInfoId",
                principalTable: "EntityInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameTable(
                name: "EntityInfo",
                newName: "Entities");
        }
    }
}
