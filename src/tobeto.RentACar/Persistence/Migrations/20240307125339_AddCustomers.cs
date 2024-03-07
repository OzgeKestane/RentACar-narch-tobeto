using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_InvidualCustomers_Customers_CustomerId",
                table: "InvidualCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserId",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "CorporateCustomers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "InvidualCustomers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "InvidualCustomers");

            migrationBuilder.RenameTable(
                name: "InvidualCustomers",
                newName: "IndividualCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_CorporateCustomers_CustomerId",
                table: "CorporateCustomers",
                newName: "CorporateCustomer_CustomerID_UK");

            migrationBuilder.RenameIndex(
                name: "IX_InvidualCustomers_CustomerId",
                table: "IndividualCustomers",
                newName: "IndividualCustomer_CustomerID_UK");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerNo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { new Guid("3fab908a-74f4-4c30-aad1-bfa27e349892"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 58, 71, 16, 216, 66, 55, 141, 188, 167, 3, 142, 132, 128, 138, 188, 107, 3, 157, 213, 111, 38, 172, 226, 194, 202, 99, 155, 198, 252, 114, 28, 63, 51, 134, 177, 92, 2, 89, 44, 99, 28, 139, 202, 74, 234, 151, 99, 74, 167, 109, 180, 118, 136, 244, 133, 171, 0, 45, 95, 207, 190, 29, 134, 219 }, new byte[] { 176, 244, 14, 181, 42, 113, 6, 38, 127, 4, 204, 103, 191, 90, 131, 107, 76, 229, 29, 232, 15, 150, 80, 106, 214, 88, 226, 118, 98, 122, 25, 131, 105, 53, 9, 129, 166, 60, 161, 70, 130, 167, 66, 174, 204, 10, 86, 8, 178, 23, 199, 171, 98, 13, 175, 131, 245, 103, 83, 46, 159, 121, 63, 42, 198, 189, 245, 42, 102, 127, 226, 43, 40, 55, 233, 253, 104, 135, 12, 128, 230, 88, 208, 225, 155, 48, 215, 163, 149, 32, 224, 250, 16, 200, 244, 39, 36, 86, 165, 169, 122, 133, 92, 0, 0, 158, 58, 38, 22, 142, 100, 214, 87, 236, 252, 167, 228, 131, 191, 97, 92, 139, 24, 77, 66, 69, 221, 209 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7d5070e7-a39b-4663-9c1c-a2fc0e750e5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3fab908a-74f4-4c30-aad1-bfa27e349892") });

            migrationBuilder.CreateIndex(
                name: "Customer_UserID_UK",
                table: "Customers",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Customers_Users_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Customers_CustomerId",
                table: "IndividualCustomers");

            migrationBuilder.DropIndex(
                name: "Customer_UserID_UK",
                table: "Customers");

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
                keyValue: new Guid("7d5070e7-a39b-4663-9c1c-a2fc0e750e5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fab908a-74f4-4c30-aad1-bfa27e349892"));

            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "IndividualCustomers",
                newName: "InvidualCustomers");

            migrationBuilder.RenameIndex(
                name: "CorporateCustomer_CustomerID_UK",
                table: "CorporateCustomers",
                newName: "IX_CorporateCustomers_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IndividualCustomer_CustomerID_UK",
                table: "InvidualCustomers",
                newName: "IX_InvidualCustomers_CustomerId");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "CorporateCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "InvidualCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "InvidualCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

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
