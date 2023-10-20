using FiapBlog.Domain.Utils.Cryptography;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiapBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("USERS",
                new string[]
                {
                    "Name",
                    "Username",
                    "Password",
                    "Type"
                },
                new object[]
                {
                    "Administrator",
                    "Admin",
                    PasswordCryptography.Encrypt("Admin"),
                    1
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM USERS WHERE USERNAME = 'Admin'");
        }
    }
}
