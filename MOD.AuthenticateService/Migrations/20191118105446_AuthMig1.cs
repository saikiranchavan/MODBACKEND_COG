using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.AuthenticateService.Migrations
{
    public partial class AuthMig1 : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
