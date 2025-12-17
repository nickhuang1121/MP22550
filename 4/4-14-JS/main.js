const iLoveTheseMotor = {
    [Symbol("Honda")]: "CB750",
    [Symbol("Kawasaki")]: "H2",
    [Symbol("Honda")]: "CB300R",
}
console.log(iLoveTheseMotor);
const buyMotorList = Object.getOwnPropertySymbols(iLoveTheseMotor).map(brand =>
    iLoveTheseMotor[brand]);
console.log(buyMotorList);