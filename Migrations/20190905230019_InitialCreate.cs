﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestGoogle.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    TestNumber = table.Column<int>(nullable: false),
                    xAco = table.Column<string>(nullable: true),
                    yAco = table.Column<string>(nullable: true),
                    zAco = table.Column<string>(nullable: true),
                    xGeo = table.Column<string>(nullable: true),
                    yGeo = table.Column<string>(nullable: true),
                    DefType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    xAco = table.Column<string>(nullable: true),
                    yAco = table.Column<string>(nullable: true),
                    zAco = table.Column<string>(nullable: true),
                    xGeo = table.Column<string>(nullable: true),
                    yGeo = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    TestNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Possibles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    TestNumber = table.Column<int>(nullable: false),
                    xAco = table.Column<string>(nullable: true),
                    yAco = table.Column<string>(nullable: true),
                    zAco = table.Column<string>(nullable: true),
                    xGeo = table.Column<string>(nullable: true),
                    yGeo = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Tested = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Possibles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "MobileData");

            migrationBuilder.DropTable(
                name: "Possibles");
        }
    }
}
