function charsInRange(firstChar, secondChar) {
    let firstNumber = firstChar.charCodeAt(0);
    let secondNumber = secondChar.charCodeAt(0);

    for (let i = firstNumber + 1; i < secondNumber; i++) {
        console.log(String.fromCharCode(i));
    }
}

charsInRange('a', 'd')

