int Opcode = 0;
int PC = 0;
byte[] Memory = { 0b10010, 0b100101 };

void ExecCode()
{
    Console.WriteLine($"{Opcode:X}");
}
void GameLoop()
{
    Opcode = Memory[PC] << 8 | Memory[PC + 1];
    PC += 2;
    ExecCode();
}
GameLoop();


