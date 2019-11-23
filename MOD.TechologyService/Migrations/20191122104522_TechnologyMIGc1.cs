using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TechologyService.Migrations
{
    public partial class TechnologyMIGc1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    MentorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MentorName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(20)", nullable: false),
                    MentorPhoneNo = table.Column<long>(nullable: false),
                    StartTime = table.Column<int>(nullable: false),
                    EndTime = table.Column<int>(nullable: false),
                    experience = table.Column<int>(nullable: false),
                    MentorProfile = table.Column<string>(type: "varchar(1000)", nullable: false),
                    PrimaryTechnology = table.Column<string>(type: "varchar(30)", nullable: false),
                    LinkedIn = table.Column<string>(type: "varchar(40)", nullable: false),
                    Password = table.Column<string>(type: "varchar(40)", nullable: false),
                    MentorBlock = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.MentorID);
                });

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    TechID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnologyName = table.Column<string>(type: "varchar(30)", nullable: false),
                    TOC = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Fees = table.Column<double>(nullable: false),
                    duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.TechID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    UserEmail = table.Column<string>(nullable: false),
                    UserPhoneNo = table.Column<long>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserBlock = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UID = table.Column<int>(nullable: false),
                    MentorID = table.Column<int>(nullable: false),
                    TechnologyName = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<int>(nullable: false),
                    EndTime = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Progress = table.Column<int>(nullable: false),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainingID);
                    table.ForeignKey(
                        name: "FK_Training_Mentor_MentorID",
                        column: x => x.MentorID,
                        principalTable: "Mentor",
                        principalColumn: "MentorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_User_UID",
                        column: x => x.UID,
                        principalTable: "User",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UID = table.Column<int>(nullable: false),
                    MentorID = table.Column<int>(nullable: false),
                    TrainingID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Mentor_Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_MentorID",
                        column: x => x.MentorID,
                        principalTable: "Mentor",
                        principalColumn: "MentorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Training_TrainingID",
                        column: x => x.TrainingID,
                        principalTable: "Training",
                        principalColumn: "TrainingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_User_UID",
                        column: x => x.UID,
                        principalTable: "User",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_MentorID",
                table: "Payment",
                column: "MentorID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TrainingID",
                table: "Payment",
                column: "TrainingID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UID",
                table: "Payment",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorID",
                table: "Training",
                column: "MentorID");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UID",
                table: "Training",
                column: "UID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Technology");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
