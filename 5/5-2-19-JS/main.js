const demoArray = [1, 2, 5, 4, 3];
const total = demoArray.reduce((acc, cur) => {
    return acc + cur;
});
const max = demoArray.reduce((acc, cur) => {
    return acc > cur ? acc : cur;
});
const min = demoArray.reduce((acc, cur) => {
    return acc < cur ? acc : cur;
});
console.log("demoArray:", demoArray);
console.log("總合:", total);
console.log("最大數字:", max);
console.log("最小數字:", min);