let add x y = x + y

let subtract x y = x - y

let multiply x y = x * y

// Возвращает option, чтобы избежать исключения при делении на ноль
let divide x y =
    if y = 0 then None
    else Some (x / y)

let rec factorial n =
    if n < 0 then None
    elif n = 0 then Some 1
    else
        match factorial (n - 1) with
        | None -> None
        | Some f -> Some (n * f)

let addFive = add 5
printfn "addFive 10 = %d" (addFive 10)
let multiplyByTen = multiply 10
printfn "multiplyByTen 6 = %d" (multiplyByTen 6)

let sum = add 3 4
printfn "add 3 4 = %d" sum

let diff = subtract 10 3
printfn "subtract 10 3 = %d" diff

let product = multiply 7 6
printfn "multiply 7 6 = %d" product

let quotient = divide 12 4
match quotient with
| Some q -> printfn "divide 12 4 = %d" q
| None -> printfn "деление на ноль недопустимо."

let fact5 = factorial 5
match fact5 with
| Some f -> printfn "factorial 5 = %d" f
| None -> printfn "факториал от отрицательного числа не существует."
