// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

let a = readLine () |> int
let b = readLine () |> int
let c = readLine () |> int

let x = readLine () |> int

let maxA = min (x / 500) a
let maxB = min (x / 100) b
let maxC = min (x / 50) c

seq {
    for aN in 0..maxA do
        for bN in 0..maxB do
            for cN in 0..maxC do
                if (aN * 500 + bN * 100 + cN * 50) = x then
                    (aN, bN, cN)
}
|> Seq.length
|> printfn "%d"
