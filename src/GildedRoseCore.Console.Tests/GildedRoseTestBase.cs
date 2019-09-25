using ConsoleApplication;

namespace Tests
{
    public class GildedRoseTestBase
    {
        protected readonly Program _app = new Program();
        protected static readonly Item _plusFiveDexterityVest = new Item
        {
            Name = "+5 Dexterity Vest",
            SellIn = 10,
            Quality = 20
        };
        protected readonly Item _agedBrie = new Item
        {
            Name = "Aged Brie",
            SellIn = 2,
            Quality = 0
        };
        protected readonly Item _elixirOfTheMongoose = new Item
        {
            Name = "Elixir of the Mongoose",
            SellIn = 5,
            Quality = 7
        };
        protected readonly Item _sulfuras = new Item
        {
            Name = "Sulfuras, Hand of Ragnaros",
            SellIn = 0,
            Quality = 80
        };
        protected readonly Item _backstagePasses = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 15,
            Quality = 20
        };
        protected readonly Item _conjuredManaCake = new Item
        {
            Name = "Conjured Mana Cake",
            SellIn = 3,
            Quality = 6
        };
    }
}