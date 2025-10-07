open System

[<EntryPoint>]
let main _ =
    // Спросим сначала, сколько чисел вводить
    printf "Сколько чисел будете вводить? "
    let n = Console.ReadLine() |> int

    let modules =
        [
            let getAbs x = if x < 0 then -x 
                            else x
            for _ in 1 .. n do
                let num = Console.ReadLine() |> int
                yield getAbs num
        ]

    printfn "Модули введённых чисел: %A" modules
    0
