let number = new Uint8Array(1);
number[0] = 0b00001000;
let result1 = new Uint8Array(1);
result1[0] = number[0] << 4;
let result2 = new Uint8Array(1);
result2[0] = number[0] >> 2;
console.log(`result1：${result1[0]}`);
console.log(`result2：${result2[0]}`);