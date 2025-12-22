let numberList = [31, 20, 99, 41, 74, 91];
let totalNumber = 0;
for (let i = 0; i < 6; i++) {
    if (numberList[i] % 2 == 0) {
        totalNumber += numberList[i];
    }
}
console.log(` 偶數總合：${totalNumber}`);