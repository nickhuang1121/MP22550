int nowJuiceLength = 50;
do
{
    Console.WriteLine("製作果汁");
    nowJuiceLength = nowJuiceLength + 1;
} while (nowJuiceLength < 50);
Console.WriteLine($"已經有{nowJuiceLength}杯果汁");
