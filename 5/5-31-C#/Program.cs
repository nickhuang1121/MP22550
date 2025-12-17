int[] demoArray = { 5, 6, 3, 1, 2, 8, 9, 4, 3, 7 };
Console.WriteLine(" 陣列排序前:" + string.Join(",", demoArray));
Array.Sort(demoArray);
Console.WriteLine(" 陣列排序後:" + string.Join(",", demoArray));