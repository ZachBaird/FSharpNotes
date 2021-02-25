// Learn more about F# at http://fsharp.org

open System
open Operations

[<EntryPoint>]
let main argv =
    printfn "Beginning execution."

    printfn "%s - %d" getCustomer.Name getCustomer.Age

    let finalResult = getZachAccount
    printfn "Account %d" finalResult.Number
    printfn "Owner: %s" finalResult.Owner.Name

    printfn "Terminating execution."
    0 // return an integer exit code
