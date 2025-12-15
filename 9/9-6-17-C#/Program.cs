object aString = "Hello World";
if (aString is string)
{
    Console.WriteLine("aString是字串.");
}

object aString2 = 123;
if (!(aString2 is string))
{
    Console.WriteLine("aString2不是字串.");
}
