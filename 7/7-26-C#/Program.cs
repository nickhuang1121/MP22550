int[] numberList = [10, 20, 30, 40, 50, 60];
int totalNumber = 0;
int min = 999;
int max = 0;
for (int i = 0; i < 6; i++)
{
    totalNumber += numberList[i];
    if (numberList[i] > max)
    {
        max = numberList[i];
    }
    if (numberList[i] < min)
    {
        min = numberList[i];
    }
}
Console.WriteLine($" 總合：{totalNumber}");
Console.WriteLine($" 最大：{max}");
Console.WriteLine($" 最小：{min}");