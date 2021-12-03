using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamApp.Data.Migrations
{
    public partial class ModelRelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 12, 3, 19, 54, 38, 840, DateTimeKind.Local).AddTicks(1437), new DateTime(2021, 12, 3, 19, 54, 38, 840, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExamId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 12, 3, 18, 31, 47, 732, DateTimeKind.Local).AddTicks(9767), new DateTime(2021, 12, 3, 18, 31, 47, 733, DateTimeKind.Local).AddTicks(6082) });
        }
    }
}
