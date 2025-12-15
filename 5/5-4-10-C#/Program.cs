List<string> juices = new List<string> { "葡萄多多", "布丁奶茶", "紅牛綠茶", "冰淇淋紅茶", "布丁奶茶" };
string findJuice = juices.Find(name => name == "布丁奶茶");
Console.WriteLine(findJuice);
