using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class Feed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feed",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Meta = table.Column<string>(nullable: true),
                    UrlSlug = table.Column<string>(nullable: true),
                    Published = table.Column<bool>(nullable: false),
                    PostedOn = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feed", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feed");
        }
    }
}
