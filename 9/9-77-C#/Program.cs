string string1 = "123";
int result1;
if (int.TryParse(string1, out result1))
{
    Console.WriteLine($" 轉換成功{string1} 結果為：{result1}");
}
else
{
    Console.WriteLine($" 轉換失敗{string1} 結果為：{result1}");
}

string string2 = "ABC";
int result2;
if (int.TryParse(string2, out result2))
{
    Console.WriteLine($" 轉換成功{string2} 結果為：{result2}");
}
else
{
    Console.WriteLine($" 轉換失敗{string2} 結果為：{result2}");
}