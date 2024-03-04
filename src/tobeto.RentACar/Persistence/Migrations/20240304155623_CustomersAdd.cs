using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CustomersAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvidualCustomers_Customers_CustomerId",
                table: "InvidualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvidualCustomers",
                table: "InvidualCustomers");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("417eb593-cd39-4357-af64-f9719cbe624c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e1d412e-8e9b-468c-9f20-77b5c35efe63"));

            migrationBuilder.RenameTable(
                name: "InvidualCustomers",
                newName: "IndividualCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_InvidualCustomers_CustomerId",
                table: "IndividualCustomers",
                newName: "IX_IndividualCustomers_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndividualCustomers",
                table: "IndividualCustomers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Customers.Admin", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Customers.Read", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Customers.Write", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Customers.Create", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Customers.Update", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Customers.Delete", null },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CorporateCustomers.Admin", null },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CorporateCustomers.Read", null },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CorporateCustomers.Write", null },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CorporateCustomers.Create", null },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CorporateCustomers.Update", null },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CorporateCustomers.Delete", null },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IndividualCustomers.Admin", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IndividualCustomers.Read", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IndividualCustomers.Write", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IndividualCustomers.Create", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IndividualCustomers.Update", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IndividualCustomers.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("eb5adabf-3b26-40d0-bdc8-3fe15ec064fb"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 163, 160, 248, 90, 118, 253, 244, 120, 39, 42, 214, 112, 47, 203, 15, 37, 209, 35, 96, 83, 242, 247, 131, 73, 178, 41, 213, 189, 32, 80, 206, 155, 205, 2, 178, 1, 213, 6, 220, 69, 230, 128, 22, 31, 127, 9, 7, 186, 189, 85, 156, 61, 109, 108, 15, 142, 197, 111, 151, 1, 165, 109, 88, 93 }, new byte[] { 141, 150, 100, 78, 28, 103, 237, 66, 133, 10, 188, 110, 226, 59, 161, 239, 14, 250, 228, 231, 196, 126, 212, 51, 79, 222, 122, 120, 219, 43, 199, 204, 200, 254, 107, 11, 114, 126, 14, 150, 239, 27, 120, 219, 124, 82, 59, 7, 8, 36, 210, 216, 234, 202, 148, 121, 57, 141, 224, 143, 81, 34, 85, 192, 237, 56, 13, 30, 254, 35, 56, 136, 203, 213, 86, 95, 242, 230, 39, 151, 111, 162, 210, 25, 255, 54, 199, 190, 163, 156, 123, 203, 132, 2, 113, 247, 185, 77, 231, 196, 45, 130, 17, 12, 33, 140, 88, 130, 67, 176, 152, 54, 27, 247, 240, 255, 202, 29, 32, 4, 185, 65, 188, 74, 193, 75, 48, 39 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("02f089fe-09ea-4fc0-9e93-57b95415eee2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("eb5adabf-3b26-40d0-bdc8-3fe15ec064fb") });

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IndividualCustomers",
                table: "IndividualCustomers");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("02f089fe-09ea-4fc0-9e93-57b95415eee2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb5adabf-3b26-40d0-bdc8-3fe15ec064fb"));

            migrationBuilder.RenameTable(
                name: "IndividualCustomers",
                newName: "InvidualCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_IndividualCustomers_CustomerId",
                table: "InvidualCustomers",
                newName: "IX_InvidualCustomers_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvidualCustomers",
                table: "InvidualCustomers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("7e1d412e-8e9b-468c-9f20-77b5c35efe63"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 236, 254, 52, 238, 253, 214, 16, 48, 195, 29, 235, 32, 147, 15, 214, 187, 211, 175, 61, 144, 235, 123, 65, 201, 217, 53, 150, 40, 18, 228, 212, 52, 97, 11, 105, 241, 153, 140, 245, 12, 33, 140, 215, 188, 86, 96, 83, 251, 166, 206, 100, 250, 74, 13, 239, 206, 198, 140, 212, 219, 117, 41, 235, 172 }, new byte[] { 157, 72, 59, 238, 124, 208, 255, 212, 201, 19, 86, 105, 37, 20, 160, 24, 249, 144, 255, 125, 165, 139, 86, 9, 183, 244, 165, 186, 186, 96, 222, 100, 33, 63, 28, 90, 251, 24, 104, 14, 122, 242, 35, 108, 91, 21, 72, 132, 4, 42, 2, 175, 36, 55, 100, 97, 92, 166, 78, 234, 84, 234, 105, 36, 122, 201, 221, 29, 115, 3, 76, 134, 18, 85, 119, 121, 135, 228, 105, 145, 100, 189, 183, 75, 218, 241, 164, 139, 151, 53, 50, 211, 76, 227, 198, 227, 97, 75, 113, 67, 54, 157, 185, 30, 60, 135, 9, 147, 37, 44, 250, 87, 130, 223, 62, 4, 92, 32, 158, 235, 220, 23, 173, 31, 255, 110, 141, 207 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("417eb593-cd39-4357-af64-f9719cbe624c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("7e1d412e-8e9b-468c-9f20-77b5c35efe63") });

            migrationBuilder.AddForeignKey(
                name: "FK_InvidualCustomers_Customers_CustomerId",
                table: "InvidualCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
