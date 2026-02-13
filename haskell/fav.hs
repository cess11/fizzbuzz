-- i quite like this one. the only thing i don't like is the
-- max predicate, it's a bit weird to max up the strings to the
-- final output. other than that, it's a neat solution that
-- starts off with preparing the fizz buzz strings and then
-- merging with the stringified numbers
-- https://gist.github.com/Frost/dd1579bca7312ea43ff3 helped me get started
-- to verify, `take 100 fizzbuzz`

fizz = cycle ["", "", "fizz"]

buzz = cycle ["", "", "", "", "buzz"]

word = zipWith (++) fizz buzz

nums = map show [1 ..]

fizzbuzz = zipWith max word nums
