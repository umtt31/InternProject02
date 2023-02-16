using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProject02.Migrations
{
    /// <inheritdoc />
    public partial class RelationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                table: "AnnouncementComments");

            migrationBuilder.AlterColumn<int>(
                name: "AnnouncementModelId",
                table: "AnnouncementComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                table: "AnnouncementComments",
                column: "AnnouncementModelId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                table: "AnnouncementComments");

            migrationBuilder.AlterColumn<int>(
                name: "AnnouncementModelId",
                table: "AnnouncementComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                table: "AnnouncementComments",
                column: "AnnouncementModelId",
                principalTable: "Announcements",
                principalColumn: "Id");
        }
    }
}
