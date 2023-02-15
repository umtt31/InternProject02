using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProject02.Migrations
{
    /// <inheritdoc />
    public partial class AnnouncementModelSubjectPropertyNameChangedToAnnouncementSunject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Announcements",
                newName: "AnnouncementSubject");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnnouncementSubject",
                table: "Announcements",
                newName: "Subject");
        }
    }
}
