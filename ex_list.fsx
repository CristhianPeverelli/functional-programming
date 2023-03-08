let par x =
    if x % 2 = 0 then true else false

let rec rmEven x =
    match x with
    | [] -> []
    | y :: ys -> if par(y) then rmEven ys else y :: rmEven ys 

let rec rmOddPos x =
    match x with
    | [] -> []
    | y :: ys -> if(x.Length % 2 = 0) then y :: rmOddPos(ys) else rmOddPos(ys)   

let rec rmOddPosAlternativo x =
    match x with
    | [] -> []
    | y :: z :: ys -> y :: rmOddPosAlternativo(ys)
    | y :: ys -> rmOddPosAlternativo(ys)

let rec split x =
    match x with
    | [] -> ([],[])
    | y :: [] -> ([y],[])
    | y :: z :: ys -> 
        let (a,b) =  split(ys)
        (y :: a, z :: b) 

 