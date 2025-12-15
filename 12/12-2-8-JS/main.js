let Memory = new Uint8Array(4096);
let FileSize = 0;
function loadROM() {
    const xhr = new XMLHttpRequest();
    xhr.open("GET", "./INVADERS", true);
    xhr.responseType = "arraybuffer";
    xhr.onload = function (e) {
        let view = new Uint8Array(this.response);
        FileSize = this.response.byteLength;
        for (let i = 0; i < FileSize; i++) {
            Memory[i] = view[i];
        };
    };
    xhr.send();
};
loadROM();
