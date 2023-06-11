using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeaTimeDemo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateProductsSeedToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "果汁");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "茶");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "天然果飲，迷人多變。", "台灣水果茶", 60.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 2, " 品鐵觀音，享人生的味道。", "鐵觀音", 35.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "Size" },
                values: new object[] { 3, "用咖啡體悟悠閒時光。", "冰美式咖啡", "中杯" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "茶飲");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "水果茶");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "清爽又止渴", "紅茶", 30.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 1, "回甘就像現泡", "綠茶", 25.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "Size" },
                values: new object[] { 2, "小小一杯，清涼一夏", "綠豆沙牛奶", "大杯" });
        }
    }
}
