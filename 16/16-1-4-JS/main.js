const canvas = document.querySelector("#canvas");
const ctx = canvas.getContext("2d");
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

let Memory = new Uint8Array(4096);
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
                default:
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
        case 0xC000:
            V[x] = Math.floor((Math.random() * 0xFF)) & kk;
            break;
        case 0xD000:
            let posX = (V[x] & 0x3F);
            let posY = (V[y] & 0x1F);
            V[0xF] = false;
            for (let col = 0; col < n; col++) {
                let sprite = Memory[I + col];
                for (let row = 0; row < 8; row++) {
                    if (((sprite >> (7 - row)) & 1)) {
                        let index = (posX + row + ((posY + col) * 64));
                        if (index >= 2048) {
                            index -= 2048
                        }
                        if (Pixels[index]) {
                            V[0xF] = true;
                        }
                        Pixels[index] ^= true;
                    }
                }
            }
            break;
        case 0xE000:
            switch (Opcode & 0x00FF) {
                case 0x009E:
                    if (Keyboard[V[x]]) {
                        PC += 2;
                    }
                    break;
                case 0x00A1:
                    if (!Keyboard[V[x]]) {
                        PC += 2;
                    }
                    break;
            }
            break;
        case 0xF000:
            switch (Opcode & 0x00FF) {
                case 0x0007:
                    V[x] = Delay_timer;
                    break;
                case 0x000A:
                    if (Keyboard[0]) {
                        V[x] = 0;
                    }
                    else if (Keyboard[1]) {
                        V[x] = 1;
                    }
                    else if (Keyboard[2]) {
                        V[x] = 2;
                    }
                    else if (Keyboard[3]) {
                        V[x] = 3;
                    }
                    else if (Keyboard[4]) {
                        V[x] = 4;
                    }
                    else if (Keyboard[5]) {
                        V[x] = 5;
                    }
                    else if (Keyboard[6]) {
                        V[x] = 6;
                    }
                    else if (Keyboard[7]) {
                        V[x] = 7;
                    }
                    else if (Keyboard[8]) {
                        V[x] = 8;
                    }
                    else if (Keyboard[9]) {
                        V[x] = 9;
                    }
                    else if (Keyboard[10]) {
                        V[x] = 10;
                    }
                    else if (Keyboard[11]) {
                        V[x] = 11;
                    }
                    else if (Keyboard[12]) {
                        V[x] = 12;
                    }
                    else if (Keyboard[13]) {
                        V[x] = 13;
                    }
                    else if (Keyboard[14]) {
                        V[x] = 14;
                    }
                    else if (Keyboard[15]) {
                        V[x] = 15;
                    }
                    else {
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
                    I = (V[x] * 5);
                    break;
                case 0x0033:
                    Memory[I] = V[x] / 100;
                    Memory[I + 1] = V[x] / 10 % 10;
                    Memory[I + 2] = V[x] % 10;
                    break;
                case 0x0055:
                    for (let i = 0; i <= x; i++) {
                        Memory[I + i] = V[i];
                    }
                    break;
                case 0x0065:
                    for (let i = 0; i <= x; i++) {
                        V[i] = Memory[I + i];
                    }
                    break;
            }
            break;
    }
}

function gameLoop() {
    ctx.fillStyle = "#000";
    ctx.fillRect(0, 0, 64 * 10, 32 * 10);
    ctx.fillStyle = "#00FF00";
    for (let i = 0; i < Pixels.length; i++) {
        if (Pixels[i]) {
            let x = Math.floor(i % 64);
            let y = Math.floor(i / 64);
            ctx.fillRect(x * 10, y * 10, 10, 10,);
        }
    }

    Opcode = Memory[PC] << 8 | Memory[PC + 1];
    PC += 2;
    execCode();
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
