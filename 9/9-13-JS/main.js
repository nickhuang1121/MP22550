let angleDegrees = 45;
let angleRadians = angleDegrees * (Math.PI / 180);
let sin = Math.sin(angleRadians);
let cos = Math.cos(angleRadians);
let tan = Math.tan(angleRadians);
console.log(`
    角度：${angleDegrees}
    弧度：${angleRadians}
    Math.sin：${sin}
    Math.cos：${cos}
    Math.tan：${tan}
`)
