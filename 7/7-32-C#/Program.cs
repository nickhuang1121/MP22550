string[] juiceName = { " 柳橙多多", " 蘋果汁", " 芭樂美眉", " 火龍果凍茶" };
byte[] juicePrice = { 50, 50, 60, 65 };

string orderJuice = " 芭樂美眉";
int finalPrice = 0;
for (byte i = 0; i < juiceName.Length; i++)
{
    if (orderJuice == juiceName[i])
    {
        if (juicePrice[i] >= 55)
        {
            finalPrice = (int)(juicePrice[i] * 0.9);
        }
        else
        {
            finalPrice = juicePrice[i];
        }
        Console.WriteLine(juiceName[i] + " 售價是" + finalPrice + " 元!");
        break;
    }
}