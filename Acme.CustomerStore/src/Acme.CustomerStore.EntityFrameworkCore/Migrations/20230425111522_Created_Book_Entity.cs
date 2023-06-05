using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.CustomerStore.Migrations
{
    /// <inheritdoc />
    public partial class CreatedBookEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Address",
                columns: table => new
                {
                    CustomerAdressId = table.Column<int>(name: "Customer_Adress_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeAdress = table.Column<string>(name: "Home_Adress", type: "nvarchar(max)", nullable: false),
                    WorkAddress = table.Column<string>(name: "Work_Address", type: "nvarchar(max)", nullable: false),
                    FamilyAdress = table.Column<string>(name: "Family_Adress", type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Address", x => x.CustomerAdressId);
                });

            migrationBuilder.CreateTable(
                name: "customer_contact",
                columns: table => new
                {
                    CustomerContactId = table.Column<int>(name: "Customer_Contact_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_contact", x => x.CustomerContactId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Spending",
                columns: table => new
                {
                    spendingId = table.Column<int>(name: "spending_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Spending", x => x.spendingId);
                });

            migrationBuilder.CreateTable(
                name: "AppYourEntities",
                columns: table => new
                {
                    CustomerId = table.Column<int>(name: "Customer_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TC = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerAdressId = table.Column<int>(name: "Customer_Adress_Id", type: "int", nullable: false),
                    CustomerContactId = table.Column<int>(name: "Customer_Contact_Id", type: "int", nullable: false),
                    CustomerContactId1 = table.Column<int>(name: "Customer_Contact_Id1", type: "int", nullable: false),
                    spendingId = table.Column<int>(name: "spending_Id", type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppYourEntities", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_AppYourEntities_Customer_Address_Customer_Adress_Id",
                        column: x => x.CustomerAdressId,
                        principalTable: "Customer_Address",
                        principalColumn: "Customer_Adress_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppYourEntities_Customer_Spending_spending_Id",
                        column: x => x.spendingId,
                        principalTable: "Customer_Spending",
                        principalColumn: "spending_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppYourEntities_customer_contact_Customer_Contact_Id1",
                        column: x => x.CustomerContactId1,
                        principalTable: "customer_contact",
                        principalColumn: "Customer_Contact_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppYourEntities_Customer_Adress_Id",
                table: "AppYourEntities",
                column: "Customer_Adress_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppYourEntities_Customer_Contact_Id1",
                table: "AppYourEntities",
                column: "Customer_Contact_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_AppYourEntities_spending_Id",
                table: "AppYourEntities",
                column: "spending_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppYourEntities");

            migrationBuilder.DropTable(
                name: "Customer_Address");

            migrationBuilder.DropTable(
                name: "Customer_Spending");

            migrationBuilder.DropTable(
                name: "customer_contact");
        }
    }
}
