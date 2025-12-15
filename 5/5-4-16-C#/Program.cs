List<Juice> juiceList = new List<Juice>
 {
     new Juice { Name = "甘蔗奶茶", Price = 50 },
     new Juice { Name = "阿薩姆奶茶", Price = 55 },
     new Juice { Name = "奶茶四兄弟", Price = 75 },
     new Juice { Name = "鮮奶茶", Price = 60 }
 };
Console.Write("Sort排序前：");
foreach (Juice juice in juiceList)
{
    Console.Write($"{juice.Name} {juice.Price}元、");
}
Console.WriteLine();
juiceList.Sort((juice1, juice2) => juice1.Price.CompareTo(juice2.Price));
Console.Write("Sort排序後：");
foreach (Juice juice in juiceList)
{
    Console.Write($"{juice.Name} {juice.Price}元、");
}
public class Juice
{
    public string Name { get; set; }
    public int Price { get; set; }
}
