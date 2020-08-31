open System.IO

let getFileNameAndLastModifiedDate = 
    let projectFile =
        let files = Directory.GetFiles(@"C:\\Users\zdb19\\source\\repos\\FSharpBook\\Chapter9")
        files.[0]

    let lastModifiedDate = File.GetLastWriteTime(projectFile)

    projectFile, lastModifiedDate

let name, date = getFileNameAndLastModifiedDate
    
