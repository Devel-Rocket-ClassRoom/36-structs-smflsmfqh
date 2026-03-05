using System;

InventoryItem[] items = new InventoryItem[5];

items[0] = new InventoryItem("검", 3.5, 1500);
items[1] = new InventoryItem("방패", 5.0, 1200);
items[2] = new InventoryItem("포션", 0.3, 50);
items[3] = new InventoryItem("활", 1.8, 1300);
items[4] = new InventoryItem("투구", 2.0, 800);

Console.WriteLine("=== 인벤토리 목록 ===");
foreach  (InventoryItem item in items)
{
    item.PrintInvenInfo();
}
Console.WriteLine();
Console.WriteLine("=== 인벤토리 통계 ===");
StaticsItem(items);

void StaticsItem(InventoryItem[] items)
{
    double totalWeight = 0;
    int totalPrice = 0;
    int maxPrice = int.MinValue;
    double minWeight = double.MaxValue;
    double averagePrice = 0;
    string mostExpensive = string.Empty;
    string mostWeight = string.Empty;

    for (int i = 0; i < items.Length; i++)
    {
        totalWeight += items[i].Weight; 
        totalPrice += items[i].Price;

        if (maxPrice < items[i].Price)
        {
            maxPrice = items[i].Price;
            mostExpensive = items[i].Name;
        }
        if (minWeight > items[i].Weight)
        {
            minWeight = items[i].Weight;
            mostWeight = items[i].Name;
        }
    }
    averagePrice = totalPrice / (double)items.Length;

    Console.WriteLine($"전체 무게: {totalWeight:F1}");
    Console.WriteLine($"전체 가격: {totalPrice}골드");
    Console.WriteLine($"평균 가격: {averagePrice}골드");
    Console.WriteLine($"가장 비싼 아이템: {mostExpensive}");
    Console.WriteLine($"가장 가벼운 아이템: {mostWeight}");
}