module Tests

open NUnit.Framework
open FsUnit

[<TestCase(1, 2, Result = 3)>]
let Adder x y =
    x + y

let testCaseSource =
    [|
        [| 2; 3; 6 |]
        [| 4; 5; 20 |]
    |]

[<Test>]
[<TestCaseSource("testCaseSource")>]
let Multiplier x y result =
    x * y |> should equal result
