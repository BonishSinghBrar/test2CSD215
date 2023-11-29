type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Director = {
    Name: string
    Movies: int
}

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

let CODA = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = sianHeder; IMDBRating = 8.1 }
let Belfast = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = kennethBranagh; IMDBRating = 7.3 }
let DontLookUp = { Name = "Don't Look Up"; RunLength = 138; Genre = ComedyDrama; Director = adamMckay; IMDBRating = 7.2 }
let DriveMyCar = { Name = "Drive My Car"; RunLength = 179; Genre = Fantasy; Director = ryusukeHamaguchi; IMDBRating = 7.6 }
let Dune = { Name = "Dune"; RunLength = 155; Genre = Sport; Director = denisVilleneuve; IMDBRating = 8.1 }
let KingRichard = { Name = "King Richard"; RunLength = 144; Genre = Comedy; Director = reinaldoMarcusGreen; IMDBRating = 7.5 }
let LicoricePizza = { Name = "Licorice Pizza"; RunLength = 133; Genre = Thriller; Director = paulThomasAnderson; IMDBRating = 7.4 }
let NightmareAlley = { Name = "Nightmare Alley"; RunLength = 150; Genre = Drama; Director = guillermoDelToro; IMDBRating = 7.1 }