using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q400Calculator.Data.Migrations
{
    public partial class InitialFlap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flap5Data",
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
                    table.PrimaryKey("PK_Flap5Data", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flap5Data");
        }
    }
}
