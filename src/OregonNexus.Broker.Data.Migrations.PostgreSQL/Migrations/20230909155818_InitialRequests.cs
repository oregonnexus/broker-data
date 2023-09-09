using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OregonNexus.Broker.Data.Migrations.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IncomingRequests",
                columns: table => new
                {
                    IncomingRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationOrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequestUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Student = table.Column<string>(type: "text", nullable: true),
                    RequestStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingRequests", x => x.IncomingRequestId);
                    table.ForeignKey(
                        name: "FK_IncomingRequests_EducationOrganizations_EducationOrganizati~",
                        column: x => x.EducationOrganizationId,
                        principalTable: "EducationOrganizations",
                        principalColumn: "EducationOrganizationId");
                    table.ForeignKey(
                        name: "FK_IncomingRequests_Users_RequestUserId",
                        column: x => x.RequestUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OutgoingRequests",
                columns: table => new
                {
                    OutgoingRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequestDetails = table.Column<string>(type: "text", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EducationOrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProcessUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    Student = table.Column<string>(type: "text", nullable: true),
                    RequestStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutgoingRequests", x => x.OutgoingRequestId);
                    table.ForeignKey(
                        name: "FK_OutgoingRequests_EducationOrganizations_EducationOrganizati~",
                        column: x => x.EducationOrganizationId,
                        principalTable: "EducationOrganizations",
                        principalColumn: "EducationOrganizationId");
                    table.ForeignKey(
                        name: "FK_OutgoingRequests_Users_ProcessUserId",
                        column: x => x.ProcessUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PayloadContents",
                columns: table => new
                {
                    PayloadContentId = table.Column<Guid>(type: "uuid", nullable: false),
                    IncomingRequestId = table.Column<Guid>(type: "uuid", nullable: true),
                    OutgoingRequestId = table.Column<Guid>(type: "uuid", nullable: true),
                    ContentType = table.Column<string>(type: "text", nullable: true),
                    BlobContent = table.Column<byte[]>(type: "bytea", nullable: true),
                    JsonContent = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    XmlContent = table.Column<string>(type: "xml", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayloadContents", x => x.PayloadContentId);
                    table.ForeignKey(
                        name: "FK_PayloadContents_IncomingRequests_IncomingRequestId",
                        column: x => x.IncomingRequestId,
                        principalTable: "IncomingRequests",
                        principalColumn: "IncomingRequestId");
                    table.ForeignKey(
                        name: "FK_PayloadContents_OutgoingRequests_OutgoingRequestId",
                        column: x => x.OutgoingRequestId,
                        principalTable: "OutgoingRequests",
                        principalColumn: "OutgoingRequestId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IncomingRequests_EducationOrganizationId",
                table: "IncomingRequests",
                column: "EducationOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingRequests_RequestUserId",
                table: "IncomingRequests",
                column: "RequestUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingRequests_EducationOrganizationId",
                table: "OutgoingRequests",
                column: "EducationOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingRequests_ProcessUserId",
                table: "OutgoingRequests",
                column: "ProcessUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PayloadContents_IncomingRequestId",
                table: "PayloadContents",
                column: "IncomingRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PayloadContents_OutgoingRequestId",
                table: "PayloadContents",
                column: "OutgoingRequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayloadContents");

            migrationBuilder.DropTable(
                name: "IncomingRequests");

            migrationBuilder.DropTable(
                name: "OutgoingRequests");
        }
    }
}
