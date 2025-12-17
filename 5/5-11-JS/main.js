const arrayDemo = ["Demo", "World", true];
console.log("splice 前：", arrayDemo);
arrayDemo.splice(1, 2, "Nice", 3.14, "Buy");
console.log("splice 後：", arrayDemo);