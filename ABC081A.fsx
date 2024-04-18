// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

(readLine ()).ToCharArray()
|> Array.filter ((=) '1')
|> Array.length
|> printfn "%i"
