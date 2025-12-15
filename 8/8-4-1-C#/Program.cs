SayWord Tom = new SayWord();
Tom.Say();
class SayWord
{
    private string HelloWorld()
    {
        return "Hello World";
    }
    public void Say()
    {
        Console.WriteLine(HelloWorld());
    }
}
