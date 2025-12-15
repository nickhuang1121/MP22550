const int MEMORY_START_ADDRESS = 0x200;
byte[] Memory = new byte[4096];
ushort PC = MEMORY_START_ADDRESS;
ushort Opcode = 0;
void ExecCode() { }
void GameLoop()
{
    Opcode = (ushort)(Memory[PC] << 8 | Memory[PC + 1]);
    PC += 2;
    ExecCode();
}
