module StringCalculator

open System
open System.Linq
let add numbers =
    if (String.IsNullOrEmpty(numbers)) 
        then 0
    else
        let splitters = [|",";"\n"|]
        numbers.Split(splitters,StringSplitOptions.RemoveEmptyEntries).Select(fun x -> Int32.Parse x ).Sum()
        