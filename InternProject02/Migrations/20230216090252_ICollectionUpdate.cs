using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProject02.Migrations
{
    /// <inheritdoc />
    public partial class ICollectionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                table: "AnnouncementComments");

            migrationBuilder.DropIndex(
                name: "IX_AnnouncementComments_AnnouncementModelId",
                table: "AnnouncementComments");

            migrationBuilder.DropColumn(
                name: "AnnouncementModelId",
                table: "AnnouncementComments");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementComments_AnnouncementId",
                table: "AnnouncementComments",
                column: "AnnouncementId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementId",
                table: "AnnouncementComments",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementId",
                table: "AnnouncementComments");

            migrationBuilder.DropIndex(
                name: "IX_AnnouncementComments_AnnouncementId",
                table: "AnnouncementComments");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncementModelId",
                table: "AnnouncementComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementComments_AnnouncementModelId",
                table: "AnnouncementComments",
                column: "AnnouncementModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                table: "AnnouncementComments",
                column: "AnnouncementModelId",
                principalTable: "Announcements",
                principalColumn: "Id");
        }
    }
}
