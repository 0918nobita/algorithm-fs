// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

let (N, a, b) =
    readIntArray ()
    |> fun ns -> ns.[0], ns.[1], ns.[2]

let sumDigits n =
    let rec inner num sum =
        if num = 0 then
            sum
        else
            inner (num / 10) (sum + num % 10)

    inner n 0


seq {
    for n in 1..N do
        let sum = sumDigits n
        if a <= sum && sum <= b then n
}
|> Seq.sum
|> printfn "%d"
