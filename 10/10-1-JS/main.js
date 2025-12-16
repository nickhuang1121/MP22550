class Juice {
    constructor(name, juiceBase, mix, suger, price) {
        this.Name = name; //飲料名稱
        this.JuiceBase = juiceBase; //茶基底
        this.Mix = mix; //飲料配方
        this.Suger = suger; //糖
        this.Price = price; //價格
    }

    Say() {
        console.log(`${this.Name} ${this.Suger} ${this.Price}元`);
    }
    PriceUp() {
        this.Price += 5;
    }
}
const juice1 = new Juice("鮮奶茶", "紅茶", "鮮奶", "半糖", 60);
juice1.Say();
const juice2 = new Juice("葡萄多多", "葡萄汁", "養樂多", "少糖", 70);
juice2.PriceUp();
juice2.Say();
