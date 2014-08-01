module StringCalculator

open System
let add numbers =
    if (String.IsNullOrEmpty(numbers)) 
        then 0
    else
        1