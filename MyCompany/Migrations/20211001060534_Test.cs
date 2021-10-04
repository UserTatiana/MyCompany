using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "760d0abe-c81d-4d19-8480-8c0ce8ebdd79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f46c5a5c-2dfc-422e-b81c-38cb5b928f1a", "AQAAAAEAACcQAAAAEFZhzj0KfAtd/GMrxWHCJydvu1f+seaCFyWdkpOGfSqqo68o6W8KHpHA2C3iudFDMw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "85d7800e-16ab-4e79-bc2f-0a0568f36316");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5d123c3-c3c0-4ef7-9468-9e2031e6c7e6", "AQAAAAEAACcQAAAAEO1fPmjNrhCSWvQYlq+232hBeiNi2Mkvop7YHRp/12BxQmvseXzqE+BSOa2/IG9l6g==" });
        }
    }
}
