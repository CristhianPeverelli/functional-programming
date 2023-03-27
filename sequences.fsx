let rec somma x = 
    match x with
    | [] -> 0
    | y :: ys -> y + somma ys 

let incrementa x =
    x + 5

let id x =
    x

let naturali = Seq.initInfinite id

let fuze a = 
    if a % 2 = 0 then a else a+1

let pippo = Seq.initInfinite fuze

let a = Seq.take 100 naturali |> Seq.toList 

let rec contaDa a = seq{
    yield a
    yield! contaDa(a+1)
}
