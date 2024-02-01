using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrawingCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainClassification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainClassification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoutingSlips",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    FieldId = table.Column<long>(type: "bigint", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutingSlips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrawingCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewType_DrawingCategories_DrawingCategoryId",
                        column: x => x.DrawingCategoryId,
                        principalTable: "DrawingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubClassification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    MainClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubClassification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubClassification_MainClassification_MainClassificationId",
                        column: x => x.MainClassificationId,
                        principalTable: "MainClassification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionDrawings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDateline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order = table.Column<long>(type: "bigint", nullable: false),
                    SubClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    MainClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionDrawings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstructionDrawings_SubClassification_SubClassificationId",
                        column: x => x.SubClassificationId,
                        principalTable: "SubClassification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewDrawings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstructionDrawingId = table.Column<long>(type: "bigint", nullable: false),
                    ReviewTypeId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    PostApprovalChangeFlag = table.Column<bool>(type: "bit", nullable: false),
                    CommentRoomId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvanceSharingFlag = table.Column<bool>(type: "bit", nullable: false),
                    SharedFlag = table.Column<bool>(type: "bit", nullable: false),
                    AdvanceSharingMemo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewDrawings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewDrawings_ConstructionDrawings_ConstructionDrawingId",
                        column: x => x.ConstructionDrawingId,
                        principalTable: "ConstructionDrawings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewDrawings_ReviewType_ReviewTypeId",
                        column: x => x.ReviewTypeId,
                        principalTable: "ReviewType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewDrawings_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewProgresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewDrawingId = table.Column<long>(type: "bigint", nullable: false),
                    RoutingSlipsId = table.Column<long>(type: "bigint", nullable: false),
                    ReviewerUseFlag = table.Column<bool>(type: "bit", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduledReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<string>(type: "varchar(32)", nullable: false),
                    CreateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    UpdateProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteUserId = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeleteProgramId = table.Column<string>(type: "varchar(32)", nullable: true),
                    AdminUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminUpdateUserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewProgresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewProgresses_ReviewDrawings_ReviewDrawingId",
                        column: x => x.ReviewDrawingId,
                        principalTable: "ReviewDrawings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewProgresses_RoutingSlips_RoutingSlipsId",
                        column: x => x.RoutingSlipsId,
                        principalTable: "RoutingSlips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionDrawings_SubClassificationId",
                table: "ConstructionDrawings",
                column: "SubClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDrawings_ConstructionDrawingId",
                table: "ReviewDrawings",
                column: "ConstructionDrawingId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDrawings_ReviewTypeId",
                table: "ReviewDrawings",
                column: "ReviewTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDrawings_StatusId",
                table: "ReviewDrawings",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewProgresses_ReviewDrawingId",
                table: "ReviewProgresses",
                column: "ReviewDrawingId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewProgresses_RoutingSlipsId",
                table: "ReviewProgresses",
                column: "RoutingSlipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewType_DrawingCategoryId",
                table: "ReviewType",
                column: "DrawingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubClassification_MainClassificationId",
                table: "SubClassification",
                column: "MainClassificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewProgresses");

            migrationBuilder.DropTable(
                name: "ReviewDrawings");

            migrationBuilder.DropTable(
                name: "RoutingSlips");

            migrationBuilder.DropTable(
                name: "ConstructionDrawings");

            migrationBuilder.DropTable(
                name: "ReviewType");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "SubClassification");

            migrationBuilder.DropTable(
                name: "DrawingCategories");

            migrationBuilder.DropTable(
                name: "MainClassification");
        }
    }
}
