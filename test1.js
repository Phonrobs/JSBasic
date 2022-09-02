var n
var x
var result = 0

for (n = 1; n <= 10000; n++) {
    x = n % 3

    if (x == 0) {
        result++
    }
}

console.log(result)