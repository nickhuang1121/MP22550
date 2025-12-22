let juiceName = [" 柳橙多多", " 蘋果汁", " 芭樂美眉", " 火龍果凍茶"];
let juicePrice = [50, 50, 60, 65];

let orderJuice = " 芭樂美眉";

for (let i = 0; i < juiceName.length; i++) {
    if (orderJuice == juiceName[i]) {
        console.log(juiceName[i] + " 售價是" + juicePrice[i] + " 元!");
        break;
    }
}