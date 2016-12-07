using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Social.NET.Web.Data.Migrations
{
	public partial class EntityInfo_Entities_001 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
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

			migrationBuilder.AddPrimaryKey(
				name: "PK_EntityInfos",
				table: "EntityInfo",
				column: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetRoles_EntityInfos_EntityInfoId",
				table: "AspNetRoles",
				column: "EntityInfoId",
				principalTable: "EntityInfo",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetUsers_EntityInfos_EntityInfoId",
				table: "AspNetUsers",
				column: "EntityInfoId",
				principalTable: "EntityInfo",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.RenameTable(
				name: "EntityInfo",
				newName: "EntityInfos");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_AspNetRoles_EntityInfos_EntityInfoId",
				table: "AspNetRoles");

			migrationBuilder.DropForeignKey(
				name: "FK_AspNetUsers_EntityInfos_EntityInfoId",
				table: "AspNetUsers");

			migrationBuilder.DropPrimaryKey(
				name: "PK_EntityInfos",
				table: "EntityInfos");

			migrationBuilder.AddPrimaryKey(
				name: "PK_EntityInfo",
				table: "EntityInfos",
				column: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetRoles_EntityInfo_EntityInfoId",
				table: "AspNetRoles",
				column: "EntityInfoId",
				principalTable: "EntityInfos",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_AspNetUsers_EntityInfo_EntityInfoId",
				table: "AspNetUsers",
				column: "EntityInfoId",
				principalTable: "EntityInfos",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.RenameTable(
				name: "EntityInfos",
				newName: "EntityInfo");
		}
	}
}
