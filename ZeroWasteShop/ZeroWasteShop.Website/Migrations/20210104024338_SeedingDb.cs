using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeroWasteShop.Website.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Body Care Product" },
                    { 2, null, "Household Cleaning Product" },
                    { 3, null, "Product Made Of Recycled Materials" },
                    { 4, null, "Trash Reducing Product" },
                    { 5, null, "Vacuum Flask Product" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "The soap does not contain palm or coconut oils. A very gentle skin-softening soap.", "\\images\\thumbnails\\bodycare1_thumb.jpg", "\\images\\bodycare1.jpg", true, false, "Body Soap", 6.99m },
                    { 2, 1, "A bamboo toothbrush with charcoal bristles, giving the product strong antibacterial properties, cleaning plaque and intensive whitening.", "\\images\\thumbnails\\bodycare2_thumb.jpg", "\\images\\bodycare2.png", true, true, "Bamboo Tooth Brush", 3.99m },
                    { 3, 1, "Helps keep your cosmetic products last longer, perfect for travel.", "\\images\\thumbnails\\bodycare3_thumb.jpg", "\\images\\bodycare3.jpg", true, false, "Jar for cosmetics", 1.99m },
                    { 4, 2, "Laundry soap with mustard and soda.", "\\images\\thumbnails\\cleaning1_thumb.jpg", "\\images\\cleaning1.jpg", true, false, "Laundry Soap", 0.59m },
                    { 5, 2, "Helps keep your soap fresh longer.", "\\images\\thumbnails\\cleaning2_thumb.jpg", "\\images\\cleaning2.png", true, true, "Wooden Soap Dish", 2.59m },
                    { 6, 2, "Helps to clean the house quickly, efficiently, without much effort, while not using any cleaning agents.", "\\images\\thumbnails\\cleaning3_thumb.jpg", "\\images\\cleaning3.jpg", true, true, "Cleaning Kit", 12.59m },
                    { 7, 3, "Eco-friendly ballpoint pen made from recycled milk and juice bags, soft and pleasant to the touch. As a result of the processing of this packaging, polyaluminium and cellulose are obtained, from which handles and cases for them are subsequently created.", "\\images\\thumbnails\\recycled1_thumb.jpg", "\\images\\recycled1.jpg", true, true, "Recycled Ballpoint Pen", 0.50m },
                    { 8, 3, "Handcrafted from recycled paper and cardboard.", "\\images\\thumbnails\\recycled2_thumb.jpg", "\\images\\recycled2.jpg", true, false, "Recycled Postcard", 4.00m },
                    { 9, 3, "Eco toy rope for dogs made of hemp, ball with two ribs.", "\\images\\thumbnails\\recycled3_thumb.jpg", "\\images\\recycled3.jpg", true, false, "Eco Toy For Dogs", 6.99m },
                    { 10, 4, "The glass is made of food grade silicone, the lid and sleeve are made of polypropylene. Suitable for hot and cold drinks (0 to 100 ° C), dishwasher safe (easy to disassemble), microwave use after removing the sleeve and lid.", "\\images\\thumbnails\\trashreducing1_thumb.jpg", "\\images\\trashreducing1.jpg", true, true, "Foldable Silicone Cup", 9.00m },
                    { 11, 4, "Inexpensive and reliable bag clamps made of completely redesigned tetrapack. As a result of the processing of this packaging, polyaluminium and cellulose are obtained, from which clamps are subsequently created. Eco-friendly and versatile - they will definitely find use in your kitchen!", "\\images\\thumbnails\\trashreducing2_thumb.jpg", "\\images\\trashreducing2.jpg", true, true, "Bag Clip", 0.99m },
                    { 12, 4, "The set consists of a knife with a magnetic handle, a fork and a spoon, is compact and has a special silicone cover to keep everything clean before and after use.", "\\images\\thumbnails\\trashreducing3_thumb.jpg", "\\images\\trashreducing3.jpg", true, true, "Cutlery Set", 14.00m },
                    { 13, 5, "Used to keep drinks warm. The average temperature retention time is 5-7 hours. Do not overfill the thermos, always leave a gap of about 2 centimeters between the liquid and the stopper. Avoid sudden temperature changes. Rinse the thermos with warm water before first use. Service life is not limited.", "\\images\\thumbnails\\vacuumflask1_thumb.jpg", "\\images\\vacuumflask1.jpg", true, false, "Metal Flask (0.5L)", 12.00m },
                    { 14, 5, "Used to keep drinks warm. The average temperature retention time is 5-7 hours. Do not overfill the thermos, always leave a gap of about 2 centimeters between the liquid and the stopper. Avoid sudden temperature changes. Rinse the thermos with warm water before first use. Service life is not limited.", "\\images\\thumbnails\\vacuumflask2_thumb.jpg", "\\images\\vacuumflask2.jpg", true, true, "Metal Flask (0.75L)", 16.59m },
                    { 15, 5, "This thermos is not only beautiful, but also incredibly functional. Unique modern design. Stylish matte colors. Ideal for hot / cold drinks, noodles, soups or rice. Double wall stainless steel. Up to 12/24 hours of cold. 100% sealed.", "\\images\\thumbnails\\vacuumflask3_thumb.jpg", "\\images\\vacuumflask3.jpg", true, false, "Coffee Flask (0.5L)", 10.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
