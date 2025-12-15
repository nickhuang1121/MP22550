function A(Parameter) {
    let str1 = "Hello";
    let str2 = " World";
    Parameter(str1, str2);
}
function B(word1, word2) {
    console.log("B函式:", word1, word2)
}
A(B);
