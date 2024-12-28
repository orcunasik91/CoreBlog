using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreBlog.DataAccess.Migrations
{
    public partial class EditedTitleColumnAsEmailColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Comments",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Comments",
                newName: "Title");
        }
    }
}
