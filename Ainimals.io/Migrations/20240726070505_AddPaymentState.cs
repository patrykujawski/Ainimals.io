using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ainimals.io.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStateId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PaymentState",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentState", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentStateId",
                table: "Orders",
                column: "PaymentStateId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentState_PaymentStateId",
                table: "Orders",
                column: "PaymentStateId",
                principalTable: "PaymentState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentState_PaymentStateId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentState");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentStateId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaymentStateId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
