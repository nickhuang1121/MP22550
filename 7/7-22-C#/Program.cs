Console.WriteLine(" 我要買5 杯果汁");
int nowJuiceLength = 0;
while (nowJuiceLength < 5)
{
    nowJuiceLength = nowJuiceLength + 1;
    if (nowJuiceLength == 3)
        continue;
    Console.WriteLine(" 果汁第" + nowJuiceLength + " 杯做好");
}