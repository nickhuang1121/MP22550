function orderJuice(price1, price2) {
    let finalPrice = price1 + price2;
    if (finalPrice >= 100) {
        finalPrice = finalPrice * 0.9;
    }
    return finalPrice;
}

let price = orderJuice(50, 55);
console.log("果汁價格是:", price);
