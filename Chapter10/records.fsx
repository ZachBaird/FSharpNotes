type Address = 
    { Street: string
      Town: string
      City: string }

type Customer = 
    { FirstName: string
      SurName: string
      Age: int
      Address: Address
      EmailAddress: string }

let customer = 
    { FirstName = "John"
      SurName = "Doe"
      Age = 29
      Address =
        { Street = "The Street"
          Town = "The Town"
          City = "The City" }
      EmailAddress = "johndoe@gmail.com" }

type Car =
    { Manufacturer: string
      EngineSize: string
      NumOfDoors: int
      FuelType: string }

let mazda = 
    { Manufacturer = "Mazda"
      EngineSize = "Small"
      NumOfDoors = 4
      FuelType = "Gas" }

// Records can be inferred with type inference, but we can be explicit with them. See below.
let explicitRecordTypeDemo : Car =
    { Manufacturer = "Doesn't Matter"
      EngineSize = "Small"
      NumOfDoors = 0
      FuelType = "Plasma" }

let explicitFieldTypeDemo =
    { Car.Manufacturer = "Still Doesn't Matter"
      Car.EngineSize = "Large"
      Car.NumOfDoors = 10
      Car.FuelType = "Diesel" }

// So how do we update our DTO's members if they're immutable?
//  With the `with` keyword, for a copy-and-update approach.
let updatedCustomer = 
    { customer with
        Age = 31
        EmailAddress = "joedoe@yahoo.org" }

// Making two addresses for equality check.
let address1 =
    { Street = "Main St."
      Town = "Unadilla" 
      City = "Binghamton" }

let address2 =
    { Street = "Main St."
      Town = "Unadilla" 
      City = "Binghamton" }

// These check for equality just the way you'd expect!
let sameAddress = (address1 = address2)
let diffAddress = (customer.Address = address1)