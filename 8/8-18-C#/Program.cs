int orderJuice(int price1, int price2)
{
    int finalPrice = price1 + price2;
    if (finalPrice >= 100)
    {
        finalPrice = (int)(finalPrice * 0.9);
    }
    return finalPrice;
}

int price = orderJuice(50, 55);
Console.WriteLine(" 果汁價格是:" + price);