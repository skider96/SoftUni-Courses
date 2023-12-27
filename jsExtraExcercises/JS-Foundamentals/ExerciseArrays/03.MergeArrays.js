function mergeArrays (firstArray, secondArray) {
  const thirdArray = []
  for (let i = 0; i < firstArray.length; i++) {
    if (i % 2 === 0) {
      thirdArray.push(parseInt(firstArray[i]) + Number(secondArray[i]))
    } else {
      thirdArray.push(firstArray[i] + secondArray[i])
    }
  }
let newArray = thirdArray.join(" - ");
console.log(newArray);
}
/*mergeArrays(['5', '15', '23', '56', '35'],
 ['17', '22', '87', '36', '11']
 )*/