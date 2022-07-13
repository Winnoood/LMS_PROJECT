using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_PROJECT.Migrations
{
    public partial class Team6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpPswd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpMobile = table.Column<long>(type: "bigint", nullable: false),
                    EmpDoj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpDept = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
