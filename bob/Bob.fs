module Bob

let isUpper answer =
    answer
    |> String.filter(fun c -> System.Char.IsLetter(c) && System.Char.IsWhiteSpace(c) = false)
    |> String.forall(fun c -> System.Char.IsUpper(c)) 
    
let isLetter answer =
    answer
    |> String.filter(fun c -> System.Char.IsPunctuation(c) = false && System.Char.IsWhiteSpace(c) = false)
    |> String.forall(fun c -> System.Char.IsLetter(c))

let hey (answers:string) =
    if System.String.IsNullOrEmpty(answers) || String.forall(fun c -> System.Char.IsWhiteSpace(c)) answers then "Fine. Be that way!"
    elif isLetter answers && isUpper answers || String.exists(fun c -> c = '!') answers && answers.LastIndexOf('!') = answers.Length - 1 then "Whoa, chill out!"
    elif String.exists(fun c -> c = '?') answers && answers.LastIndexOf('?') = answers.Length - 1 then "Sure."
    else "Whatever."
    
