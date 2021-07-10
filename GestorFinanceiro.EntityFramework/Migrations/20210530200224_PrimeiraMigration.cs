using System;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestorFinanceiro.EntityFramework.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Apelido = table.Column<string>(maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(maxLength: 150, nullable: true),
                    Celular = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PessoaId = table.Column<Guid>(nullable: false),
                    LimiteCredito = table.Column<decimal>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false, defaultValue: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PessoaId = table.Column<Guid>(nullable: false),
                    Salario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FuncionarioId = table.Column<Guid>(nullable: false),
                    Login = table.Column<string>(maxLength: 100, nullable: false),
                    Senha = table.Column<string>(maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PessoaId",
                table: "Cliente",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_PessoaId",
                table: "Funcionario",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_UsuarioId",
                table: "Lancamento",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_FuncionarioId",
                table: "Usuario",
                column: "FuncionarioId");

            var _passwordHasher = new PasswordHasher();
            string senha = _passwordHasher.HashPassword("123456");

            migrationBuilder.InsertData("Pessoa", new string[] { "Id", "Nome", "Apelido" }, new object[] { Guid.Empty, "SISTEMA", "SISTEMA" });
            migrationBuilder.InsertData("Funcionario", new string[] { "Id", "PessoaId", "Salario" }, new object[] { Guid.Empty, Guid.Empty, 0 });
            migrationBuilder.InsertData("Usuario", new string[] { "Id", "FuncionarioId", "Login", "Senha" }, new object[] { Guid.Empty, Guid.Empty, "SISTEMA", senha });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Lancamento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
