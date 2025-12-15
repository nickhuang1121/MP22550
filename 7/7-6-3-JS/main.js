let numberList = [10, 20, 30, 40, 50, 60];
let totalNumber = 0;
let min = 999;
let max = 0;
for (let i = 0; i < 6; i++) {
    totalNumber += numberList[i];
    if (numberList[i] > max) {
        max = numberList[i];
    }
    if (numberList[i] < min) {
        min = numberList[i];
    }
}
console.log(`總合：${totalNumber}`);
console.log(`最大：${max}`);
console.log(`最小：${min}`);
