using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LookAtMe.Web.API.Migrations
{
    public partial class Changed_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alerta_Suspeito_SuspeitoId",
                table: "Alerta");

            migrationBuilder.DropTable(
                name: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Suspeito");

            migrationBuilder.DropIndex(
                name: "IX_Alerta_SuspeitoId",
                table: "Alerta");

            migrationBuilder.DropColumn(
                name: "HoraOcorrencia",
                table: "Alerta");

            migrationBuilder.DropColumn(
                name: "Localizacao",
                table: "Alerta");

            migrationBuilder.RenameColumn(
                name: "LinhaTranscol",
                table: "Alerta",
                newName: "NumeroOnibus");

            migrationBuilder.RenameColumn(
                name: "DataOcorrencia",
                table: "Alerta",
                newName: "DataHoraRegistro");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Alerta",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Alerta",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Alerta",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "UrlFoto",
                table: "Alerta",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Alerta");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Alerta");

            migrationBuilder.DropColumn(
                name: "UrlFoto",
                table: "Alerta");

            migrationBuilder.RenameColumn(
                name: "NumeroOnibus",
                table: "Alerta",
                newName: "LinhaTranscol");

            migrationBuilder.RenameColumn(
                name: "DataHoraRegistro",
                table: "Alerta",
                newName: "DataOcorrencia");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Alerta",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraOcorrencia",
                table: "Alerta",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Localizacao",
                table: "Alerta",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Suspeito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Foto = table.Column<byte[]>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspeito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegistro = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    HoraRegistro = table.Column<TimeSpan>(nullable: false),
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

            migrationBuilder.AddForeignKey(
                name: "FK_Alerta_Suspeito_SuspeitoId",
                table: "Alerta",
                column: "SuspeitoId",
                principalTable: "Suspeito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
