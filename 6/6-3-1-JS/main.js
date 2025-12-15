let userHeight = 165;
let userWeight = 90;
let BMI = userWeight / ((userHeight * 0.01) * (userHeight * 0.01));

if (BMI < 18.5) {
    console.log("太輕了!");
} else if (BMI >= 18.5 && BMI < 24) {
    console.log("剛剛好，可以吃雞排了!");
} else if (BMI >= 24 && BMI < 27) {
    console.log("過重，半糖奶茶改少糖奶茶!");
} else {
    console.log("肥胖，先吃塊披薩為明天減肥儲備體力!");
}
