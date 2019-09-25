using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }


    public class Program
    {
        IList<Item> Items;

        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                        {
                            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                            new Item
                                {
                                    Name = "Backstage passes to a TAFKAL80ETC concert",
                                    SellIn = 15,
                                    Quality = 20
                                },
                            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                        }

            };

            app.UpdateQuality();

            Console.ReadKey();
        }

        public IList<Item> UpdateQuality()
        {
            return Items.Select(i => UpdateItemQuality(i)).ToList();
        }

        public Item UpdateItemQuality(Item item)
        {
            if (IsLegendary(item))
            {
                return item;
            }
            item.Quality = AdjustQuality(item);
            item.SellIn -= 1;
            return item;
        }

        public int AdjustQuality(Item item)
        {
            if (QualityWithAgeItems().Contains(item.Name))
            {
                return IncrementQuality(item);
            }
            return DecrementQuality(item);    
        }

        public int IncrementQuality(Item item)
        {
            if (QualityWithAgeByDateItems().Contains(item.Name))
            {
                return IncrementQualityWithAge(item);
            }
            if (item.Quality < 50)
            {
                return item.Quality += 1;
            }
            return item.Quality;
        }

        public int DecrementQuality(Item item)
        {
            int amountToDecrement;
            if (item.Quality == 0)
            {
                amountToDecrement = 0;
            }
            else if (item.SellIn < 0)
            {
                amountToDecrement = 2;
            }
            else
            {
                amountToDecrement = 1;
            }
            if (IsConjured(item))
            {
                amountToDecrement = amountToDecrement * 2;
            }
            return item.Quality - amountToDecrement;
        }

        public int IncrementQualityWithAge(Item item)
        {
            if (item.SellIn <= 10 && item.SellIn > 5)
            {
                return item.Quality += 2;
            }
            if (item.SellIn <= 5 && item.SellIn >= 0)
            {
                return item.Quality += 3;
            }
            if (item.SellIn < 0)
            {
                return 0;
            }
            return item.Quality;
        }

        public List<string> QualityWithAgeItems()
        {
            return new List<string>
            {
                "Aged Brie",
                "Backstage passes to a TAFKAL80ETC concert"
            };
        }

        public List<string> QualityWithAgeByDateItems()
        {
            return new List<string>
            {
                "Backstage passes to a TAFKAL80ETC concert"
            };
        }

        public bool IsConjured(Item item)
        {
            var conjuredItems = new List<string>
            {
                "Conjured Mana Cake"
            };
            return conjuredItems.Contains(item.Name);
        }

        public bool IsLegendary(Item item)
        {
            var legendaryItems = new List<string>
            {
                "Sulfuras, Hand of Ragnaros"
            };
            return legendaryItems.Contains(item.Name);
        }
    }
}
