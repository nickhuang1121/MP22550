let studentA = ["Nick", "Mary", "Ian"];
let studentB = studentA.concat([]);
console.log("studentA內容:", studentA);
console.log("studentB內容:", studentB);
studentA[0] = "Sunny";
console.log("studentA陣列被更改後");
console.log("studentA內容:", studentA);
console.log("studentB內容:", studentB);