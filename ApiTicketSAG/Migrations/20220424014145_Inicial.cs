using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTicketSAG.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    codigoCliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    empresa = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.codigoCliente);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    idMensaje = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idTicket = table.Column<int>(type: "INTEGER", nullable: false),
                    fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Mensajes = table.Column<string>(type: "TEXT", nullable: false),
                    EnviadoPor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.idMensaje);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    idEncargado = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.idEncargado);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    idTicket = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    vence = table.Column<DateTime>(type: "TEXT", nullable: false),
                    idEncargado = table.Column<int>(type: "INTEGER", nullable: false),
                    Empresa = table.Column<string>(type: "TEXT", nullable: false),
                    solicitadoPor = table.Column<string>(type: "TEXT", nullable: false),
                    asunto = table.Column<string>(type: "TEXT", nullable: false),
                    especificaciones = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.idTicket);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
