using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class Flappity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flap100Data",
                table: "Flap100Data");

            migrationBuilder.CreateTable(
                name: "Flap10Data",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cold0V2 = table.Column<int>(nullable: false),
                    Cold0Vr = table.Column<int>(nullable: false),
                    Cold10000V2 = table.Column<int>(nullable: false),
                    Cold10000Vr = table.Column<int>(nullable: false),
                    Cold2000V2 = table.Column<int>(nullable: false),
                    Cold2000Vr = table.Column<int>(nullable: false),
                    Cold4000V2 = table.Column<int>(nullable: false),
                    Cold4000Vr = table.Column<int>(nullable: false),
                    Cold6000V2 = table.Column<int>(nullable: false),
                    Cold6000Vr = table.Column<int>(nullable: false),
                    Cold8000V2 = table.Column<int>(nullable: false),
                    Cold8000Vr = table.Column<int>(nullable: false),
                    Hot0V2 = table.Column<int>(nullable: false),
                    Hot0Vr = table.Column<int>(nullable: false),
                    Hot10000V2 = table.Column<int>(nullable: false),
                    Hot10000Vr = table.Column<int>(nullable: false),
                    Hot2000V2 = table.Column<int>(nullable: false),
                    Hot2000Vr = table.Column<int>(nullable: false),
                    Hot4000V2 = table.Column<int>(nullable: false),
                    Hot4000Vr = table.Column<int>(nullable: false),
                    Hot6000V2 = table.Column<int>(nullable: false),
                    Hot6000Vr = table.Column<int>(nullable: false),
                    Hot8000V2 = table.Column<int>(nullable: false),
                    Hot8000Vr = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flap10Data", x => x.Id);
                });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flap5Data",
                table: "Flap100Data",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Flap100Data",
                newName: "Flap5Data");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Flap5Data",
                table: "Flap5Data");

            migrationBuilder.DropTable(
                name: "Flap10Data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flap100Data",
                table: "Flap5Data",
                column: "Id");

            migrationBuilder.RenameTable(
                name: "Flap5Data",
                newName: "Flap100Data");
        }
    }
}
