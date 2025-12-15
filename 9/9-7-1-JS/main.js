function easyCalculator(type, num1, num2) {
    switch (type) {
        case "+":
            return num1 + num2;
            break;
        case "-":
            return num1 - num2;
            break;
        case "*":
            return num1 * num2;
            break;
        case "/":
            return num1 / num2;
            break;
    }
}
let type = prompt("請輸入+-*/");
let num1 = Number(prompt("請輸入數字"));
let num2 = Number(prompt("請輸入數字"));
let result = easyCalculator(type, num1, num2);
console.log(`你輸入了${type}  數字${num1}  數字${num2}`);
console.log(`${num1}${type}${num2}=${result}`);
