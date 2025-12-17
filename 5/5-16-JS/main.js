let numberA = [10, 11, 12];
let studentA = ["Nick", "Mary", "Ian", numberA];
let studentB = studentA.concat([]);
numberA[0] = 99;
console.log("numberA 陣列被更改後");
console.log("studentA 內容:", studentA);
console.log("studentB 內容:", studentB);