module ICPC
open System

let commaSprinkler input =
    //check if input is only one character
    let length = String.length input

    let checkUpper = (String.exists (fun c -> Char.IsUpper(c)) input)

    //check if an spaces exist to determine if it's more than one word
    let check_Space = (String.exists (fun c -> c = ' ') input)

    //let check_double_Space = (String.exists (fun c -> c = '  ') input)

    //check if th sentence starts with an invalid character
    let starts_with_Space =
        match input.[0] with
        |' ' -> true
        |',' -> true
        |_ -> false

    let ends_with_space =
           match input.[length-1] with
           |' ' -> true
           |_ -> false

    match input with
    | "" -> None
    | input when length < 2 -> None
    |input when check_Space = false -> None
    |input when starts_with_Space = true -> None
    |input when ends_with_space = true -> None
    | _ -> Some(input)

let rivers input =
    failwith "Not implemented"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
