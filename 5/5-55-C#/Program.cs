List<string> juiceList = new List<string> { "茉莉紅茶", "巧克力奶昔", "阿薩姆奶茶", "阿里山清茶" };
Console.Write("Reverse 反轉前：");
foreach (string juice in juiceList)
{
    Console.Write($"{juice}、");
}
juiceList.Reverse(1, 3);
Console.WriteLine();
Console.Write("Reverse 反轉後：");
foreach (string juice in juiceList)
{
    Console.Write($"{juice}、");
}