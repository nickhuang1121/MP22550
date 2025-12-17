int[] demoArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine(" 陣列反轉前:" + string.Join(",", demoArray));
Array.Reverse(demoArray);
Console.WriteLine(" 陣列反轉後:" + string.Join(",", demoArray));