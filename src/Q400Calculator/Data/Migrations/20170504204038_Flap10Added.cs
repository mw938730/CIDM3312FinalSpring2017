using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class Flap10Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flap5Data",
                table: "Flap5Data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlapData",
                table: "Flap5Data",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Flap5Data",
                newName: "FlapData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlapData",
                table: "FlapData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flap5Data",
                table: "FlapData",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "FlapData",
                newName: "Flap5Data");
        }
    }
}
