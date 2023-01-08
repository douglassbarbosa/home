var input = require("fs").readFileSync("/dev/stdin", "utf8");
var lines = input.split("\n");

var raio = parseFloat(lines.shift());
var n = parseFloat(3.14159);
console.log("A=" + (raio * raio * n).toFixed(4));
