open System.IO
open System

let addFive x = x + 5

addFive 10
6 |> addFive

// checkCreation function for below demo.
let checkCreation (dateCreated:DateTime) =
    if dateCreated.Day > 7 then
        printf "Old!"

let currentDir = Directory.GetCurrentDirectory.ToString()

printf "%s" currentDir

// Piping demo!
Directory.GetCurrentDirectory()
|> Directory.GetCreationTime
|> checkCreation