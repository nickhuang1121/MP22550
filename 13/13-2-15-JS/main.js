function GameLoop() {
    Opcode = Memory[PC] << 8 | Memory[PC + 1];
    PC += 2;
    ExecCode();
}
