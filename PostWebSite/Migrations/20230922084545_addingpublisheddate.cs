using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostWebSite.Migrations
{
    /// <inheritdoc />
    public partial class addingpublisheddate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PulishedDate",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PulishedDate",
                table: "Posts");
        }
    }
}
