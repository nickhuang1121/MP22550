int number = 100;
byte byteResult = Convert.ToByte(number);
Console.WriteLine($"{number}轉換成byte結果為{byteResult}");

number = 300; //配合try{}catch{}捕捉錯誤
try
{
    byteResult = Convert.ToByte(number);
    Console.WriteLine($"{number}轉換成byte結果為{byteResult}");
}
catch (OverflowException)
{
    Console.WriteLine($"{number}超過byte可以儲存的長度");
}
