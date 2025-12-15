let number;
function baseLog(base, number) {
    return Math.log(number) / Math.log(base);
}
number = baseLog(2, 8);
console.log("以2為底求8的對數:", number);
number = baseLog(4, 64);
console.log("以4為底求64的對數:", number);
number = baseLog(10, 10000);
console.log("以10為底求10000的對數:", number);
