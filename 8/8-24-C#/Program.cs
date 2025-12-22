Juice juice = new Juice();
juice.Name = " 柳橙汁";
juice.Say();
class Juice
{
    private string Name = " 蘋果汁";
    public void Say()
    {
        Console.WriteLine(" 我們有賣" + Name);
    }
}