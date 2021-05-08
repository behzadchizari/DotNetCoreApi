using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastLoginDate",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTimeOffset));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastLoginDate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);
        }
    }
}
