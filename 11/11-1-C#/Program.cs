byte[] numberList = new byte[2];
numberList[0] = 0b100000000; //ERROR，超過8bit，因此無法用byte儲存
numberList[1] = 0b10000000;
Console.WriteLine($"第一筆：{numberList[0]} / 第二筆：{numberList[1]}");