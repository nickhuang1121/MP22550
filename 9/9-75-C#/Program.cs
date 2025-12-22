string dateString1 = "2025-09-04";
DateTime date1 = Convert.ToDateTime(dateString1);
Console.WriteLine($"{dateString1} 的轉換結果：{date1}");

string dateString2 = "04/09/2025 11:22:25 PM";
DateTime date2 = Convert.ToDateTime(dateString2);
Console.WriteLine($"{dateString2} 的轉換結果：{date2}");