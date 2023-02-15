﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProject02.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnnouncementBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementCommentCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnnouncementCommentBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnouncementComments_Announcements_AnnouncementModelId",
                        column: x => x.AnnouncementModelId,
                        principalTable: "Announcements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementComments_AnnouncementModelId",
                table: "AnnouncementComments",
                column: "AnnouncementModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnouncementComments");

            migrationBuilder.DropTable(
                name: "Announcements");
        }
    }
}
