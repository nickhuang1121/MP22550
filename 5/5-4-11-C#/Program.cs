List<Juice> juices = new List<Juice> {
     new Juice { Id = 1, Name = "布丁奶茶", Price = 60 },
     new Juice { Id = 2, Name = "錫蘭紅茶", Price = 45 },
     new Juice { Id = 3, Name = "布丁奶茶", Price = 60 },
      };
Juice findJuice = juices.Find(p => p.Name == "布丁奶茶");
Console.WriteLine($"findJuice的Id：{findJuice.Id}");
Console.WriteLine($"飲料名稱{findJuice.Name}");

public class Juice
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}