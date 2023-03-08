type figura = 
   | Rettangolo of  float * float      // (base, altezza)
   | Quadrato   of  float              // lato
   | Triangolo  of  float * float      // (base, altezza)

let area fig =
   match fig with
   | Rettangolo(b,h) ->   b * h     
   | Quadrato l      ->   l * l  
   | Triangolo(b,h)  ->  ( b * h )  / 2. 

let areaOpt fig =
   match fig with
   | Rettangolo(b,h) -> if b >= 0 && h >= 0 then Some(b * h) else None  
   | Quadrato l -> if l >= 0 then Some(l*l) else None
   | Triangolo(b,h) -> if b >= 0 && h >= 0 then Some(( b * h )  / 2.) else None 
 
let printArea fig =
    let a = areaOpt fig
    if a = None then string "Area non definita" else
        match fig with
        | Rettangolo(_,_) -> string "Area rettangolo: " + string (area fig)
        | Quadrato _ -> string "Area quadrato: " + string (area fig)
        | Triangolo(_,_) -> string "Area triangolo: " + string (area fig)

let sommaArea (fig1, fig2) = 
    let a1 = areaOpt fig1
    let a2 = areaOpt fig2
    if a1 = None || a2 = None then None else Some(area fig1 + area fig2)
