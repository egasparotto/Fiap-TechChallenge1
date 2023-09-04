using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiapBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class postscategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POSTSCATEGORIES",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTSCATEGORIES", x => new { x.CategoriesId, x.PostId });
                    table.ForeignKey(
                        name: "FK_POSTSCATEGORIES_CATEGORIES_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "CATEGORIES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_POSTSCATEGORIES_POSTS_PostId",
                        column: x => x.PostId,
                        principalTable: "POSTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_POSTSCATEGORIES_PostId",
                table: "POSTSCATEGORIES",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSTSCATEGORIES");
        }
    }
}
