﻿// Learn more about F# at http://fsharp.org

open System

let testMethod number =
    printf "Your number is %d" number

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    testMethod 5 |> ignore
    0 // return an integer exit code

