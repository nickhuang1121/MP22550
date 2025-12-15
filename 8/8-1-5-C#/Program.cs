void orderJuice(int price1, int price2)
{
    int finalPrice = price1 + price2;
    if (finalPrice >= 100)
    {
        finalPrice = (int)(finalPrice * 0.9);
    }
    Console.WriteLine("果汁價格是:" + finalPrice);
}
orderJuice(50, 55);
orderJuice(60, 55);
orderJuice(55, 65);
orderJuice(40, 50);
orderJuice(60, 45);
orderJuice(40, 40);
orderJuice(55, 55);
