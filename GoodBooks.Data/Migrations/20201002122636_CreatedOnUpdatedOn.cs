using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodBooks.Data.Migrations
{
    public partial class CreatedOnUpdatedOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksReviews_Books_BookId",
                table: "BooksReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksReviews",
                table: "BooksReviews");

            migrationBuilder.DropColumn(
                name: "CreateOn",
                table: "BooksReviews");

            migrationBuilder.RenameTable(
                name: "BooksReviews",
                newName: "BookReviews");

            migrationBuilder.RenameIndex(
                name: "IX_BooksReviews_BookId",
                table: "BookReviews",
                newName: "IX_BookReviews_BookId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "BookReviews",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookReviews",
                table: "BookReviews",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookReviews",
                table: "BookReviews");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BookReviews");

            migrationBuilder.RenameTable(
                name: "BookReviews",
                newName: "BooksReviews");

            migrationBuilder.RenameIndex(
                name: "IX_BookReviews_BookId",
                table: "BooksReviews",
                newName: "IX_BooksReviews_BookId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateOn",
                table: "BooksReviews",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksReviews",
                table: "BooksReviews",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksReviews_Books_BookId",
                table: "BooksReviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
