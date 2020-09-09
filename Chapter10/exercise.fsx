open System

// DTO record.
type Address =
    { Street: string
      City: string
      State: string
      Zipcode: int }

// DTOs.
let address1 =
    { Street = "123 St."
      City = "Onesville"
      State = "Onestucky"
      Zipcode = 12345 }

let address2 =
    { Street = "456 St."
      City = "Foursville"
      State = "Foursylvania"
      Zipcode = 45678 }

let address3 =
    { Street = "456 St."
      City = "Foursville"
      State = "Foursylvania"
      Zipcode = 45678 }

// Equal tests.
let normalEquals = (address1 = address2)
let dotEquals = (address1.Equals(address2))
let dotEquals2 = (address3.Equals(address2))

// Function to copy-and-update and return a new record with a new state.
let changeState(address, newState) =
    let newAddress =
        { address with
            State = newState }

    newAddress

let newAaddress1 = changeState(address1, "Onesida")
