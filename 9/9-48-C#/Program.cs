double angleDegrees = 45;
double angleRadians = angleDegrees * (Math.PI / 180);
double sin = Math.Sin(angleRadians);
double cos = Math.Cos(angleRadians);
double tan = Math.Tan(angleRadians);
Console.WriteLine($" 角度：{angleDegrees}\n 弧度：{angleRadians}\nMath.sin：{sin}\nMath.cos：{cos}\nMath.tan：{tan}");