﻿let numbersArray = [| 1; 2; 3; 4; 5 |]

let firstNumber = numbersArray.[0]
let firstThreeNumbers = numbersArray.[0..2]

// Mutating a position in an array
numbersArray.[0] <- 99