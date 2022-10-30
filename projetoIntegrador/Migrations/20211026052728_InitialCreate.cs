using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projetoIntegrador.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CARTEIRAS",
                columns: table => new
                {
                    IDCART_CART = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMCART_CART = table.Column<string>(maxLength: 200, nullable: true),
                    DTCAD_CART = table.Column<DateTime>(nullable: false),
                    ATIVO_CART = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARTEIRAS", x => x.IDCART_CART);
                });

            migrationBuilder.CreateTable(
                name: "TB_DOCUMETO",
                columns: table => new
                {
                    IDDOC_DOC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESC_DOC = table.Column<string>(maxLength: 100, nullable: false),
                    DTINI_DOC = table.Column<DateTime>(nullable: false),
                    STATUS_DOC = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DOCUMETO", x => x.IDDOC_DOC);
                });

            migrationBuilder.CreateTable(
                name: "TB_NIVEIS",
                columns: table => new
                {
                    IDNIV_NIV = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESNIV_NIV = table.Column<string>(maxLength: 200, nullable: true),
                    DTCAD = table.Column<DateTime>(nullable: false),
                    ATIVO_NIVEL = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NIVEIS", x => x.IDNIV_NIV);
                });

            migrationBuilder.CreateTable(
                name: "TB_PAIS",
                columns: table => new
                {
                    IDPAI_PAI = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_PAI = table.Column<string>(maxLength: 100, nullable: false),
                    DDI_PAI = table.Column<string>(maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PAIS", x => x.IDPAI_PAI);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOCONTA",
                columns: table => new
                {
                    IDTPC_TPC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESC_TPC = table.Column<string>(maxLength: 200, nullable: true),
                    DTINI_TPC = table.Column<DateTime>(nullable: false),
                    STATUS_TPC = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPOCONTA", x => x.IDTPC_TPC);
                });

            migrationBuilder.CreateTable(
                name: "TB_NIVEISCARTEIRA",
                columns: table => new
                {
                    IDNIVCART_NIVCART = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNIV_NIVCART = table.Column<int>(nullable: false),
                    IDCART_NIVCART = table.Column<int>(nullable: false),
                    DTCAD_NIVCART = table.Column<DateTime>(nullable: false),
                    ATIVO_NIVCART = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NIVEISCARTEIRA", x => x.IDNIVCART_NIVCART);
                    table.ForeignKey(
                        name: "FK_TB_NIVEISCARTEIRA_TB_CARTEIRAS_IDCART_NIVCART",
                        column: x => x.IDCART_NIVCART,
                        principalTable: "TB_CARTEIRAS",
                        principalColumn: "IDCART_CART",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_NIVEISCARTEIRA_TB_NIVEIS_IDNIV_NIVCART",
                        column: x => x.IDNIV_NIVCART,
                        principalTable: "TB_NIVEIS",
                        principalColumn: "IDNIV_NIV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ESTADO",
                columns: table => new
                {
                    IDEST_EST = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_EST = table.Column<string>(maxLength: 100, nullable: false),
                    DDD_EST = table.Column<string>(maxLength: 4, nullable: true),
                    IDPAI_EST = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ESTADO", x => x.IDEST_EST);
                    table.ForeignKey(
                        name: "FK_TB_ESTADO_TB_PAIS_IDPAI_EST",
                        column: x => x.IDPAI_EST,
                        principalTable: "TB_PAIS",
                        principalColumn: "IDPAI_PAI",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CONTA",
                columns: table => new
                {
                    IDCON_CON = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTIP_CON = table.Column<int>(nullable: false),
                    NUM_CON = table.Column<int>(nullable: false),
                    NUMAG_CON = table.Column<int>(nullable: false),
                    VALSAL_CON = table.Column<long>(nullable: false),
                    SENHA_CON = table.Column<string>(nullable: true),
                    DTINI_CON = table.Column<DateTime>(nullable: false),
                    DTMOD_CON = table.Column<DateTime>(nullable: false),
                    DTFIM_CON = table.Column<DateTime>(nullable: false),
                    STATUS_CON = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTA", x => x.IDCON_CON);
                    table.ForeignKey(
                        name: "FK_TB_CONTA_TB_TIPOCONTA_IDTIP_CON",
                        column: x => x.IDTIP_CON,
                        principalTable: "TB_TIPOCONTA",
                        principalColumn: "IDTPC_TPC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_LOCAL",
                columns: table => new
                {
                    IDLOC_LOC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUA_LOC = table.Column<string>(maxLength: 100, nullable: false),
                    CEP_LOC = table.Column<int>(nullable: false),
                    IDEST_LOC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LOCAL", x => x.IDLOC_LOC);
                    table.ForeignKey(
                        name: "FK_TB_LOCAL_TB_ESTADO_IDEST_LOC",
                        column: x => x.IDEST_LOC,
                        principalTable: "TB_ESTADO",
                        principalColumn: "IDEST_EST",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    IDCLI_CLI = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME_CLI = table.Column<string>(maxLength: 300, nullable: true),
                    IDDOC_CLI = table.Column<int>(nullable: false),
                    IDCONT_CLI = table.Column<int>(nullable: false),
                    DESDOC_CLI = table.Column<string>(maxLength: 20, nullable: true),
                    DTNAS_CLI = table.Column<DateTime>(nullable: false),
                    NOMMAE_CLI = table.Column<string>(maxLength: 200, nullable: true),
                    TEL_CLI = table.Column<string>(maxLength: 15, nullable: true),
                    EMAIL_CLI = table.Column<string>(maxLength: 200, nullable: true),
                    IDLOC_CLI = table.Column<int>(nullable: false),
                    COMP_CLI = table.Column<string>(maxLength: 100, nullable: true),
                    NUM_CLI = table.Column<int>(nullable: false),
                    STATUS_CLI = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.IDCLI_CLI);
                    table.ForeignKey(
                        name: "FK_TB_CLIENTE_TB_CONTA_IDCONT_CLI",
                        column: x => x.IDCONT_CLI,
                        principalTable: "TB_CONTA",
                        principalColumn: "IDCON_CON",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_CLIENTE_TB_DOCUMETO_IDDOC_CLI",
                        column: x => x.IDDOC_CLI,
                        principalTable: "TB_DOCUMETO",
                        principalColumn: "IDDOC_DOC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_CLIENTE_TB_LOCAL_IDLOC_CLI",
                        column: x => x.IDLOC_CLI,
                        principalTable: "TB_LOCAL",
                        principalColumn: "IDLOC_LOC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    IDUSU_USU = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNIV_USU = table.Column<int>(nullable: false),
                    IDCLI_USU = table.Column<int>(nullable: false),
                    LOGIN_USU = table.Column<string>(maxLength: 200, nullable: false),
                    SENHA_USU = table.Column<string>(maxLength: 200, nullable: false),
                    ATIVO_USU = table.Column<bool>(nullable: false),
                    DTCAD_USU = table.Column<DateTime>(nullable: false),
                    LOGADO_USU = table.Column<bool>(nullable: false),
                    HORAINI_USU = table.Column<DateTime>(nullable: false),
                    HORAFIM_USU = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.IDUSU_USU);
                    table.ForeignKey(
                        name: "FK_TB_USUARIO_TB_CLIENTE_IDCLI_USU",
                        column: x => x.IDCLI_USU,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "IDCLI_CLI",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_USUARIO_TB_NIVEIS_IDNIV_USU",
                        column: x => x.IDNIV_USU,
                        principalTable: "TB_NIVEIS",
                        principalColumn: "IDNIV_NIV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_SECTION",
                columns: table => new
                {
                    IDSEC_SEC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KEYSEC_SEC = table.Column<string>(nullable: true),
                    IDSUS_SUS = table.Column<int>(nullable: false),
                    DTCAD_SEC = table.Column<DateTime>(nullable: false),
                    ATIVO_SEC = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_SECTION", x => x.IDSEC_SEC);
                    table.ForeignKey(
                        name: "FK_TB_SECTION_TB_USUARIO_IDSUS_SUS",
                        column: x => x.IDSUS_SUS,
                        principalTable: "TB_USUARIO",
                        principalColumn: "IDUSU_USU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_LOGUSU",
                columns: table => new
                {
                    IDLOG_LOGUSU = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSEC_LOGUSU = table.Column<int>(nullable: false),
                    DESCLOG_LOGUSU = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LOGUSU", x => x.IDLOG_LOGUSU);
                    table.ForeignKey(
                        name: "FK_TB_LOGUSU_TB_SECTION_IDSEC_LOGUSU",
                        column: x => x.IDSEC_LOGUSU,
                        principalTable: "TB_SECTION",
                        principalColumn: "IDSEC_SEC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_IDCONT_CLI",
                table: "TB_CLIENTE",
                column: "IDCONT_CLI");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_IDDOC_CLI",
                table: "TB_CLIENTE",
                column: "IDDOC_CLI");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_IDLOC_CLI",
                table: "TB_CLIENTE",
                column: "IDLOC_CLI");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTA_IDTIP_CON",
                table: "TB_CONTA",
                column: "IDTIP_CON");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ESTADO_IDPAI_EST",
                table: "TB_ESTADO",
                column: "IDPAI_EST");

            migrationBuilder.CreateIndex(
                name: "IX_TB_LOCAL_IDEST_LOC",
                table: "TB_LOCAL",
                column: "IDEST_LOC");

            migrationBuilder.CreateIndex(
                name: "IX_TB_LOGUSU_IDSEC_LOGUSU",
                table: "TB_LOGUSU",
                column: "IDSEC_LOGUSU");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NIVEISCARTEIRA_IDCART_NIVCART",
                table: "TB_NIVEISCARTEIRA",
                column: "IDCART_NIVCART");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NIVEISCARTEIRA_IDNIV_NIVCART",
                table: "TB_NIVEISCARTEIRA",
                column: "IDNIV_NIVCART");

            migrationBuilder.CreateIndex(
                name: "IX_TB_SECTION_IDSUS_SUS",
                table: "TB_SECTION",
                column: "IDSUS_SUS");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_IDCLI_USU",
                table: "TB_USUARIO",
                column: "IDCLI_USU");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_IDNIV_USU",
                table: "TB_USUARIO",
                column: "IDNIV_USU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LOGUSU");

            migrationBuilder.DropTable(
                name: "TB_NIVEISCARTEIRA");

            migrationBuilder.DropTable(
                name: "TB_SECTION");

            migrationBuilder.DropTable(
                name: "TB_CARTEIRAS");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_NIVEIS");

            migrationBuilder.DropTable(
                name: "TB_CONTA");

            migrationBuilder.DropTable(
                name: "TB_DOCUMETO");

            migrationBuilder.DropTable(
                name: "TB_LOCAL");

            migrationBuilder.DropTable(
                name: "TB_TIPOCONTA");

            migrationBuilder.DropTable(
                name: "TB_ESTADO");

            migrationBuilder.DropTable(
                name: "TB_PAIS");
        }
    }
}
