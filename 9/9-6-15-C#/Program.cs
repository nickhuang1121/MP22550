string string1 = "123";
int result1 = int.Parse(string1);
Console.WriteLine($"轉換成功{string1} 結果為：{result1}");

try //可以用try{}catch{}捕捉錯誤
{
    string string2 = "abc";
    int result2 = int.Parse(string2);
}
catch (FormatException ex)
{
    Console.WriteLine($"abc轉換錯誤訊息：{ex.Message}");
}
