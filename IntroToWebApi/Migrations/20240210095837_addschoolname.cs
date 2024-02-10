using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroToWebApi.Migrations
{
    /// <inheritdoc />
    public partial class addschoolname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchoolName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "'-'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolName",
                table: "Students");
        }
    }
}
