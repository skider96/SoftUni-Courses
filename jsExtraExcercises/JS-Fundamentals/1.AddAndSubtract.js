function modifyArray (numbers) {
  let modifiedArray = numbers.map((number, index) => {
    if (number % 2 === 0) {
      // Ако числото е четно, добави му индекса
      return number + index
    } else {
      // Ако числото е нечетно, извади индекса
      return number - index
    }
  })

  // Оригинален масив
  console.log('Original array: ' + numbers.join(', '))

  // Сума на числата от оригиналния масив
  let originalSum = numbers.reduce((acc, curr) => acc + curr, 0)
  console.log('Sum of original numbers: ' + originalSum)

  // Модифициран масив
  console.log('Modified array: ' + modifiedArray.join(', '))

  // Сума на числата от модифицирания масив
  let modifiedSum = modifiedArray.reduce((acc, curr) => acc + curr, 0)
  console.log('Sum of modified numbers: ' + modifiedSum)
}

// Пример на използване
let numbers = [1, 2, 3, 4, 5];
modifyArray(numbers)
