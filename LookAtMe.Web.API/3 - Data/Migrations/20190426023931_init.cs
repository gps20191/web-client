using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LookAtMe.Web.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suspeito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Foto = table.Column<byte[]>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspeito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alerta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataOcorrencia = table.Column<DateTime>(nullable: false),
                    HoraOcorrencia = table.Column<TimeSpan>(nullable: false),
                    LinhaTranscol = table.Column<int>(nullable: false),
                    Localizacao = table.Column<string>(maxLength: 100, nullable: false),
                    SuspeitoId = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(maxLength: 15, nullable: false),
                    Capturado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alerta_Suspeito_SuspeitoId",
                        column: x => x.SuspeitoId,
                        principalTable: "Suspeito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegistro = table.Column<DateTime>(nullable: false),
                    HoraRegistro = table.Column<TimeSpan>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    SuspeitoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocorrencia_Suspeito_SuspeitoId",
                        column: x => x.SuspeitoId,
                        principalTable: "Suspeito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alerta_SuspeitoId",
                table: "Alerta",
                column: "SuspeitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_SuspeitoId",
                table: "Ocorrencia",
                column: "SuspeitoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerta");

            migrationBuilder.DropTable(
                name: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Suspeito");
        }
    }
}
