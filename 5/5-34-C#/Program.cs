int[] demoArrayDestination = { 1, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
int[] demoArraySource = { 6, 7, 8, 9, 10 };
Array.Copy(demoArraySource, 0, demoArrayDestination, 5, 5);
Console.WriteLine(" 陣列複製後:" + string.Join(",", demoArrayDestination));