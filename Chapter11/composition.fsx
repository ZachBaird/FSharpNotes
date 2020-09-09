open System
open System.IO

// checkCreation function for below demo.
let checkCreation (dateCreated:DateTime) =
    if dateCreated.Day > 7 then
        "Old!"
    else
        "Nope!"

let checkCurrentDirectoryAge =
    Directory.GetCurrentDirectory
    >> Directory.GetCreationTime
    >> checkCreation

let description = checkCurrentDirectoryAge