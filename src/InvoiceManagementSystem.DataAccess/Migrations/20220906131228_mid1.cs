using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvoiceManagementSystem.DataAccess.Migrations
{
    public partial class mid1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    TC = table.Column<string>(type: "text", nullable: false),
                    Plate = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlockID = table.Column<int>(type: "integer", nullable: false),
                    IsEmpty = table.Column<bool>(type: "boolean", nullable: false),
                    StyleID = table.Column<int>(type: "integer", nullable: false),
                    Floor = table.Column<int>(type: "integer", nullable: false),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Blocks_BlockID",
                        column: x => x.BlockID,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_Styles_StyleID",
                        column: x => x.StyleID,
                        principalTable: "Styles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardNumber = table.Column<int>(type: "integer", nullable: false),
                    CardPassword = table.Column<int>(type: "integer", nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    WrotenMessage = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Debts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    ApartmentID = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debts_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Debts_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    ApartmentID = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "A Block", null },
                    { 2, null, null, "B Block", null },
                    { 3, null, null, "C Block", null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "RoleName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "Admin", null },
                    { 2, null, null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "1+1", null },
                    { 2, null, null, "2+1", null },
                    { 3, null, null, "3+1", null },
                    { 4, null, null, "4+1", null },
                    { 5, null, null, "5+1", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Plate", "RoleId", "TC", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "asdfasd1@hotmail.com", "Ahmet", "Safak", new byte[] { 10, 139, 94, 235, 41, 218, 90, 36, 55, 160, 143, 160, 251, 124, 87, 79, 196, 202, 246, 18, 176, 251, 192, 73, 178, 199, 21, 174, 233, 92, 94, 33, 155, 46, 172, 127, 19, 78, 164, 34, 5, 173, 179, 85, 223, 23, 93, 47, 144, 26, 246, 198, 113, 228, 83, 129, 52, 72, 57, 244, 133, 154, 249, 200 }, new byte[] { 116, 6, 139, 142, 251, 55, 38, 132, 97, 132, 218, 194, 152, 110, 33, 71, 101, 137, 55, 33, 235, 220, 249, 113, 126, 73, 175, 92, 148, 49, 17, 203, 220, 121, 94, 36, 187, 210, 238, 228, 129, 163, 252, 55, 219, 189, 1, 154, 113, 60, 10, 32, 218, 173, 43, 111, 196, 250, 197, 147, 49, 8, 159, 129, 205, 78, 167, 0, 111, 193, 165, 113, 16, 47, 143, 73, 207, 214, 163, 29, 12, 149, 14, 27, 121, 25, 207, 250, 194, 52, 110, 193, 108, 80, 157, 186, 129, 57, 156, 96, 174, 113, 189, 190, 83, 215, 120, 247, 69, 241, 175, 142, 52, 243, 151, 69, 125, 75, 215, 68, 160, 26, 140, 16, 184, 45, 171, 87 }, "5320000000", "61 AC 61", 1, "11111111111", null },
                    { 2, null, null, "asdfasd2@hotmail.com", "Koc", "Soy", new byte[] { 10, 139, 94, 235, 41, 218, 90, 36, 55, 160, 143, 160, 251, 124, 87, 79, 196, 202, 246, 18, 176, 251, 192, 73, 178, 199, 21, 174, 233, 92, 94, 33, 155, 46, 172, 127, 19, 78, 164, 34, 5, 173, 179, 85, 223, 23, 93, 47, 144, 26, 246, 198, 113, 228, 83, 129, 52, 72, 57, 244, 133, 154, 249, 200 }, new byte[] { 116, 6, 139, 142, 251, 55, 38, 132, 97, 132, 218, 194, 152, 110, 33, 71, 101, 137, 55, 33, 235, 220, 249, 113, 126, 73, 175, 92, 148, 49, 17, 203, 220, 121, 94, 36, 187, 210, 238, 228, 129, 163, 252, 55, 219, 189, 1, 154, 113, 60, 10, 32, 218, 173, 43, 111, 196, 250, 197, 147, 49, 8, 159, 129, 205, 78, 167, 0, 111, 193, 165, 113, 16, 47, 143, 73, 207, 214, 163, 29, 12, 149, 14, 27, 121, 25, 207, 250, 194, 52, 110, 193, 108, 80, 157, 186, 129, 57, 156, 96, 174, 113, 189, 190, 83, 215, 120, 247, 69, 241, 175, 142, 52, 243, 151, 69, 125, 75, 215, 68, 160, 26, 140, 16, 184, 45, 171, 87 }, "5320000001", "61 AC 62", 2, "11111111112", null },
                    { 3, null, null, "asdfasd3@hotmail.com", "Zafer", "Kara", new byte[] { 10, 139, 94, 235, 41, 218, 90, 36, 55, 160, 143, 160, 251, 124, 87, 79, 196, 202, 246, 18, 176, 251, 192, 73, 178, 199, 21, 174, 233, 92, 94, 33, 155, 46, 172, 127, 19, 78, 164, 34, 5, 173, 179, 85, 223, 23, 93, 47, 144, 26, 246, 198, 113, 228, 83, 129, 52, 72, 57, 244, 133, 154, 249, 200 }, new byte[] { 116, 6, 139, 142, 251, 55, 38, 132, 97, 132, 218, 194, 152, 110, 33, 71, 101, 137, 55, 33, 235, 220, 249, 113, 126, 73, 175, 92, 148, 49, 17, 203, 220, 121, 94, 36, 187, 210, 238, 228, 129, 163, 252, 55, 219, 189, 1, 154, 113, 60, 10, 32, 218, 173, 43, 111, 196, 250, 197, 147, 49, 8, 159, 129, 205, 78, 167, 0, 111, 193, 165, 113, 16, 47, 143, 73, 207, 214, 163, 29, 12, 149, 14, 27, 121, 25, 207, 250, 194, 52, 110, 193, 108, 80, 157, 186, 129, 57, 156, 96, 174, 113, 189, 190, 83, 215, 120, 247, 69, 241, 175, 142, 52, 243, 151, 69, 125, 75, 215, 68, 160, 26, 140, 16, 184, 45, 171, 87 }, "5320000002", "61 AC 63", 2, "11111111113", null }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "BlockID", "CreateDate", "CustomerID", "DeletedDate", "Floor", "IsEmpty", "StyleID", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, null, 1, null, 18, true, 1, null },
                    { 2, 2, null, 2, null, 19, true, 2, null },
                    { 3, 3, null, 3, null, 20, true, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Balance", "CardNumber", "CardPassword", "CreateDate", "CustomerID", "DeletedDate", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 3000, 11223344, 1234, null, 1, null, null },
                    { 2, 4000, 11112222, 4321, null, 2, null, null },
                    { 3, 5000, 33334444, 1221, null, 3, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BlockID",
                table: "Apartments",
                column: "BlockID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_CustomerID",
                table: "Apartments",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_StyleID",
                table: "Apartments",
                column: "StyleID");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CustomerID",
                table: "Cards",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Debts_ApartmentID",
                table: "Debts",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Debts_CustomerID",
                table: "Debts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CustomerID",
                table: "Messages",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ApartmentID",
                table: "Payments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerID",
                table: "Payments",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Debts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
