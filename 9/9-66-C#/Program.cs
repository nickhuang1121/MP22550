string newString = "123";
byte byteResult = Convert.ToByte(newString);
Console.WriteLine($"{newString} 轉換成byte 成功{byteResult}");

newString = "abc";// 配合try{}catch{} 捕捉錯誤
try
{
    byteResult = Convert.ToByte(newString);
    Console.WriteLine($"{newString} 轉換成byte 成功{byteResult}");
}
catch (FormatException)
{
    Console.WriteLine($"{newString} 無法轉換成byte");
}