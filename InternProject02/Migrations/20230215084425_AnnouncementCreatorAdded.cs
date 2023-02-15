using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProject02.Migrations
{
    /// <inheritdoc />
    public partial class AnnouncementCreatorAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnnouncementCreator",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnouncementCreator",
                table: "Announcements");
        }
    }
}
