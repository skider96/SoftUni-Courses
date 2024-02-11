function commonElements (firstArray, secondArray) {
  for (let i = 0; i < firstArray.length; i++) {
    for (let j = 0; j < secondArray.length; j++) {
      if (secondArray[j] === firstArray[i]) {
        console.log(firstArray[i])
      }
    }
  }
}

// commonElements(
//   ['S', 'o', 'f', 't', 'U', 'n', 'i', ' '],
//   ['s', 'o', 'c', 'i', 'a', 'l']
// )
