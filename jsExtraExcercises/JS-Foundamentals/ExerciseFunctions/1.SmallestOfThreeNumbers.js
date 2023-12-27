function oneOfThree (firstNumber, secondNumber, thirdNumber) {
  var result =
    firstNumber < secondNumber ? (firstNumber < thirdNumber ? firstNumber : thirdNumber) : 
    (secondNumber < thirdNumber? secondNumber : thirdNumber);
  console.log(result)
}
//oneOfThree(2, 10, 7)
