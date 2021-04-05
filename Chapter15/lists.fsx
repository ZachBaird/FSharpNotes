let numbers = [ 1; 2; 3; 4; 5; 6 ]
let numbersQuick = [ 1..6 ]

let head :: tail = numbers

let numbersWithZero = 0 :: numbers
let evenMoreNumbers = numbersWithZero @ [ 7..9 ]
let evenMoreNumbersTest = numbersWithZero @ [ 7 ]