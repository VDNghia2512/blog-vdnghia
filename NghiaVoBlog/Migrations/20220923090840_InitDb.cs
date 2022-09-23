using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NghiaVoBlog.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblTag",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTag",
                columns: table => new
                {
                    ArticlesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTag", x => new { x.ArticlesID, x.TagsID });
                    table.ForeignKey(
                        name: "FK_ArticleTag_TblTag_TagsID",
                        column: x => x.TagsID,
                        principalTable: "TblTag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblArticle",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblUser_tblArticle_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "tblArticle",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblCategory_tblUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "tblUser",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "tblComment",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblComment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblComment_tblArticle_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "tblArticle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblComment_tblUser_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "tblUser",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTag_TagsID",
                table: "ArticleTag",
                column: "TagsID");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticle_AuthorID",
                table: "tblArticle",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticle_CategoryID",
                table: "tblArticle",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCategory_CreatedById",
                table: "tblCategory",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_tblComment_ArticleID",
                table: "tblComment",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComment_AuthorID",
                table: "tblComment",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblUser_ArticleID",
                table: "tblUser",
                column: "ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_tblArticle_ArticlesID",
                table: "ArticleTag",
                column: "ArticlesID",
                principalTable: "tblArticle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblArticle_tblCategory_CategoryID",
                table: "tblArticle",
                column: "CategoryID",
                principalTable: "tblCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblArticle_tblUser_AuthorID",
                table: "tblArticle",
                column: "AuthorID",
                principalTable: "tblUser",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblUser_tblArticle_ArticleID",
                table: "tblUser");

            migrationBuilder.DropTable(
                name: "ArticleTag");

            migrationBuilder.DropTable(
                name: "tblComment");

            migrationBuilder.DropTable(
                name: "TblTag");

            migrationBuilder.DropTable(
                name: "tblArticle");

            migrationBuilder.DropTable(
                name: "tblCategory");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
