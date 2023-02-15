using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProject02.Migrations
{
    /// <inheritdoc />
    public partial class NotNullAbleCommentList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AnnouncementComments",
                newName: "AnnouncementCommentName");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                table: "AnnouncementComments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                table: "AnnouncementComments");

            migrationBuilder.RenameColumn(
                name: "AnnouncementCommentName",
                table: "AnnouncementComments",
                newName: "Name");
        }
    }
}
