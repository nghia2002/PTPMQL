using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NEWMVC.Migrations
{
    /// <inheritdoc />
    public partial class TablePerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Person",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<sbyte>(
                name: "Address",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
