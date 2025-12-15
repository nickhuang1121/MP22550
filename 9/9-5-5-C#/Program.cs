Console.WriteLine("請點擊一個鍵盤按鍵：");
ConsoleKeyInfo keyPress;
keyPress = Console.ReadKey();
Console.WriteLine("你點擊了：" + keyPress.Key);