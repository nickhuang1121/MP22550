using (StreamReader sr = new StreamReader("book.txt"))
{
    string str;
    while ((str = sr.ReadLine()) != null)
    {
        Console.WriteLine(str);
    }
}
