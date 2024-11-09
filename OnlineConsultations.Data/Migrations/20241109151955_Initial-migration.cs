using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultations.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestUsers",
                columns: table => new
                {
                    GuestUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestUsers", x => x.GuestUserId);
                    table.ForeignKey(
                        name: "FK_GuestUsers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProvideUsers",
                columns: table => new
                {
                    ProvideUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvideUsers", x => x.ProvideUserId);
                    table.ForeignKey(
                        name: "FK_ProvideUsers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SearchUsers",
                columns: table => new
                {
                    SearchUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchUsers", x => x.SearchUserId);
                    table.ForeignKey(
                        name: "FK_SearchUsers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 200000, nullable: false),
                    PostPayPerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProvideUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_ProvideUsers_ProvideUserId",
                        column: x => x.ProvideUserId,
                        principalTable: "ProvideUsers",
                        principalColumn: "ProvideUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 200000, nullable: false),
                    ProvideUserId = table.Column<int>(type: "int", nullable: false),
                    SearchUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_ProvideUsers_ProvideUserId",
                        column: x => x.ProvideUserId,
                        principalTable: "ProvideUsers",
                        principalColumn: "ProvideUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_SearchUsers_SearchUserId",
                        column: x => x.SearchUserId,
                        principalTable: "SearchUsers",
                        principalColumn: "SearchUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    QuestionDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 200000, nullable: false),
                    QuestionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuestUserId = table.Column<int>(type: "int", nullable: true),
                    SearchUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_GuestUsers_GuestUserId",
                        column: x => x.GuestUserId,
                        principalTable: "GuestUsers",
                        principalColumn: "GuestUserId");
                    table.ForeignKey(
                        name: "FK_Questions_SearchUsers_SearchUserId",
                        column: x => x.SearchUserId,
                        principalTable: "SearchUsers",
                        principalColumn: "SearchUserId");
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingValue = table.Column<int>(type: "int", nullable: false),
                    ProvideUserId = table.Column<int>(type: "int", nullable: false),
                    SearchUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_ProvideUsers_ProvideUserId",
                        column: x => x.ProvideUserId,
                        principalTable: "ProvideUsers",
                        principalColumn: "ProvideUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_SearchUsers_SearchUserId",
                        column: x => x.SearchUserId,
                        principalTable: "SearchUsers",
                        principalColumn: "SearchUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 200000, nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProvideUserId = table.Column<int>(type: "int", nullable: false),
                    SearchUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_ProvideUsers_ProvideUserId",
                        column: x => x.ProvideUserId,
                        principalTable: "ProvideUsers",
                        principalColumn: "ProvideUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_SearchUsers_SearchUserId",
                        column: x => x.SearchUserId,
                        principalTable: "SearchUsers",
                        principalColumn: "SearchUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 200000, nullable: false),
                    AnswerDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProvideUserId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_ProvideUsers_ProvideUserId",
                        column: x => x.ProvideUserId,
                        principalTable: "ProvideUsers",
                        principalColumn: "ProvideUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommentDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 200000, nullable: false),
                    GuestUserId = table.Column<int>(type: "int", nullable: true),
                    SearchUserId = table.Column<int>(type: "int", nullable: true),
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_GuestUsers_GuestUserId",
                        column: x => x.GuestUserId,
                        principalTable: "GuestUsers",
                        principalColumn: "GuestUserId");
                    table.ForeignKey(
                        name: "FK_Comments_SearchUsers_SearchUserId",
                        column: x => x.SearchUserId,
                        principalTable: "SearchUsers",
                        principalColumn: "SearchUserId");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin@admin.com", 0, "e021d8f6-9d30-4582-8c68-f24b15e7033f", "admin@admin.com", false, "AdminFirstName", "AdminLastName", false, null, null, null, "AQAAAAIAAYagAAAAEJ3cdHfh10XOeXN4JEWAy+x40iTnzw11j72Dck6wRxHarGFX88XqMn6WgWNTM7y5vg==", null, false, "f097f7cd-7d8c-43c7-a7b8-7f64558a4506", false, "admin@admin.com" },
                    { "guest1@guest.com", 0, "4eb5f884-244c-4c5c-9f22-12989274ddb0", "guest1@guest.com", false, "GuestOneFirstName", "GuestOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEI54t8zgN4Zl4EhFC1unZG0MUolUIOwhS3oHE04IZAiKfVlbhJFiUZ/7F6wln7bM6Q==", null, false, "d7e508fd-0702-4eaa-bc4e-c3e4b252fa14", false, "guest1@guest.com" },
                    { "guest2@guest.com", 0, "83a4d944-e784-4cd8-a702-f2e5dcdd8966", "guest2@guest.com", false, "GuestTwoFirstName", "GuestTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEHI8WNCgN7mnpQJZDE0LI35nlmlsec1B15F2EIRCAI0p5qKo/emuWp3oyDM2dT1Cgg==", null, false, "2fd69655-9e80-4870-a04d-47d522bad4fe", false, "guest2@guest.com" },
                    { "guest3@guest.com", 0, "0ff8d0f1-f783-4dda-98d5-e07c346e6177", "guest3@guest.com", false, "GuestThreeFirstName", "GuestThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEF6MsNmLxf6LvIUNKZMvBGIHx2OzFshdURU5/qEho+vUqjfcr1XXrfjInjJ/l9biww==", null, false, "d026c306-d5b5-49de-9c8c-86c0ac917c09", false, "guest3@guest.com" },
                    { "provide1@provide.com", 0, "48ed3f2c-7bed-4dca-97ce-9a510ae51a84", "provide1@provide.com", false, "ProvideOneFirstName", "ProvideOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEMSyq58qQ3NcL1LNYlw5mBvAA/9EfwoTpf2F2X+nak4phhxM9/RCPLTRvzhrOYEpsQ==", null, false, "f378ffdd-3bf1-4e55-8e72-328a00ef16c6", false, "provide1@provide.com" },
                    { "provide2@provide.com", 0, "69459317-9855-4708-be7c-375f3bc15aed", "provide2@provide.com", false, "ProvideTwoFirstName", "ProvideTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEBYRSaITzYYiZAsdLrIWBXkQFJakwKlailDX5r+VNzc/0lYWgJLW6jOITw/p6q1YUg==", null, false, "9c892671-b1d9-490a-8df7-5a0ab1f36c87", false, "provide2@provide.com" },
                    { "provide3@provide.com", 0, "d4ff5145-1712-4f53-950a-0ee77af18eb9", "provide3@provide.com", false, "ProvideThreeFirstName", "ProvideThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEKu9n+nE31QIkX2Xe2gDHzbPS56CuZejoGddeWR/2pjrfavP6CYNIVtdrcj9B6oUYA==", null, false, "78995b8c-079e-4a3a-8eae-575abdee580c", false, "provide3@provide.com" },
                    { "search1@search.com", 0, "b583dd63-f53b-4d14-88c2-9a808650c1a5", "search1@search.com", false, "SearchOneFirstName", "SearchOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEDSxTeVldzHnQVpPhNGQW0zVN+wR8HP3yDnl9KPU98NaoWiOj9ALfQ4zxaWd7/ERdQ==", null, false, "9d79d625-6741-4da0-83d5-73be7f68075f", false, "search1@search.com" },
                    { "search2@search.com", 0, "cfda0e09-7890-42e8-a972-ea6ca2128ffd", "search2@search.com", false, "SearchTwoFirstName", "SearchTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEN8bXN2vs4ARe4bmOp8JGglKS/+tZz1dhF2KiV2P8o7DOKtKOtipKcIyZLIoGyjcCQ==", null, false, "41b8acfb-29d6-474e-96de-537ab67af287", false, "search2@search.com" },
                    { "search3@search.com", 0, "b984478c-bfa9-4dd7-bc12-7e8557db4a5d", "search3@search.com", false, "SearchThreeFirstName", "SearchThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAENkmSoyo5BP6/Rremumi+sgFs0YR5BudYyte8oJpRZ/5dfrJZnMud55UCzf/MAre6A==", null, false, "26606702-f53a-4f6a-83e7-b2640c086275", false, "search3@search.com" }
                });

            migrationBuilder.InsertData(
                table: "GuestUsers",
                columns: new[] { "GuestUserId", "ApplicationUserId" },
                values: new object[,]
                {
                    { 1, "guest1@guest.com" },
                    { 2, "guest2@guest.com" },
                    { 3, "guest3@guest.com" }
                });

            migrationBuilder.InsertData(
                table: "ProvideUsers",
                columns: new[] { "ProvideUserId", "ApplicationUserId" },
                values: new object[,]
                {
                    { 1, "provide1@provide.com" },
                    { 2, "provide2@provide.com" },
                    { 3, "provide3@provide.com" }
                });

            migrationBuilder.InsertData(
                table: "SearchUsers",
                columns: new[] { "SearchUserId", "ApplicationUserId" },
                values: new object[,]
                {
                    { 1, "search1@search.com" },
                    { 2, "search2@search.com" },
                    { 3, "search3@search.com" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "MessageDescription", "ProvideUserId", "SearchUserId" },
                values: new object[,]
                {
                    { 1, "First message", 1, 1 },
                    { 2, "Second message", 1, 2 },
                    { 3, "Third message", 2, 3 },
                    { 4, "Fourth message", 1, 1 },
                    { 5, "Fifth message", 3, 2 },
                    { 6, "Sixth message", 1, 3 },
                    { 7, "Seventh message", 3, 1 },
                    { 8, "Eight message", 1, 2 },
                    { 9, "Ninth message", 2, 1 },
                    { 10, "Tenth message", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "PostDescription", "PostPayPerHour", "PostTitle", "ProvideUserId" },
                values: new object[,]
                {
                    { 1, "First Description", 22m, "First post", 1 },
                    { 2, "Second Description", 24m, "Second post", 2 },
                    { 3, "Third Description", 22m, "Third post", 3 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "GuestUserId", "QuestionDate", "QuestionDescription", "QuestionTitle", "SearchUserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Description", "First", 1 },
                    { 2, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Description", "Second", 2 },
                    { 3, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Description", "Third", 3 },
                    { 4, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fourth Description", "Fourth", null }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "ProvideUserId", "RatingValue", "SearchUserId" },
                values: new object[,]
                {
                    { 1, 1, 10, 1 },
                    { 2, 2, 9, 1 },
                    { 3, 3, 8, 1 },
                    { 4, 1, 10, 2 },
                    { 5, 2, 9, 2 },
                    { 6, 3, 9, 2 },
                    { 7, 1, 8, 3 },
                    { 8, 2, 9, 3 },
                    { 9, 3, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ProvideUserId", "ReviewDate", "ReviewDescription", "SearchUserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First description", 1 },
                    { 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second description", 1 },
                    { 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third description", 1 },
                    { 4, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fourth description", 2 },
                    { 5, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fifth description", 2 },
                    { 6, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sixth description", 2 },
                    { 7, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seventh description", 3 },
                    { 8, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eight description", 3 },
                    { 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ninth description", 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "AnswerDate", "AnswerDescription", "ProvideUserId", "QuestionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer First", 1, 1 },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Second", 1, 2 },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Third", 1, 3 },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Fourth", 2, 1 },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Fifth", 2, 3 },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Sixth", 2, 3 },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Seventh", 3, 2 },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Eighth", 3, 2 },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Answer Ninth", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AnswerId", "CommentDescription", "CommentTitle", "GuestUserId", "SearchUserId" },
                values: new object[,]
                {
                    { 1, 1, "Comment First", "First", 1, null },
                    { 2, 1, "Comment Second", "Second", 1, null },
                    { 3, 2, "Comment Third", "Third", 2, null },
                    { 4, 3, "Comment Fourth", "Fourth", 2, null },
                    { 5, 3, "Comment Fifth", "Fifth", 1, null },
                    { 6, 3, "Comment Sixth", "Sixth", null, 1 },
                    { 7, 2, "Comment Seventh", "Seventh", null, 1 },
                    { 8, 4, "Comment Eight", "Eight", null, 2 },
                    { 9, 1, "Comment Ninth", "Ninth", null, 2 },
                    { 10, 2, "Comment Tenth", "Tenth", null, 2 },
                    { 11, 2, "Comment Eleven", "Eleven", null, 3 },
                    { 12, 2, "Comment Twelve", "Twelve", null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_ProvideUserId",
                table: "Answers",
                column: "ProvideUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnswerId",
                table: "Comments",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GuestUserId",
                table: "Comments",
                column: "GuestUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SearchUserId",
                table: "Comments",
                column: "SearchUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestUsers_ApplicationUserId",
                table: "GuestUsers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ProvideUserId",
                table: "Messages",
                column: "ProvideUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SearchUserId",
                table: "Messages",
                column: "SearchUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ProvideUserId",
                table: "Posts",
                column: "ProvideUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvideUsers_ApplicationUserId",
                table: "ProvideUsers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_GuestUserId",
                table: "Questions",
                column: "GuestUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SearchUserId",
                table: "Questions",
                column: "SearchUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProvideUserId",
                table: "Ratings",
                column: "ProvideUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_SearchUserId",
                table: "Ratings",
                column: "SearchUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProvideUserId",
                table: "Reviews",
                column: "ProvideUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SearchUserId",
                table: "Reviews",
                column: "SearchUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchUsers_ApplicationUserId",
                table: "SearchUsers",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ProvideUsers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "GuestUsers");

            migrationBuilder.DropTable(
                name: "SearchUsers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
