const MEMORY_START_ADDRESS = 0x200;
let Keyboard = new Array(16).fill(false);
let Pixels = new Array(32 * 64).fill(false);
const Fontset =
    [
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
    ];

let Memory = new Uint8Array(4096); //遊戲容量Uint8Array(4096)
let V = new Uint8Array(16);
let Stack = new Uint16Array(16);
let I = 0;
let Delay_timer = 0;
let Sound_timer = 0;
let PC = MEMORY_START_ADDRESS;
let SP = 0;
let Opcode = 0;
let FileSize = 0;
let fps = 60;

function execCode() {
    let nnn = Opcode & 0xFFF;
    let kk = Opcode & 0xFF;
    let n = Opcode & 0xF;
    let x = (Opcode & 0x0F00) >> 8;
    let y = (Opcode & 0x00F0) >> 4;
    switch (Opcode & 0xF000) {
        case 0x0000:
            switch (Opcode) {
                case 0x00E0:
                    for (let i = 0; i < 32 * 64; i++) {
                        Pixels[i] = false
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
            if (V[x] == kk) {
                PC += 2;
            }
            break;
        case 0x4000:
            if (V[x] != kk) {
                PC += 2;
            }
            break;
        case 0x5000:
            if (V[x] == V[y]) {
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
            switch (Opcode & 0x000F) {
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
                    let tmp = V[x] + V[y];
                    V[0xF] = false;
                    if (tmp > 0xff) {
                        V[0xF] = true;
                    }
                    V[x] = tmp;
                    break;
                case 0x0005:
                    V[0xF] = V[x] > V[y];
                    V[x] = V[x] - V[y];
                    break;
                case 0x0006:
                    V[0xF] = V[x] & 0b00000001;
                    V[x] /= 2;
                    break;
                case 0x0007:
                    V[0xF] = V[y] > V[x];
                    V[x] = V[y] - V[x];
                    break;
                case 0x000E:
                    V[0xF] = V[x] & 0b10000000;
                    V[x] *= 2;
                    break;
            }
            break;
        case 0x9000:
            if (V[x] != V[y]) {
                PC += 2;
            }
            break;
        case 0xA000:
            I = nnn;
            break;
        case 0xB000:
            PC = nnn + V[0];
            break;

    }
}

function gameLoop() {
    Opcode = Memory[PC] << 8 | Memory[PC + 1];
    PC += 2;
    setTimeout(gameLoop, 1000 / 60);
    console.log("操作碼：", Opcode.toString(16));
}

function saveToMemory(view) {
    for (let i = 0; i < 80; i++) {
        Memory[i] = Fontset[i];
    }
    for (let i = 0; i < FileSize; i++) {
        Memory[i + MEMORY_START_ADDRESS] = view[i];
    }
    gameLoop();
}

function loadROM() {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", "./INVADERS", true);
    xhr.responseType = "arraybuffer";
    xhr.onload = function (e) {
        let view = new Uint8Array(this.response);
        FileSize = this.response.byteLength;
        saveToMemory(view);
    };
    xhr.send();
};
loadROM();
