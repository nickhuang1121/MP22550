Juice juice = new Juice();
juice.Say();
class Juice
{
    protected string Name = " 蘋果汁";

    public void Say()
    {
        Console.WriteLine(" 我們有賣" + Name);
    }
}
class NewJuice : Juice
{
    public NewJuice()
    {
        Name = " 柳橙汁";
    }
}