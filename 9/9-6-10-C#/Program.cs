string aString = "123,45";
System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("fr-FR");
decimal decimalResule = Convert.ToDecimal(aString, culture);
Console.WriteLine($"金額是：{decimalResule}");
