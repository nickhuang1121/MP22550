List<Juice> juices = new List<Juice> {
 new Juice { Id = 1, Name = " 布丁奶茶", Price = 60 },
 new Juice { Id = 2, Name = " 錫蘭紅茶", Price = 45 },
 new Juice { Id = 3, Name = " 布丁奶茶", Price = 60 },
 };
List<Juice> findJuices = juices.FindAll(p => p.Name == " 布丁奶茶");

foreach (Juice item in findJuices)
{
    Console.WriteLine($"Id:{item.Id} {item.Name}");
}
public class Juice
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}