bool[] Keyboard = new bool[16];
bool[] Pixels = new bool[32 * 64];

byte[] Memory = new byte[4096];
int FileSize = 0;
void loadRom()
{
    var fs = new FileStream("./INVADERS", FileMode.Open);
    FileSize = (int)fs.Length;
    fs.ReadExactly(Memory, 0, FileSize);
    Console.WriteLine($" 第一個操作碼：{Memory[0]:X}{Memory[1]:X}");
    Console.WriteLine($" 容量為：{FileSize}kb");
}
loadRom();