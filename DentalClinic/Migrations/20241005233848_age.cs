using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.Migrations
{
    /// <inheritdoc />
    public partial class age : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            

            

            

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branchs_AspNetUsers_UserId",
                table: "Branchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Branchs_UserId",
                table: "Branchs");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Branchs");
        }
    }
}
