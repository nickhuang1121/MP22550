let Keyboard = new Array(16).fill(false);
let Pixels = new Array(32 * 64).fill(false);

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
        }
        console.log("第一個操作碼：", Memory[0].toString(16), Memory[1].toString(16));
        console.log("容量為：", FileSize, "kb")
    };
    xhr.send();
};
loadROM();
