type Customer =
    { Name : string
      Age : int
      City : string
      Country : string }

let arrayOfNumbers = [| 1; 2; 3; 4; 5 |]
let sequenceOfCustomers = seq {
    { Name = "Zach"
      Age = 26
      City = "Hershey"
      Country = "United States" }
    { Name = "Ewan"
      Age = 40
      City = "Edinburgh"
      Country = "United Kingdom" } // but I should really say Scotland! 
    { Name = "Alexis"
      Age = 30
      City = "Hershey"
      Country = "United States" }
    { Name = "Cameron"
      Age = 22
      City = "Ottawa"
      Country = "Canada" }
}

let customerList = [ for i in sequenceOfCustomers do i]

let areFromUsa customer =
    if customer.Country = "United States" then true
    else false

let areFromUk customer =
    if customer.Country = "United Kingdom" then true
    else false

let usaCustomers = Seq.filter areFromUsa sequenceOfCustomers
let numbersDoubled = Array.map (fun number -> number * 2) arrayOfNumbers
let customersByCity = List.groupBy (fun c -> c.City) customerList

let ukCustomers = sequenceOfCustomers |> Seq.filter areFromUk
let tripledNumbers = arrayOfNumbers |> Array.map (fun number -> number * 3)
let customersByCountry = customerList |> List.groupBy (fun c-> c.Country)
