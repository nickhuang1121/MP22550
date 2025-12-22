Order order = new Order();
order.Say();
class Order
{
    private string ItemName()
    {
        return " 蘋果汁";
    }
    public void Say()
    {
        Console.WriteLine(" 我們有賣:" + ItemName());
    }
}