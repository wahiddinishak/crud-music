using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crud_music.Migrations
{
    public partial class artists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    artisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    artisName = table.Column<string>(nullable: true),
                    albumName = table.Column<string>(nullable: true),
                    imageURL = table.Column<string>(nullable: true),
                    releaseDate = table.Column<DateTime>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    sampleURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.artisID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
