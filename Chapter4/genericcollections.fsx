open System.Collections.Generic

let numbers = List<_>()
numbers.Add(10)
numbers.Add(25)

let otherNumbers = List()
otherNumbers.Add(5)
otherNumbers.Add(11)

let createList(first, second) =
    let output = List()
    output.Add(first)
    output.Add(second)
    output
