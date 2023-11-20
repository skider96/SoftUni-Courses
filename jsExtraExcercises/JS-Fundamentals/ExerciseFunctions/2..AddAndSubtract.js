function sum (firstNumber, secondNumber) {
  let sumTwoNumbers = firstNumber + secondNumber
  return sumTwoNumbers
}
function subtract (firstNumber, secondNumber, thirdNumber) {
  let result = sum(firstNumber, secondNumber) - thirdNumber
  console.log(result)
}
subtract(1, 17, 30)
