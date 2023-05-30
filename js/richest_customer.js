var maximumWealth = function (accounts) {
    let array = [];
    let sum = 0;
    for (const element of accounts) {

        for (let j = 0; j < element.length; j++) {
            if (j < element.length) {
                sum = sum + element[j];
                if (j === element.length - 1) {
                    array.push(sum);
                    sum = 0;
                }
            }
        }
    }
    array.sort((a, b) => b - a);
    return array[0];
};

const data = maximumWealth([[1, 5], [7, 3], [3, 5]]);
console.log(data);