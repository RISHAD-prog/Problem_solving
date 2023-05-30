var kWeakestRows = function (mat, k) {
    let count = 0;
    let minPrevious;
    let minPreviousIndex;
    let maxPreviousIndex;
    let maxPrevious;
    let element;
    let result = [];
    let value = [];
    let array = [];
    let arr2 = [];
    for (const element of mat) {
        count = 0;
        for (let j = 0; j < element.length; j++) {
            if (element[j] === 1) {
                count += 1;
            }
        }
        // 
        array.push(count);
    }
    element = [...array];
    console.log(element);
    // arr2.push(array);
    // let i = 0;
    // for (let j = i + 1; j <= array.length; j++) {
    //     if (j === array.length && value.length + arr2.length < array.length) {
    //         value = [...value, i];
    //     }
    //     else if (j < array.length) {
    //         if (array[i] > array[j]) {
    //             if (minPrevious && minPrevious > array[j]) {
    //                 value.unshift(j);
    //                 minPrevious = array[j];
    //                 minPreviousIndex = j;
    //             }
    //             else if (minPrevious === array[j] || minPrevious < array[j]) {
    //                 let index = value.indexOf(minPreviousIndex);
    //                 value.splice(index + 1, 0, j);
    //                 minPreviousIndex = j;
    //             }
    //             // else if (minPrevious < array[j]) {
    //             //     let index = value.indexOf(minPreviousIndex);
    //             //     value.splice(index + 1, 0, j);
    //             //     minPreviousIndex = j;
    //             // }
    //             else {
    //                 value = [...value, j];
    //                 minPrevious = array[j];
    //                 minPreviousIndex = j;
    //             }
    //         }
    //         else if (array[i] === array[j]) {
    //             if (element >= 1) {
    //                 value = [...value, j]
    //             }
    //             else {
    //                 value.push(...[i, j]);
    //                 element += 1;
    //                 minPrevious = array[j];
    //             }
    //         }
    //         else {
    //             if (maxPrevious && maxPrevious < array[j]) {
    //                 arr2.push(j);
    //                 maxPrevious = array[j];
    //                 maxPreviousIndex = j;
    //             }
    //             // else if (maxPrevious === array[j]) {
    //             //     arr2 = [...arr2, j];
    //             // }
    //             else if (maxPrevious > array[j] || maxPrevious === array[j]) {
    //                 let index = arr2.indexOf(maxPreviousIndex);
    //                 if (index > 0) {
    //                     arr2.splice(index - 1, 0, j);
    //                 }
    //                 else {
    //                     arr2.splice(0, 0, j);
    //                 }
    //                 maxPreviousIndex = j;
    //             }
    //             else {
    //                 maxPrevious = array[j];
    //                 arr2.push(j);
    //                 maxPreviousIndex = j;
    //             }
    //         }
    //     }
    // }
    // return value.concat(arr2).slice(0, k);


    element.sort(function (a, b) { return a - b });
    console.log(element.length);
    for (let index = 0; index < element.length; index++) {
        value[index] = element[index];
        let arr = array.indexOf(value[index]);
        result.push(arr);
    }
    return result;
};
const mat =
    [[1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]];
const k = 6;
console.log(kWeakestRows(mat, k));