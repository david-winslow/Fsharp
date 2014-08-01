module tests

open NUnit.Framework
open StringCalculator

[<Test>]
let Should_return_0_for_empty_string() =
    Assert.AreEqual(0, add "")
[<Test>]
let Should_return_value_of_first_parameter() =
    Assert.AreEqual(1,add "1")

[<Test>]
let Should_return_sum_of_commaseparated_value() =
    Assert.AreEqual( 3, add "1,2")

