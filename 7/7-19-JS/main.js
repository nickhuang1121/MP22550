console.log(" 我要買50 杯果汁");
let nowJuiceLength = 0;
while (nowJuiceLength < 50) {
    console.log(" 製作果汁");
    nowJuiceLength = nowJuiceLength + 1;
    if (nowJuiceLength == 25)
        break;
}
console.log(" 我還是只買25 杯好了");