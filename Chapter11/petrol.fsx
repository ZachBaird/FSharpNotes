let drive distance petrol =
    if distance > 50 then petrol / 2.0
    elif distance > 25 then petrol - 10.0
    elif distance > 0 then petrol - 1.0
    else petrol

let startingPetrol = 100.0

let remainingPetrol startingPetrol =
    startingPetrol
    |> drive 60
    |> drive 30
    |> drive 10

startingPetrol
|> drive 60
|> drive 30
|> drive 10