using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineConsultations.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin@admin.com", 0, "0f2cb6ec-5d22-4b92-8e46-4736f1a6cff1", "admin@admin.com", false, "AdminFirstName", "AdminLastName", false, null, null, null, "AQAAAAIAAYagAAAAEFxlY6h9qfYueFS4o+LbuttO/HKnXRttsEQahzaYEbzEzA5Zw1lLnMVTVVL0WCt5cQ==", null, false, "eccb1f6f-e5dc-406a-b915-f8ba60516d77", false, "admin@admin.com" },
                    { "guest1@guest.com", 0, "c4fbd193-549b-4034-abcd-57c6c81425be", "guest1@guest.com", false, "GuestOneFirstName", "GuestOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEMQaue3+H1CF4nWCcgwNTeI99aUePQZb+V3HheNqcEgAQoFsN0GIzOOG0yb8FXVSiw==", null, false, "da873625-bf95-4484-aadb-c49c2ba03066", false, "guest1@guest.com" },
                    { "guest2@guest.com", 0, "cf88f0a8-3008-47ba-a9bf-def83807bd61", "guest2@guest.com", false, "GuestTwoFirstName", "GuestTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEGDZuZ4vZI/w+mby8wBSG1UsWMQTUVR/2Vy1UtLAku3jsK7mv7S423K4vno8UZOJBQ==", null, false, "76c52747-ab56-4b9e-824a-3acb2edbf149", false, "guest2@guest.com" },
                    { "guest3@guest.com", 0, "fdb9ed03-effe-4d24-880e-a13d8cc38723", "guest3@guest.com", false, "GuestThreeFirstName", "GuestThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEIpFfvs6YMpXKJ8hLoernXSjIcktK4mF2OElMHD69OqStoAY+a98rMk5J/2T8VeshQ==", null, false, "0e8607d4-b67a-4238-aca5-0edc50c34c9d", false, "guest3@guest.com" },
                    { "provide1@provide.com", 0, "9cc6af45-4932-4d26-97d9-2275d3cb87e1", "provide1@provide.com", false, "ProvideOneFirstName", "ProvideOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEAkakCOY1y/Zv8g+K5z60oIIOf0UQs9g2doeEZwD2HmCiZK8Z+uWSJE7hs/+57p/zQ==", null, false, "13eabb45-6f93-4dad-9ad4-e18279e7e115", false, "provide1@provide.com" },
                    { "provide2@provide.com", 0, "ae23081c-3476-48b0-906c-b0a98e7f7549", "provide2@provide.com", false, "ProvideTwoFirstName", "ProvideTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEO3Lvoy/pOq2RAOwkVcoUCOEgieCwC51aJrpi7kFUhZdH/ddV2XcFgyICmVvRzrw+Q==", null, false, "45d23a1c-c874-4fca-a55c-476998ae7436", false, "provide2@provide.com" },
                    { "provide3@provide.com", 0, "6cf92602-861e-4e2e-a1ea-b2cae916d973", "provide3@provide.com", false, "ProvideThreeFirstName", "ProvideThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEJbN1m+aEpadhZfiF1AftdybFUtMg8k+4rcOE4M5nGzJ4nNVDUr+YNro231qFYyDoA==", null, false, "34be6814-dac2-4974-a82d-9249300baf3b", false, "provide3@provide.com" },
                    { "search1@search.com", 0, "2edbff31-d963-423c-a02d-944bf7109763", "search1@search.com", false, "SearchOneFirstName", "SearchOneLastName", false, null, null, null, "AQAAAAIAAYagAAAAEGRPGXTmDEIl34EqxFdsu1QvbRfxPClB+BzNs2joh2G49Jb1TvqUu9lNZjOvlgZ7EA==", null, false, "e3d89729-08c4-4a16-adf4-c9da4ec12bf9", false, "search1@search.com" },
                    { "search2@search.com", 0, "c2dbeaa6-cbc6-44a6-aeaa-949c5a4a4f70", "search2@search.com", false, "SearchTwoFirstName", "SearchTwoLastName", false, null, null, null, "AQAAAAIAAYagAAAAEJwekQUHgTY1cRu9mk9VCNUfnsLcBOo4gn3ZKdWmhXvIOArsXzWpbFUMGQVyzJ7AAw==", null, false, "f1c51a1e-9220-42c2-83e4-4f4f093ad416", false, "search2@search.com" },
                    { "search3@search.com", 0, "74499b7a-a0d7-4eee-a81b-023d5c39dcd8", "search3@search.com", false, "SearchThreeFirstName", "SearchThreeLastName", false, null, null, null, "AQAAAAIAAYagAAAAEDhAh8HvenR2he+93FdxM/iH6lhDBCSe/JCrZ2jEXAEpXsYjd3+2A7gb9HNjFabMtQ==", null, false, "43bee3ec-7704-4d54-84a8-433b2d6c537b", false, "search3@search.com" }
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
        }
    }
}
