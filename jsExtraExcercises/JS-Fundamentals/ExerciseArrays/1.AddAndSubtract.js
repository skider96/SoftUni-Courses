function changeValue (numbers) {
  let modifiedArray = numbers.map((number, i) => {
    return number % 2 === 0 ? number + i : number - i
    // if (number[i] % 2 == 0) number[i] += i
    // else number[i] -= 1
  })

  let sumOriginalArray = numbers.reduce((sum, number) => sum + number)
  let sumModifiedArray = modifiedArray.reduce((sum, number) => sum + number)
  console.log(modifiedArray)
  console.log(sumOriginalArray)
  console.log(sumModifiedArray)
}
//changeValue([5, 15, 23, 56, 35])
