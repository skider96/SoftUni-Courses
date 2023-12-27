function Rounding (firstNumber, secondNumber) {
  let numberRounded = Number(firstNumber)
  let precision = Number(secondNumber)

  if (precision > 15) {
    precision = 15
  }

  let multiplier = Math.pow(10, precision)

  let result = Math.round(numberRounded * multiplier) / multiplier
  resultString = result.toFixed(precision)

  resultNumber = parseFloat(result)
  console.log(resultNumber)
}
//Rounding(10.5,3 )
