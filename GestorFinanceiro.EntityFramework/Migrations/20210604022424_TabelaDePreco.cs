using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorFinanceiro.EntityFramework.Migrations
{
    public partial class TabelaDePreco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaPreco",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    LancamentoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaPreco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelaPreco_Lancamento_LancamentoId",
                        column: x => x.LancamentoId,
                        principalTable: "Lancamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelaPreco_LancamentoId",
                table: "TabelaPreco",
                column: "LancamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaPreco");
        }
    }
}
