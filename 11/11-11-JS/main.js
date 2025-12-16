let numberA = new Uint8Array(1);
numberA[0] = 0b1000;
let result = new Uint8Array(1);
result[0] = numberA[0] << 5;
console.log(`原始：${numberA[0]} / 答案：${result[0]}`);