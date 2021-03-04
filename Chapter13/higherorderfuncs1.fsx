type Customer = { Age: int }

let where filter customers =
    seq {
        for customer in customers do
            if filter customer then
                yield customer }

let customers = [ { Age = 21 }; { Age = 30 }; { Age = 26 } ]
let isOver25 customer = customer.Age > 25

customers |> where isOver25
customers |> where (fun customer -> customer.Age > 25)
