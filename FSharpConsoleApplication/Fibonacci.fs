module MyFibonnaci

// 1. shamelessly imperative version
let fib1 n =                    // function syntax. n and return are deduced
    if n < 1 then
        failwith "n must be at least 1" // throws System.Exception
    else if n = 1 then          // = means comparison
        0                       // no statements, only expressions
    else                        // if, else if, else is very rare...
        let mutable x = 0       // vars not mutable by default
        let mutable y = 1
        for i in [3..n] do      // must iterate something - here a (generated) list
            let x' = y          // can use ' in var names
            let y' = x+y
            x <- x'             // <- means assigment (to mutable)
            y <- y'
        y

fib1 14 // test


// 1.1 Refactor to use simple pattern matching
let fib1_1 n =
    match n with
    | _ when n < 1 -> failwith "n must be at least 1"
    | 1 -> 0
    | _ ->                          // don't need matched value here (already have it)
        let mutable x, y = 0, 1     // multi value assignment (actually a pattern match on a tuple)
        for i in [3..n] do
            let x', y' = y, x+y
            x <- x'
            y <- y'
        y

fib1_1 14 // test


// 2. Recursive version
// gets rid of the mutability *and* the imperative loop
// - much more functional already
let rec fib2 n = // need 'rec' keyword
    match n with
    | _ when n < 1 -> failwith "n must be at least 1"
    | 1 -> 0
    | 2 -> 1
    | _ ->  fib2(n-1) + fib2 (n-2)

fib2 14 // test
List.map fib2 [1..14] // We can get all of the first 10 fibonacci numbers like this
[1..14] |> List.map fib2 // but more idiomatic like this


// 3. Since we're calculating all values to nth as we go
// we may as well return them as a list
let rec fib3 n =
    match n with
    | _ when n < 1 -> failwith "n must be at least 1"
    | 1 -> [0]      // syntax for list of 1 element
    | 2 -> [0;1]    // syntax for list of 2 elements
    | _ ->
        let a = fib3 (n-1)
        a @ [a.[n-2]+a.[n-3]] // Use @ to concat two lists. Use .[x] to index list
        // Functional lists are singly linked. In this case we always want the values at the other end
        // so getting them is a bit awkward (cleaner way shortly...)

fib3 14 // test


// 4. If we're ok for the list to be backwards we can
// get to the previous values more cleanly
let rec fib4 n =
    match n with
    | _ when n < 1 -> failwith "n must be at least 1"
    | 1 -> [0]
    | 2 -> [1;0]
    | _ ->
        let a = fib4 (n-1)
        a.Head + a.Tail.Head :: a

fib4 14  // test
fib4 14 |> List.rev  // We can reverse the list like this

// 4.1 We can wrap that up in a function
let fib4_1 n = fib4 n |> List.rev

fib4_1 14 // test


// 4.2 Or keep the reversed list generator encapsulated
let fib4_2 n = 
    let rec rfib n =
        match n with
        | _ when n < 1 -> failwith "n must be at least 1"
        | 1 -> [0]
        | 2 -> [1;0]
        | _ ->
            let a = rfib (n-1)
            a.Head + a.Tail.Head :: a
    rfib n |> List.rev

fib4_2 14 // test

// 5. We can avoid the recursion by using higher level functions
let fib5 n =
    {3..n} // generate a range to operate on
    |> Seq.fold( fun f  _ -> (f.Head + f.Tail.Head) :: f ) [1;0]
    |> List.rev

fib5 14 // test

// 6. We can also generate a sequence lazily
let fib6 () =
    let rec fib i j =              // Helper function which operators on last two values
        seq {                      // Sequence expression
            yield j                // Yield a single value
            yield! fib j (i+j)     // Yield! to yield a sequence
        }
    seq {
        yield 0
        yield! fib 0 1
    }

fib6() |> Seq.take 14 |> Seq.toList // test