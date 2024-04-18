// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

let a = readLine () |> int

let (b, c) = readIntArray () |> fun ns -> ns.[0], ns[1]

let s = readLine ()

printfn "%d %s" (a + b + c) s
