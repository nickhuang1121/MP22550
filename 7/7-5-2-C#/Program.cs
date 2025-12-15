Console.WriteLine("我要買50杯果汁");
int nowJuiceLength = 0;
while (nowJuiceLength < 50)
{
    Console.WriteLine("製作果汁");
    nowJuiceLength = nowJuiceLength + 1;
    if (nowJuiceLength == 25)
        break;
}
Console.WriteLine("我還是只買25杯好了");