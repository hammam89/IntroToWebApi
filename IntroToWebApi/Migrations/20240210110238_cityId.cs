using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroToWebApi.Migrations
{
    /// <inheritdoc />
    public partial class cityId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CityId",
                table: "Students",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Cities_CityId",
                table: "Students",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Cities_CityId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Students");
        }
    }
}
