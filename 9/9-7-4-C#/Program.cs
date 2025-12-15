void checkBMI(double BMI)
{
    if (BMI < 18.5)
    {
        Console.WriteLine("太輕了!");

    }
    else if (BMI >= 18.5 && BMI < 24)
    {
        Console.WriteLine("剛剛好，可以吃雞排了!");

    }
    else if (BMI >= 24 && BMI < 27)
    {
        Console.WriteLine("過重，半糖奶茶改少糖奶茶!");

    }
    else
    {
        Console.WriteLine("肥胖，先吃塊披薩為明天減肥儲備體力!");
    }
}
Console.WriteLine("請輸入身高");
double userHeight = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("請輸入體重");
double userWeight = Convert.ToInt64(Console.ReadLine());
double BMI = userWeight / ((userHeight * 0.01) * (userHeight * 0.01));
checkBMI(BMI);
