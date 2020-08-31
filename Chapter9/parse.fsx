let parse(person:string) =
    let parts = person.Split(' ')
    let name = parts.[0]
    let game = parts.[1]
    let score = int(parts.[2])
    name, game, score

// Note that we're using arbitrary variable names for each element in the tuple.
let a, b, c = parse("Cam Warframe 30000")