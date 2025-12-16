let Memory = new Uint8Array(4096);
let FileSize = 0;
function loadROM() {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", "./INVADERS", true);
    xhr.responseType = "arraybuffer";
    xhr.onload = function (e) {
        console.log(this.response);
    };
    xhr.send();
};
loadROM();