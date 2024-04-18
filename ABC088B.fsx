// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

let _n = readLine () |> int

let an = readIntArray ()

type Turn =
    | Alice
    | Bob

type Scores = { Alice: int; Bob: int }

let initialScores = { Alice = 0; Bob = 0 }

let folder (turn, scores) card =
    match turn with
    | Alice -> (Bob, { scores with Alice = scores.Alice + card })
    | Bob -> (Alice, { scores with Bob = scores.Bob + card })

let (_, resultingScores) =
    Array.sortDescending an
    |> Seq.fold folder (Alice, initialScores)

abs (resultingScores.Alice - resultingScores.Bob)
|> printfn "%d"
