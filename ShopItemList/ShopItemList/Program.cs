
using ShopItemList.Models;


List<ShopItem> shopItems = new List<ShopItem>();

shopItems.Add(new ShopItem()
{
    Name = "Candy",
    Price = 0.9M,
    Quantity = 3
});
shopItems.Add(new ShopItem()
{
    Name = "Ice Cream",
    Price = 2.2M,
    Quantity = 3
});
shopItems.Add(new ShopItem()
{
    Name = "Cake",
    Price = 15.0M,
    Quantity = 10
});
shopItems.Add(new ShopItem()
{
    Name = "Expired Sandwitch",
    Price = 3.0M,
    Quantity = 3,
    Expired = true
});
shopItems.Add(new ShopItem()
{
    Name = "Expired Sandwitch",
    Price = 3.0M,
    Quantity = 3,
    Expired = true
});

foreach (ShopItem item in shopItems)
{
    Console.WriteLine($"{item.Name}");
}
Console.WriteLine();
//using linq
shopItems.ForEach(item => Console.WriteLine($"{item.Name}"));
Console.WriteLine();

//Filter not expired products
List<ShopItem> notExpiredShopItems = new List<ShopItem>();
List<ShopItem> notExpiredItemsWithLinq = shopItems.Where(item => item.Expired == false).ToList();
notExpiredItemsWithLinq.ForEach(item => Console.WriteLine($"{item.Name}"));

//Select
//I Want to get all unique names
List<string> uniqueNames = new List<string>();
foreach (var shopItem in shopItems)
{
    var uniqueName = shopItem.Name;
    if (!uniqueNames.Contains(uniqueName))
    {
        uniqueNames.Add(uniqueName);
    }
}
List<string> uniqueNamesWithLinq = shopItems.Select(x => x.Name).Distinct().ToList();
uniqueNamesWithLinq.ForEach(name => Console.WriteLine($"{name}"));
Console.WriteLine();


// Get the first item by name that is not expired
ShopItem firstShopItem = shopItems.Where(s => !s.Expired).OrderBy(s => s.Name).First();

Console.WriteLine(firstShopItem.Name);
Console.WriteLine();

//Get the biggest quantity of an item
int largestQuantit = shopItems.OrderByDescending(s => s.Quantity).Select(s => s.Quantity).First();
Console.WriteLine(largestQuantit);

//Check if item named "Apple" exists
bool doesExist = shopItems.Any(si => si.Name.ToLower() == "Apple");

//Get FirstItem where Quantity is more than 100
ShopItem item1 = shopItems.Where(i => i.Quantity > 100).FirstOrDefault();