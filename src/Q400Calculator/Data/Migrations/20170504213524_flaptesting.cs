using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Q400Calculator.Data.Migrations
{
    public partial class flaptesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flap10Data",
                table: "Flap10Data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flap100Data",
                table: "Flap10Data",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Flap10Data",
                newName: "Flap100Data");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flap100Data",
                table: "Flap100Data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flap10Data",
                table: "Flap100Data",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Flap100Data",
                newName: "Flap10Data");
        }
    }
}
