let list = [0..100]

let rec Itterate list = 
    match list with
    | [] -> []
    | head::tail -> 
        Print head
        Itterate tail



let Print head
