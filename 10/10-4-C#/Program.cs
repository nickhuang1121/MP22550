Juice juice = new Juice(" 鮮奶茶", " 紅茶", " 鮮奶", " 半糖", 60); juice.Say(); BottledJuice bottledJuice = new BottledJuice(" 葡萄多多", " 葡萄汁", " 養樂多",
" 少糖", 70, "red", 500); bottledJuice.PriceUp();
bottledJuice.Say(); public class Juice
{
    protected string Name { get; set; }
    protected string JuiceBase { get; set; }
    protected string Mix { get; set; }
    protected string Suger { get; set; }
    protected int Price { get; set; }

    public Juice(string name, string juiceBase, string mix, string suger, int
   price)
    {
        Name = name;
        JuiceBase = juiceBase;
        Mix = mix;
        Suger = suger;
        Price = price;
    }
    public virtual void Say()
    {
        Console.WriteLine($"{Name} {Suger} {Price} 元");
    }
    public void PriceUp()
    {
        Price += 5;
    }
}
public class BottledJuice : Juice
{
    private string PackageColor { get; set; }
    private int Size { get; set; }

    public BottledJuice(string name, string juiceBase, string mix, string suger,
   int price, string packageColor, int size) : base(name, juiceBase, mix, suger,
   price)
    {
        PackageColor = packageColor;
        Size = size;
    }
    public override void Say()
    {
        Console.WriteLine($"{Name} {Suger} {Price} 元 容量{Size}ml 包裝顏色:{PackageColor}");
    }
}