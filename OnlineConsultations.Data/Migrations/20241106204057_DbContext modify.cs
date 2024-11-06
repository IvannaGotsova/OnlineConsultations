using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultations.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbContextmodify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin@admin.com", 0, "7316e89e-e506-4c9a-9d14-962c1fb5ccd9", "admin@admin.com", false, "AdminFirstName", "AdminLastName", false, null, null, null, "AQAAAAIAAYagAAAAEAnQjbIeHw57a+J4qypUY6/OaC/R21seEkDJxmk+wnh6ApJRzBPaOKXbL04OHJaO9Q==", null, false, "7f102cb7-dafb-43ec-9340-d1f649c19e66", false, "admin@admin.com" },
                    { "guest1@guest.com", 0, "191f012d-afe4-4631-a729-4345af688859", "guest1@guest.com", false, "GuestOneFirstName", "GuestOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEOj7lg8DX0z4xMzjzjBj0IRLcgj1I4JbRzlDozSd8iLKHg4IujmiUa4K8sy4CMxKUw==", null, false, "392d20d9-26b3-40fa-af75-84775f336ed0", false, "guest1@guest.com" },
                    { "guest2@guest.com", 0, "b8e61a34-2e79-4484-95fe-a2a85793fb9f", "guest2@guest.com", false, "GuestTwoFirstName", "GuestTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEK6d9a0MGHknFsv2kY78czzhYhXdtRIt5vmbVBT8LxxydHIo5bFrA50xSoJ1jJbVdw==", null, false, "df9a05b1-a4ad-4031-81b3-aed86d345570", false, "guest2@guest.com" },
                    { "guest3@guest.com", 0, "fb000c97-0187-4fd4-ae7c-3b43cc308bd4", "guest3@guest.com", false, "GuestThreeFirstName", "GuestThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEGebJtRy4G13elU0Ayv5nkMYLcWXT0a2UEv3dPpNifbs+LGJsT9l3JIRUyucR8XHoQ==", null, false, "84d6b5d2-618c-441d-b70e-c1754cad0f11", false, "guest3@guest.com" },
                    { "provide1@provide.com", 0, "d636f140-f84b-4df7-82e8-828459e487c5", "provide1@provide.com", false, "ProvideOneFirstName", "ProvideOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEBCldpgMb3bGhxK1nw+AqkSg0lmsnGmLXPCRf7ogQPLvGz9gYE/Ng/L0f58SYCfqCQ==", null, false, "b49e93ef-e7df-4209-bda1-2081c8f3f835", false, "provide1@provide.com" },
                    { "provide2@provide.com", 0, "5b4e36a8-e6b0-4a0e-8499-f01d8aa3de50", "provide2@provide.com", false, "ProvideTwoFirstName", "ProvideTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEEhTl948vfTQ9DNcz6ZVPyWVQeniDRZfqW9J6VrJsM7zMX3wCd0AMJR35+TP9wqYHw==", null, false, "4e275445-813f-4119-9186-dd4a09c9a27d", false, "provide2@provide.com" },
                    { "provide3@provide.com", 0, "cc29530c-49c5-41ad-bff8-85531a36e534", "provide3@provide.com", false, "ProvideThreeFirstName", "ProvideThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEE1d0YByhukc5IJhClG6P05zcfY+DJW2FHDb0BzO5U3sQDn9UFqKxgh8GRoiuY9r4A==", null, false, "26fb10f1-fbe0-4b51-8877-27d772a9a670", false, "provide3@provide.com" },
                    { "search1@search.com", 0, "d944d892-223d-491c-9e40-40561d784da0", "search1@search.com", false, "SearchOneFirstName", "SearchOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEPSeykZTgGhzd7+CzEmx8Bs5vhiA+wJNj01iume3raEwR9R0o69qaNMCqVXJDZArZw==", null, false, "eb84722e-0810-443f-89e0-da44b772bc18", false, "search1@search.com" },
                    { "search2@search.com", 0, "fe1454ad-ac33-42c6-abfc-bd576e24432d", "search2@search.com", false, "SearchTwoFirstName", "SearchTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEPCyAGFqr+cv5xQo0K6URECEPcrrupD7P045G/ETXbTmneMDYhzGRmalMEw7E0zsyQ==", null, false, "c29e3871-c5ad-4caa-85ac-400f64f067bf", false, "search2@search.com" },
                    { "search3@search.com", 0, "d867df21-ee02-440e-82c1-825b52c0c1f4", "search3@search.com", false, "SearchThreeFirstName", "SearchThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEIEizcGzvpzrG6O1mYZN3TVJtQs3n2NcRrjjSbUKzLFDq2lR7QehyDRmVJknW8//Hw==", null, false, "e189af23-230a-418b-8268-b9a8bbf08bb8", false, "search3@search.com" }
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
                    { 1, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Description", "First", 1 },
                    { 2, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Description", "Second", 2 },
                    { 3, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Description", "Third", 3 },
                    { 4, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fourth Description", "Fourth", 0 }
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
                    { 1, 1, "Comment First", "First", 1, 0 },
                    { 2, 1, "Comment Second", "Second", 1, 0 },
                    { 3, 2, "Comment Third", "Third", 2, 0 },
                    { 4, 3, "Comment Fourth", "Fourth", 2, 0 },
                    { 5, 3, "Comment Fifth", "Fifth", 1, 0 },
                    { 6, 3, "Comment Sixth", "Sixth", 0, 1 },
                    { 7, 2, "Comment Seventh", "Seventh", 0, 1 },
                    { 8, 4, "Comment Eight", "Eight", 0, 2 },
                    { 9, 1, "Comment Ninth", "Ninth", 0, 2 },
                    { 10, 2, "Comment Tenth", "Tenth", 0, 2 },
                    { 11, 2, "Comment Eleven", "Eleven", 0, 3 },
                    { 12, 2, "Comment Twelve", "Twelve", 0, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin@admin.com");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GuestUsers",
                keyColumn: "GuestUserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest3@guest.com");

            migrationBuilder.DeleteData(
                table: "GuestUsers",
                keyColumn: "GuestUserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GuestUsers",
                keyColumn: "GuestUserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProvideUsers",
                keyColumn: "ProvideUserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1@guest.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2@guest.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "provide3@provide.com");

            migrationBuilder.DeleteData(
                table: "ProvideUsers",
                keyColumn: "ProvideUserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProvideUsers",
                keyColumn: "ProvideUserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "provide1@provide.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "provide2@provide.com");

            migrationBuilder.DeleteData(
                table: "SearchUsers",
                keyColumn: "SearchUserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SearchUsers",
                keyColumn: "SearchUserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SearchUsers",
                keyColumn: "SearchUserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "search1@search.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "search2@search.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "search3@search.com");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");
        }
    }
}
