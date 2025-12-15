const arrayDemo = ["Demo", "World", true];
console.log("splice前：", arrayDemo);
arrayDemo.splice(1, 2, "Nice", 3.14, "Buy");
console.log("splice後：", arrayDemo);