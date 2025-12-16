Juice juice1 = new Juice(" 鮮奶茶", " 紅茶", " 鮮奶", " 半糖", 60); juice1.Say(); Juice juice2 = new Juice(" 葡萄多多", " 葡萄汁", " 養樂多", " 少糖", 70); juice2.PriceUp(); juice2.Say(); public class Juice
{
    private string Name { get; set; }
    private string JuiceBase { get; set; }
    private string Mix { get; set; }
    private string Suger { get; set; }
    private int Price { get; set; }

    public Juice(string name, string juiceBase, string mix, string suger, int
   price)
    {
        Name = name;
        JuiceBase = juiceBase;
        Mix = mix;
        Suger = suger;
        Price = price;
    }
    public void Say()
    {
        Console.WriteLine($"{Name} {Suger} {Price} 元");
    }
    public void PriceUp()
    {
        Price += 5;
    }
}