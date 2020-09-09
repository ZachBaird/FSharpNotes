let tupledAdd(a, b) = a + b
let answer = tupledAdd(5, 3)

printf "Tupled Answer: %d" answer

let curriedAdd a b = a + b
let answer2 = curriedAdd 2 7

printf "Curried Answer: %d" answer2

// Partial function application with a curried function.
let add first second = first + second

// We created a new function off of `add` with only half the parameters declared.
let addFive = add 5
let fifteen = addFive 10