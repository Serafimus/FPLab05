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
let multiplyByTen = multiply 10

let sum = add 3 4          // 7
let diff = subtract 10 3   // 7
let product = multiply 7 6 // 42
let quotient = divide 12 4 // Some 3
let fact5 = factorial 5    // Some 120
