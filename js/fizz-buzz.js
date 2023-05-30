const fizzBuzz = function (n) {
    let array = [];
    for (let index = 1; index <= n; index++) {

        if (index % 3 === 0 && index % 5 === 0) {
            let fizzbuzz = "FizzBuzz";
            array.push(fizzbuzz);
        }
        else if (index % 3 === 0) {
            let fizz = "Fizz";
            array.push(fizz);
        }
        else if (index % 5 === 0) {
            let buzz = "Buzz";
            array.push(buzz);
        }
        else {
            array.push(index.toString());
        }
    }
    return array;
}

const data = fizzBuzz(5);
console.log(data);