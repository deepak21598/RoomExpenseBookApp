using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomExpenseBookApp.Entities.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Khatas_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    KhataId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseDetails_Khatas_KhataId",
                        column: x => x.KhataId,
                        principalTable: "Khatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseDetails_Users_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhataMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KhataId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhataMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhataMembers_Khatas_KhataId",
                        column: x => x.KhataId,
                        principalTable: "Khatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhataMembers_Users_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_KhataId",
                table: "ExpenseDetails",
                column: "KhataId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseDetails_MemberId",
                table: "ExpenseDetails",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_KhataMembers_KhataId",
                table: "KhataMembers",
                column: "KhataId");

            migrationBuilder.CreateIndex(
                name: "IX_KhataMembers_MemberId",
                table: "KhataMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Khatas_OwnerId",
                table: "Khatas",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseDetails");

            migrationBuilder.DropTable(
                name: "KhataMembers");

            migrationBuilder.DropTable(
                name: "Khatas");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
