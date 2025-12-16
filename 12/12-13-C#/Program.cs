byte[] Memory = new byte[4096];
int FileSize = 0;
void loadRom()
{
    var fs = new FileStream("./INVADERS", FileMode.Open);
    FileSize = (int)fs.Length;
    fs.ReadExactly(Memory, 0, FileSize);
}
loadRom();