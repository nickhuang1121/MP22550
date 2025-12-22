int easyCalculator(string type, int num1, int num2)
{
    switch (type)
    {
        case "+":
            return num1 + num2;
            break;
        case "-":
            return num1 - num2;
            break;
        case "*":
            return num1 * num2;
            break;
        case "/":
            return num1 / num2;
            break;
        default:
            return 0;
    }
}
Console.WriteLine(" 請輸入+-*/");
string type = Console.ReadLine();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = easyCalculator(type, num1, num2);
Console.WriteLine($" 你輸入了{type} 數字{num1} 數字{num2}");
Console.WriteLine($"{num1}{type}{num2}={result}");