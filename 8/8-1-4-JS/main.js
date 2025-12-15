function orderJuice(price1, price2) {
    let finalPrice = price1 + price2;
    if (finalPrice >= 100) {
        finalPrice = finalPrice * 0.9;
    }
    console.log("果汁價格是:", finalPrice);
}
orderJuice(50, 55);
orderJuice(60, 55);
orderJuice(55, 65);
orderJuice(40, 50);
orderJuice(60, 45);
orderJuice(40, 40);
orderJuice(55, 55);
