// --- HELPER FUNCTIONS ---

let inline readLine () = stdin.ReadLine()

let inline readIntArray () = (readLine ()).Split() |> Array.map int

// --- MAIN ---

let _n = readLine () |> int

let an = readIntArray ()

let rec solve array ans =
    if array |> Array.exists (fun a -> a % 2 <> 0) then
        ans
    else
        solve (array |> Array.map (fun a -> a / 2)) (ans + 1)

printfn "%d" (solve an 0)
