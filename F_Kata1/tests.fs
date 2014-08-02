module tests

open NUnit.Framework
open StringCalculator

[<Test>]
let Should_return_0_for_empty_string() =
    Assert.AreEqual(0, add "")
[<Test>]
let Should_return_value_of_first_parameter() =
    Assert.AreEqual(1,add "1")

[<TestCase("1,2",3)>]
[<TestCase("2,4",6)>]
let Should_return_sum_of_commaseparated_value(values,expected) =
    Assert.AreEqual( expected, add values)

[<Test>]
let Should_split_on_line_breaks_and_Sum_it() =
 Assert.AreEqual( 5, add "1\n2\n\n2")





