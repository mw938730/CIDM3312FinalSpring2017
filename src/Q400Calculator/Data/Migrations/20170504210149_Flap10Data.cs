using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class Flap10Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlapData",
                table: "FlapData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flap10Data",
                table: "FlapData",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "FlapData",
                newName: "Flap10Data");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flap10Data",
                table: "Flap10Data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlapData",
                table: "Flap10Data",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Flap10Data",
                newName: "FlapData");
        }
    }
}
