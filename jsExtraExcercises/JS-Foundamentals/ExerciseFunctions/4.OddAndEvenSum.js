function sum(number) {
    let stringNumber = number.toString();

    let evenSum = 0;
    let oddSum = 0;
    for (let i = 0; i < stringNumber.length; i++) {
        let currentNumber = stringNumber[i];

        (currentNumber % 2 === 0)
            ? evenSum += parseInt(currentNumber)
            : oddSum += parseInt(currentNumber)
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

sum(1000435);
