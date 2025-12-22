function orderJuice(price1, price2) {// price1與price2就是參數
    let finalPrice = price1 + price2;
    return finalPrice;
}
let isMember = true;
let price = orderJuice(50, 55);

if (isMember == true) {
    console.log("你是會員，售價會打95折，價格是：", price * 0.95);
} else {
    console.log("因為你不是會員，因此價格是：", price);
}
