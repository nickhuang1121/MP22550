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
let type = "+";
let num1 = 10;
let num2 = 2;
let result = easyCalculator(type, num1, num2);
console.log(`${num1}${type}${num2}=${result}`);
