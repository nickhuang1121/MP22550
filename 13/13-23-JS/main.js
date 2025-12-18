let Opcode = null;
let PC = 0;
const Memory = new Uint8Array(2);
Memory[0] = 0b10010;
Memory[1] = 0b100101;
function ExecCode() {
    console.log(Opcode.toString(16));
}
function GameLoop() {
    Opcode = Memory[PC] << 8 | Memory[PC + 1];
    PC += 2;
    ExecCode();
}
GameLoop();