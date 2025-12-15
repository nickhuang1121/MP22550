function D() {
    return 1;
}
function C() {
    return D();
}
function B() {
    return C();
}
let A = B();
console.log(A);
