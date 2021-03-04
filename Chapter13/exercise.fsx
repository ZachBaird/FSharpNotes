open System
open System.IO

type Customer = { Name: string; Age: int; }

let printCustomerAge writer customer =
    if customer.Age >= 18 then writer "Adult!"
    elif customer.Age >= 13 then writer "Teenager!"
    else writer "Child!"

let writeToFile text = File.WriteAllText(@"C:/Dev/test/chapter13exercise.txt", text)
   
// Partially applied, constrained function for writing to the console.
let printToConsole = printCustomerAge Console.WriteLine

// Partially applied, constrained function for writing to a file.
let printToFile = printCustomerAge writeToFile