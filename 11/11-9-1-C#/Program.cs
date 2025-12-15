using System.Text;
using (FileStream fs = File.Create("newFile.txt"))
{
    byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");
    fs.Write(info, 0, info.Length);
}