// Learn more about F# at http://fsharp.org

open System
open System.IO

[<EntryPoint>]
let main argv =
    printfn "Passed in %d items: %A" argv.Length argv
    File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, @"output.txt"), [|"Hi"; "hello2"|])
    printfn "%s" Environment.CurrentDirectory
    0 // return an integer exit code
