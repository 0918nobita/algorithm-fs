// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

let (a, b) = readIntArray () |> fun ns -> ns.[0], ns.[1]

let product = a * b

if product % 2 = 0 then
    printfn "Even"
else
    printfn "Odd"
