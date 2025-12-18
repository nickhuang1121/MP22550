using Raylib_cs;
const int MEMORY_START_ADDRESS = 0x200;
bool[] Keyboard = new bool[16];
bool[] Pixels = new bool[32 * 64];
byte[] Fontset =
    {
         0xf0, 0x90, 0x90, 0x90, 0xf0, //0
         0x20, 0x60, 0x20, 0x20, 0x70, //1
         0xf0, 0x10, 0xf0, 0x80, 0xf0, //2
         0xf0, 0x10, 0xf0, 0x10, 0xf0, //3
         0x90, 0x90, 0xf0, 0x10, 0x10, //4
         0xf0, 0x80, 0xf0, 0x10, 0xf0, //5
         0xf0, 0x80, 0xf0, 0x90, 0xf0, //6
         0xf0, 0x10, 0x20, 0x40, 0x40, //7
         0xf0, 0x90, 0xf0, 0x90, 0xf0, //8
         0xf0, 0x90, 0xf0, 0x10, 0xf0, //9
         0xf0, 0x90, 0xf0, 0x90, 0x90, //A
         0xe0, 0x90, 0xe0, 0x90, 0xe0, //B
         0xf0, 0x80, 0x80, 0x80, 0xf0, //C
         0xe0, 0x90, 0x90, 0x90, 0xe0, //D
         0xf0, 0x80, 0xf0, 0x80, 0xf0, //E
         0xf0, 0x80, 0xf0, 0x80, 0x80 //F
     };

byte[] Memory = new byte[4096];
byte[] V = new byte[16];
ushort[] Stack = new ushort[16];
ushort I = 0;
byte Delay_timer = 0;
byte Sound_timer = 0;
ushort PC = MEMORY_START_ADDRESS;
byte SP = 0;
ushort Opcode = 0;
int FileSize = 0;

