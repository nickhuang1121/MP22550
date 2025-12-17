let studentA = ["Nick", "Mary", "Ian"];
let studentB = studentA;
console.log("studentA 內容:", studentA);
console.log("studentB 內容:", studentB);
studentA[0] = "Sunny";
console.log("studentA 陣列被更改後");
console.log("studentA 內容:", studentA);
console.log("studentB 內容:", studentB);