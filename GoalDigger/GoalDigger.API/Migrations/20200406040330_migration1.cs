using Microsoft.EntityFrameworkCore.Migrations;

namespace GoalDigger.API.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HashtagPosts",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HashtagPosts", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HashtagPostuid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtags", x => x.uid);
                    table.ForeignKey(
                        name: "FK_Hashtags_HashtagPosts_HashtagPostuid",
                        column: x => x.HashtagPostuid,
                        principalTable: "HashtagPosts",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Useruid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.uid);
                    table.ForeignKey(
                        name: "FK_Goals_Users_Useruid",
                        column: x => x.Useruid,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Useruid = table.Column<long>(nullable: true),
                    HashtagPostuid = table.Column<long>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.uid);
                    table.ForeignKey(
                        name: "FK_Posts_HashtagPosts_HashtagPostuid",
                        column: x => x.HashtagPostuid,
                        principalTable: "HashtagPosts",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Users_Useruid",
                        column: x => x.Useruid,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mentions",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Useruid = table.Column<long>(nullable: true),
                    Postuid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentions", x => x.uid);
                    table.ForeignKey(
                        name: "FK_Mentions_Posts_Postuid",
                        column: x => x.Postuid,
                        principalTable: "Posts",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mentions_Users_Useruid",
                        column: x => x.Useruid,
                        principalTable: "Users",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "uid", "Body", "HashtagPostuid", "Useruid" },
                values: new object[] { 1L, "My first #goal !!!", null, null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "uid", "Body", "HashtagPostuid", "Useruid" },
                values: new object[] { 2L, "My second #goal !!!", null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "uid", "UserName" },
                values: new object[] { 1L, "Alex1234" });

            migrationBuilder.CreateIndex(
                name: "IX_Goals_Useruid",
                table: "Goals",
                column: "Useruid");

            migrationBuilder.CreateIndex(
                name: "IX_Hashtags_HashtagPostuid",
                table: "Hashtags",
                column: "HashtagPostuid");

            migrationBuilder.CreateIndex(
                name: "IX_Mentions_Postuid",
                table: "Mentions",
                column: "Postuid");

            migrationBuilder.CreateIndex(
                name: "IX_Mentions_Useruid",
                table: "Mentions",
                column: "Useruid");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_HashtagPostuid",
                table: "Posts",
                column: "HashtagPostuid");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Useruid",
                table: "Posts",
                column: "Useruid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Mentions");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "HashtagPosts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