void execCode()
{
    ushort nnn = (ushort)(Opcode & 0x0FFF);
    byte n = (byte)(Opcode & 0x000F);
    byte x = (byte)((Opcode & 0x0F00) >> 8);
    byte y = (byte)((Opcode & 0x00F0) >> 4);
    byte kk = (byte)(Opcode & 0x00FF);

    switch (Opcode & 0xF000)
    {
        case 0x0000:
            switch (Opcode)
            {
                case 0x00E0:
                    for (int i = 0; i < 32 * 64; i++)
                    {
                        Pixels[i] = false;
                    }
                    break;
                case 0x00EE:
                    PC = Stack[SP];
                    SP--;
                    break;
            }
            break;
        case 0x1000:
            PC = nnn;
            break;
        case 0x2000:
            SP += 1;
            Stack[SP] = PC;
            PC = nnn;
            break;
        case 0x3000:
            if (V[x] == kk)
            {
                PC += 2;
            }
            break;
        case 0x4000:
            if (V[x] != kk)
            {
                PC += 2;
            }
            break;
        case 0x5000:
            if (V[x] == V[y])
            {
                PC += 2;
            }
            break;
        case 0x6000:
            V[x] = kk;
            break;
        case 0x7000:
            V[x] += kk;
            break;
        case 0x8000:
            switch (Opcode & 0x000F)
            {
                case 0x0000:
                    V[x] = V[y];
                    break;
                case 0x0001:
                    V[x] |= V[y];
                    break;
                case 0x0002:
                    V[x] &= V[y];
                    break;
                case 0x0003:
                    V[x] ^= V[y];
                    break;
                case 0x0004:
                    ushort tmp = (ushort)(V[x] + V[y]);
                    V[0xF] = 0;
                    if (tmp > 0xff)
                    {
                        V[0xF] = 1;
                    }
                    V[x] = (byte)tmp;
                    break;
                case 0x0005:
                    V[0x0F] = 0;
                    if (V[x] > V[y])
                    {
                        V[0x0f] = 1;
                    }
                    V[x] = (byte)(V[x] - V[y]);
                    break;
                case 0x0006:
                    V[0x0F] = (byte)(V[x] & 0b00000001);
                    V[x] /= 2;
                    break;
                case 0x0007:
                    V[0x0F] = (byte)(V[y] > V[x] ? 1 : 0);
                    V[x] = (byte)(V[y] - V[x]);
                    break;
                case 0x000E:
                    V[0x0F] = (byte)(V[x] & 0b10000000);
                    V[x] *= 2;
                    break;
            }
            break;
        case 0x9000:
            if (V[x] != V[y])
            {
                PC += 2;
            }
            break;
        case 0xA000:
            I = nnn;
            break;
        case 0xB000:
            PC = (ushort)(nnn + V[0]);
            break;
        case 0xC000:
            Random obj = new Random();
            V[x] = (byte)((obj.Next(0, 255)) & kk);
            break;
        case 0xD000:
            ushort posX = (ushort)(V[x] & 0x3F);
            ushort posY = (ushort)(V[y] & 0x1F);
            V[0xF] = 0;
            for (ushort col = 0; col < n; col++)
            {
                ushort sprite = Memory[I + col];
                for (ushort row = 0; row < 8; row++)
                {
                    if (Convert.ToBoolean((sprite >> (7 - row)) & 1))
                    {
                        ushort index = (ushort)(posX + row + ((posY + col) * 64));
                        if (index >= 2048)
                        {
                            index -= 2048;
                        }
                        if (Pixels[index])
                        {
                            V[0xF] = 1;
                        }
                        Pixels[index] ^= true;
                    }
                }
            }
            break;
        case 0xE000:
            switch (Opcode & 0x00FF)
            {
                case 0x009E:
                    if (Keyboard[V[x]])
                    {
                        PC += 2;
                    }
                    break;
                case 0x00A1:
                    if (!Keyboard[V[x]])
                    {
                        PC += 2;
                    }
                    break;
            }
            break;
        case 0xF000:
            switch (Opcode & 0x00FF)
            {
                case 0x0007:
                    V[x] = Delay_timer;
                    break;
                case 0x000A: //按鍵操作
                    if (Keyboard[0])
                    {
                        V[x] = 0;
                    }
                    else if (Keyboard[1])
                    {
                        V[x] = 1;
                    }
                    else if (Keyboard[2])
                    {
                        V[x] = 2;
                    }
                    else if (Keyboard[3])
                    {
                        V[x] = 3;
                    }
                    else if (Keyboard[4])
                    {
                        V[x] = 4;
                    }
                    else if (Keyboard[5])
                    {
                        V[x] = 5;
                    }
                    else if (Keyboard[6])
                    {
                        V[x] = 6;
                    }
                    else if (Keyboard[7])
                    {
                        V[x] = 7;
                    }
                    else if (Keyboard[8])
                    {
                        V[x] = 8;
                    }
                    else if (Keyboard[9])
                    {
                        V[x] = 9;
                    }
                    else if (Keyboard[10])
                    {
                        V[x] = 10;
                    }
                    else if (Keyboard[11])
                    {
                        V[x] = 11;
                    }
                    else if (Keyboard[12])
                    {
                        V[x] = 12;
                    }
                    else if (Keyboard[13])
                    {
                        V[x] = 13;
                    }
                    else if (Keyboard[14])
                    {
                        V[x] = 14;
                    }
                    else if (Keyboard[15])
                    {
                        V[x] = 15;
                    }
                    else
                    {
                        PC -= 2;
                    }
                    break;
                case 0x0015:
                    Delay_timer = V[x];
                    break;
                case 0x0018:
                    Sound_timer = V[x];
                    break;
                case 0x001E:
                    I += V[x];
                    break;
                case 0x0029:
                    I = (byte)(V[x] * 5);
                    break;
                case 0x0033:
                    Memory[I] = (byte)(V[x] / 100);
                    Memory[I + 1] = (byte)(V[x] / 10 % 10);
                    Memory[I + 2] = (byte)(V[x] % 10);
                    break;
                case 0x0055:
                    for (byte i = 0; i <= x; i++)
                    {
                        Memory[I + i] = V[i];
                    }
                    break;
                case 0x0065:
                    for (byte i = 0; i <= x; i++)
                    {
                        V[i] = Memory[I + i];
                    }
                    break;
            }
            break;
    }
}

void gameLoop()
{
    Raylib.InitWindow(640, 320, "Hello Raylib!");
    Raylib.SetTargetFPS(60);
    while (!Raylib.WindowShouldClose())
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);
        for (int i = 0; i < Pixels.Length; i++)
        {
            if (Pixels[i])
            {
                byte x = (byte)(i % 64);
                byte y = (byte)(i / 64);
                Raylib.DrawRectangle(x * 10, y * 10, 10, 10, Color.Green);
            }
        }
        if (Delay_timer > 0)
        {
            Delay_timer -= 1;
        }
        if (Sound_timer > 0)
        {
            Sound_timer -= 1;
            Console.Beep();
        }
        for (byte i = 0; i < 10; i++)
        {
            Opcode = (ushort)(Memory[PC] << 8 | Memory[PC + 1]);
            PC += 2;
            execCode();
        }
        Raylib.EndDrawing();
    }
    Raylib.CloseWindow();
}

void loadRom()
{
    var fs = new FileStream("./INVADERS", FileMode.Open);
    FileSize = (int)fs.Length;
    fs.ReadExactly(Memory, MEMORY_START_ADDRESS, FileSize);
    Array.Copy(Fontset, Memory, 80);
    gameLoop();
}
loadRom();

void chip8SpriteMove()
{
    if (Raylib.IsKeyDown(KeyboardKey.One))
    {
        Keyboard[1] = true;
    }
    if (Raylib.IsKeyUp(KeyboardKey.One))
    {
        Keyboard[1] = false;
    }
}
