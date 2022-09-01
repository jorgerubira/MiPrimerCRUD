using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiPrimerCRUD.Migrations
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Cursos_CursilloId",
                table: "Asignaturas");

            migrationBuilder.RenameColumn(
                name: "CursilloId",
                table: "Asignaturas",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignaturas_CursilloId",
                table: "Asignaturas",
                newName: "IX_Asignaturas_CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Cursos_CursoId",
                table: "Asignaturas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Cursos_CursoId",
                table: "Asignaturas");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Asignaturas",
                newName: "CursilloId");

            migrationBuilder.RenameIndex(
                name: "IX_Asignaturas_CursoId",
                table: "Asignaturas",
                newName: "IX_Asignaturas_CursilloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Cursos_CursilloId",
                table: "Asignaturas",
                column: "CursilloId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }
    }
}
