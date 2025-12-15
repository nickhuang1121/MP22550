string[] juiceName = { "柳橙多多", "蘋果汁", "芭樂美眉", "火龍果凍茶" };
byte[] juicePrice = { 50, 50, 60, 65 };

string orderJuice = "芭樂美眉";

for (byte i = 0; i < juiceName.Length; i++)
{
    if (orderJuice == juiceName[i])
    {
        Console.WriteLine(juiceName[i] + "售價是" + juicePrice[i] + "元!");
        break;
    }
}
