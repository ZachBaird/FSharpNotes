let text = "Hello, world!"
printfn "%s" text

let greetPerson name age =
    sprintf "Hello, %s. You are %d years old." name age

open System
open System.IO

let countWords (text:string) =
    File.WriteAllLines(@"C:\\Users\\zdb19\\source\\repos\\FSharpBook\\Chapter2\\output.txt", 
        [|text; text.Split().Length.ToString()|])
