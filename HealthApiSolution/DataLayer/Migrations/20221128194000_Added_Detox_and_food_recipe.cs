using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class Added_Detox_and_food_recipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnamnesisForm_Diet_DietId",
                table: "AnamnesisForm");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyInfo_AspNetUsers_UserId",
                table: "BodyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BuyingReport_AspNetUsers_UserId",
                table: "BuyingReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Diet_AspNetUsers_UserId",
                table: "Diet");

            migrationBuilder.DropForeignKey(
                name: "FK_DietWeekly_Diet_DietId",
                table: "DietWeekly");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionSchedule_DietWeekly_DietWeeklyId",
                table: "NutritionSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionScheduleItem_NutritionSchedule_NutritionScheduleId",
                table: "NutritionScheduleItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PilatesWeekly_Pilates_PilatesId",
                table: "PilatesWeekly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PilatesWeekly",
                table: "PilatesWeekly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NutritionScheduleItem",
                table: "NutritionScheduleItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NutritionSchedule",
                table: "NutritionSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DietWeekly",
                table: "DietWeekly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diet",
                table: "Diet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuyingReport",
                table: "BuyingReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyInfo",
                table: "BodyInfo");

            migrationBuilder.RenameTable(
                name: "PilatesWeekly",
                newName: "PilatesWeeklies");

            migrationBuilder.RenameTable(
                name: "NutritionScheduleItem",
                newName: "NutritionScheduleItems");

            migrationBuilder.RenameTable(
                name: "NutritionSchedule",
                newName: "NutritionSchedules");

            migrationBuilder.RenameTable(
                name: "DietWeekly",
                newName: "DietWeeklies");

            migrationBuilder.RenameTable(
                name: "Diet",
                newName: "Diets");

            migrationBuilder.RenameTable(
                name: "BuyingReport",
                newName: "BuyingReports");

            migrationBuilder.RenameTable(
                name: "BodyInfo",
                newName: "BodyInfos");

            migrationBuilder.RenameIndex(
                name: "IX_PilatesWeekly_PilatesId",
                table: "PilatesWeeklies",
                newName: "IX_PilatesWeeklies_PilatesId");

            migrationBuilder.RenameIndex(
                name: "IX_NutritionScheduleItem_NutritionScheduleId",
                table: "NutritionScheduleItems",
                newName: "IX_NutritionScheduleItems_NutritionScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_NutritionSchedule_DietWeeklyId",
                table: "NutritionSchedules",
                newName: "IX_NutritionSchedules_DietWeeklyId");

            migrationBuilder.RenameIndex(
                name: "IX_DietWeekly_DietId",
                table: "DietWeeklies",
                newName: "IX_DietWeeklies_DietId");

            migrationBuilder.RenameIndex(
                name: "IX_Diet_UserId",
                table: "Diets",
                newName: "IX_Diets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BuyingReport_UserId",
                table: "BuyingReports",
                newName: "IX_BuyingReports_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BodyInfo_UserId",
                table: "BodyInfos",
                newName: "IX_BodyInfos_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "NutritionScheduleItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "GeneralInfo",
                table: "NutritionScheduleItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeInterval",
                table: "NutritionScheduleItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PilatesWeeklies",
                table: "PilatesWeeklies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NutritionScheduleItems",
                table: "NutritionScheduleItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NutritionSchedules",
                table: "NutritionSchedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DietWeeklies",
                table: "DietWeeklies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diets",
                table: "Diets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuyingReports",
                table: "BuyingReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyInfos",
                table: "BodyInfos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DetoxRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetoxRecipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRecipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietDividedIntoDays",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HowManyDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhichDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetoxRecipeId = table.Column<int>(type: "int", nullable: true),
                    FoodRecipeId = table.Column<int>(type: "int", nullable: true),
                    NutritionScheduleItemId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietDividedIntoDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietDividedIntoDays_DetoxRecipes_DetoxRecipeId",
                        column: x => x.DetoxRecipeId,
                        principalTable: "DetoxRecipes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DietDividedIntoDays_FoodRecipes_FoodRecipeId",
                        column: x => x.FoodRecipeId,
                        principalTable: "FoodRecipes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DietDividedIntoDays_NutritionScheduleItems_NutritionScheduleItemId",
                        column: x => x.NutritionScheduleItemId,
                        principalTable: "NutritionScheduleItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PackageItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageType = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageItems_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DietDividedIntoDays_DetoxRecipeId",
                table: "DietDividedIntoDays",
                column: "DetoxRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_DietDividedIntoDays_FoodRecipeId",
                table: "DietDividedIntoDays",
                column: "FoodRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_DietDividedIntoDays_NutritionScheduleItemId",
                table: "DietDividedIntoDays",
                column: "NutritionScheduleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_PackageId",
                table: "PackageItems",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnamnesisForm_Diets_DietId",
                table: "AnamnesisForm",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyInfos_AspNetUsers_UserId",
                table: "BodyInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuyingReports_AspNetUsers_UserId",
                table: "BuyingReports",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diets_AspNetUsers_UserId",
                table: "Diets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DietWeeklies_Diets_DietId",
                table: "DietWeeklies",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionScheduleItems_NutritionSchedules_NutritionScheduleId",
                table: "NutritionScheduleItems",
                column: "NutritionScheduleId",
                principalTable: "NutritionSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionSchedules_DietWeeklies_DietWeeklyId",
                table: "NutritionSchedules",
                column: "DietWeeklyId",
                principalTable: "DietWeeklies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PilatesWeeklies_Pilates_PilatesId",
                table: "PilatesWeeklies",
                column: "PilatesId",
                principalTable: "Pilates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnamnesisForm_Diets_DietId",
                table: "AnamnesisForm");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyInfos_AspNetUsers_UserId",
                table: "BodyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BuyingReports_AspNetUsers_UserId",
                table: "BuyingReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Diets_AspNetUsers_UserId",
                table: "Diets");

            migrationBuilder.DropForeignKey(
                name: "FK_DietWeeklies_Diets_DietId",
                table: "DietWeeklies");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionScheduleItems_NutritionSchedules_NutritionScheduleId",
                table: "NutritionScheduleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionSchedules_DietWeeklies_DietWeeklyId",
                table: "NutritionSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_PilatesWeeklies_Pilates_PilatesId",
                table: "PilatesWeeklies");

            migrationBuilder.DropTable(
                name: "DietDividedIntoDays");

            migrationBuilder.DropTable(
                name: "PackageItems");

            migrationBuilder.DropTable(
                name: "DetoxRecipes");

            migrationBuilder.DropTable(
                name: "FoodRecipes");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PilatesWeeklies",
                table: "PilatesWeeklies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NutritionSchedules",
                table: "NutritionSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NutritionScheduleItems",
                table: "NutritionScheduleItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DietWeeklies",
                table: "DietWeeklies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diets",
                table: "Diets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuyingReports",
                table: "BuyingReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyInfos",
                table: "BodyInfos");

            migrationBuilder.DropColumn(
                name: "GeneralInfo",
                table: "NutritionScheduleItems");

            migrationBuilder.DropColumn(
                name: "TimeInterval",
                table: "NutritionScheduleItems");

            migrationBuilder.RenameTable(
                name: "PilatesWeeklies",
                newName: "PilatesWeekly");

            migrationBuilder.RenameTable(
                name: "NutritionSchedules",
                newName: "NutritionSchedule");

            migrationBuilder.RenameTable(
                name: "NutritionScheduleItems",
                newName: "NutritionScheduleItem");

            migrationBuilder.RenameTable(
                name: "DietWeeklies",
                newName: "DietWeekly");

            migrationBuilder.RenameTable(
                name: "Diets",
                newName: "Diet");

            migrationBuilder.RenameTable(
                name: "BuyingReports",
                newName: "BuyingReport");

            migrationBuilder.RenameTable(
                name: "BodyInfos",
                newName: "BodyInfo");

            migrationBuilder.RenameIndex(
                name: "IX_PilatesWeeklies_PilatesId",
                table: "PilatesWeekly",
                newName: "IX_PilatesWeekly_PilatesId");

            migrationBuilder.RenameIndex(
                name: "IX_NutritionSchedules_DietWeeklyId",
                table: "NutritionSchedule",
                newName: "IX_NutritionSchedule_DietWeeklyId");

            migrationBuilder.RenameIndex(
                name: "IX_NutritionScheduleItems_NutritionScheduleId",
                table: "NutritionScheduleItem",
                newName: "IX_NutritionScheduleItem_NutritionScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_DietWeeklies_DietId",
                table: "DietWeekly",
                newName: "IX_DietWeekly_DietId");

            migrationBuilder.RenameIndex(
                name: "IX_Diets_UserId",
                table: "Diet",
                newName: "IX_Diet_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BuyingReports_UserId",
                table: "BuyingReport",
                newName: "IX_BuyingReport_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BodyInfos_UserId",
                table: "BodyInfo",
                newName: "IX_BodyInfo_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "NutritionScheduleItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PilatesWeekly",
                table: "PilatesWeekly",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NutritionSchedule",
                table: "NutritionSchedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NutritionScheduleItem",
                table: "NutritionScheduleItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DietWeekly",
                table: "DietWeekly",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diet",
                table: "Diet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuyingReport",
                table: "BuyingReport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyInfo",
                table: "BodyInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnamnesisForm_Diet_DietId",
                table: "AnamnesisForm",
                column: "DietId",
                principalTable: "Diet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyInfo_AspNetUsers_UserId",
                table: "BodyInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BuyingReport_AspNetUsers_UserId",
                table: "BuyingReport",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diet_AspNetUsers_UserId",
                table: "Diet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DietWeekly_Diet_DietId",
                table: "DietWeekly",
                column: "DietId",
                principalTable: "Diet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionSchedule_DietWeekly_DietWeeklyId",
                table: "NutritionSchedule",
                column: "DietWeeklyId",
                principalTable: "DietWeekly",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionScheduleItem_NutritionSchedule_NutritionScheduleId",
                table: "NutritionScheduleItem",
                column: "NutritionScheduleId",
                principalTable: "NutritionSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PilatesWeekly_Pilates_PilatesId",
                table: "PilatesWeekly",
                column: "PilatesId",
                principalTable: "Pilates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
