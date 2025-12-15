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
            break;
    }
}
string type = "+";
int num1 = 10;
int num2 = 2;
int result = easyCalculator(type, num1, num2);
Console.WriteLine($"{num1}{type}{num2}={result}");
