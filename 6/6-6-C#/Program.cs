string wantToEat = " 天婦羅";

switch (wantToEat)
{
    case " 小籠包":
        Console.WriteLine(" 我想吃小籠包!");
        break;
    case " 泡麵":
        Console.WriteLine(" 我想吃泡麵!");
        break;
    case " 天婦羅":
        Console.WriteLine(" 我想吃天婦羅!");
    //此行因為缺少 break; 所以會直接無法執行
    case " 巧克力":
        Console.WriteLine(" 我想吃巧克力!");
        break;
    case " 冰淇淋":
        Console.WriteLine(" 我想吃冰淇淋!");
        break;
    default:
        Console.WriteLine(" 都不要吃");
        break;
}

