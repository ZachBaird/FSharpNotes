open System.IO
open System

let writeToFile (date:DateTime) filename text =
    let path = sprintf @"C:\Dev\test\%s-%s.txt" (date.ToString("yyMMdd")) filename
    File.WriteAllText(path, text)

let writeToToday = writeToFile DateTime.UtcNow.Date
let writeToTomorrow = writeToFile (DateTime.UtcNow.Date.AddDays 1.)
let writeToTodayHelloWorld = writeToToday "hello-world"

writeToToday "first-file" "Alexis is a weenie"
writeToTomorrow "second-file" "One day later and she's still a weenie"
writeToTodayHelloWorld "Hi!"