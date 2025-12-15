int[] numberList = [31, 20, 99, 41, 74, 91];
int totalNumber = 0;
for (int i = 0; i < 6; i++)
{
    if (numberList[i] % 2 == 0)
    {
        totalNumber += numberList[i];
    }
}
Console.WriteLine($"偶數總合：{totalNumber}");