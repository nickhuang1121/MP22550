class Juice {
    constructor(name, juiceBase, mix, suger, price) {
        this.Name = name;
        this.JuiceBase = juiceBase;
        this.Mix = mix;
        this.Suger = suger;
        this.Price = price;
    }
    Say() {
        console.log(`${this.Name} ${this.Suger} ${this.Price}元`);
    }
    PriceUp() {
        this.Price += 5;
    }
}
class BottledJuice extends Juice {
    constructor(name, juiceBase, mix, suger, price, size, packageColor) {
        super(name, juiceBase, mix, suger, price);
        this.Size = size;
        this.PackageColor = packageColor;
    }
    Say() {
        console.log(`${this.Name} ${this.Suger} ${this.Price}元 容量${this.Size}ml 包裝顏色:${this.PackageColor}`);
    }
}
const juice = new Juice("鮮奶茶", "紅茶", "鮮奶", "半糖", 60);
juice.Say();
const bottledJuice = new BottledJuice("葡萄多多", "葡萄汁", "養樂多", "少糖", 70, 500, "紅色");
bottledJuice.PriceUp();
bottledJuice.Say();
