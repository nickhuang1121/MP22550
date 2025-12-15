int orderJuice(int price1, int price2)
{
    int finalPrice = price1 + price2;
    return finalPrice; //回傳int型別的值
}
bool isMember = true;
int price = orderJuice(50, 55);

if (isMember == true)
{
    Console.WriteLine("你是會員，售價會打95折，價格是：" + (int)(price * 0.95));
}
else
{
    Console.WriteLine("因為你不是會員，因此價格是：", price);
}
