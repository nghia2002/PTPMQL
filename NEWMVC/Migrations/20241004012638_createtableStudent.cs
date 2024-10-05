using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NEWMVC.Migrations
{
    /// <inheritdoc />
    public partial class createtableStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "studentID",
                table: "Person",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "studentID",
                table: "Person");
        }
    }
}
