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
    let answers = answers.Trim()
    if System.String.IsNullOrEmpty(answers) then "Fine. Be that way!"
    elif isLetter answers && isUpper answers || answers.EndsWith("!") then "Whoa, chill out!"
    elif answers.EndsWith("?") then "Sure."
    else "Whatever."
    
