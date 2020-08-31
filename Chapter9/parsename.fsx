let parseName(name:string) =
    let parts = name.Split(' ')
    let firstName = parts.[0]
    let surName = parts.[1]
    firstName, surName

// Calling the function and deconstructing the values out.
let name = parseName("Zachary Baird")
let firstName, surName = name

// Doing the above in one line
let fName, sName = parseName("Alexis Baird")
