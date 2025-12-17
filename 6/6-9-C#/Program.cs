double userHeight = 165.0;
double userWeight = 90.0;
double BMI = userWeight / ((userHeight * 0.01) * (userHeight * 0.01));

if (BMI < 18.5)
{
    Console.WriteLine(" 太輕了!");
}
else if (BMI >= 18.5 && BMI < 24)
{
    Console.WriteLine(" 體重剛剛好，可以吃雞排!");
}
else if (BMI >= 24 && BMI < 27)
{
    Console.WriteLine(" 過重，半糖奶茶改少糖奶茶!");
}
else
{
    Console.WriteLine(" 肥胖，先吃塊披薩為明天減肥儲備體力!");
}