const demoArray = [1, 2, 3, 4, 5];
const newArray = demoArray.filter(ele => {
    return ele > 3;
})
console.log("demoArray:", demoArray);
console.log("newArray", newArray);