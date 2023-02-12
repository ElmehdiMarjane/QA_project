using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QA_api.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Category", "Points", "QuestionText" },
                values: new object[] { 1, "categorie1", "1.jpg", 15, "ChaiseBoisMassif" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Category", "Points", "QuestionText" },
                values: new object[] { 2, "categorsie1", "1.jpg", 15, "ChaiseBoiscqsccsMassif" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "Category", "Points", "QuestionText" },
                values: new object[] { 3, "categossrie1", "1.jpg", 15, "scqscsq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);
        }
    }
}
