using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiPrimerCRUD.Migrations
{
    public partial class v14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Cursos_CursilloId",
                table: "Asignaturas");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Asignaturas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "CursilloId",
                table: "Asignaturas",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Cursos_CursilloId",
                table: "Asignaturas",
                column: "CursilloId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Cursos_CursilloId",
                table: "Asignaturas");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Asignaturas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CursilloId",
                table: "Asignaturas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Cursos_CursilloId",
                table: "Asignaturas",
                column: "CursilloId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
