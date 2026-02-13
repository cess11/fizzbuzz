// i'd like to reimplement the haskell fav in f# but it seems tricky
module FB

let cycle x =
    Seq.initInfinite (fun _ -> x) |> Seq.concat

let zipWith f xs ys =
    Seq.zip xs ys |> Seq.map (fun x y -> f x y)

let fizz = seq [ ""; ""; "fizz" ] |> cycle
let buzz = seq [ ""; ""; ""; ""; "buzz" ] |> cycle
// if the + issue can be resolved this could probably be solved
// by taking a parameter instead of hardcoding 100
let nums = seq [ 1..100 ] |> Seq.map string

// apparently this is a no go, can't do + on functions
let fizzbuzz = zipWith (+) fizz buzz |> zipWith max numbers

fizzbuzz |> Seq.take 100 |> Seq.toList
