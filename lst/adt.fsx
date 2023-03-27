(* 
    An ADT can be partially achieved via module/signature (fileName.fsi)
    Il compilatore effettua il signature matching, cioè ogni nome dichiarato
    nella signatura T è definito nell'implementazione M allo stesso tipo oppure uno
    più generico.

    Vi è anche il concetto di opacità, cioè un nome dichiarato in M e non presente in T,
    non può essere mai visto al di fuori di M.

    Per costruire una DLL su un progetto bisogna:
    - Creare una directory MyProject ed un nuovo progetto con dotnet new classlib --language "F#" 
    - Apri VSCode
    - Pressuponiamo il tuo codice è in Library.fs e la tua interfaccia in Library.fsi, aggiungili facendo
    tasto destro a sinistra e poi add file
    - Lancia in F# interactive dalla shell con dotnet fsi -r MyProject.dll, 
    oppure direttamente dall'IDE con #r "MyProject"

    Un esempio di ADT è un set di interi senza ripetizioni
*)

module IFSet

type IFSet = S of int list;;

let empty = S[];;
