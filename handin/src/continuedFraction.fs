// Part of the module "cfrac".
module cfrac


// Compares floats and returns true if the difference it small enough.
let compareFloat (x : float) (y : float) : bool =
    System.Math.Abs(x - y) < 0.01


// Recursively calculate the continued fraction and print the result.
let rec cfrac2float (lst : int list) : float =
    if lst.Length = 1 then (float lst.Head)
    else if lst.Length < 1 then (float 0.0)
    else (float lst.Head) + (1.0 / cfrac2float(lst.Tail))
printfn "%A" (cfrac2float [3; 4; 12; 4])


// Recursively calculates and prints the continued fraction from a given result.
let rec float2cfrac (x : float) : int list =
    let q = int (x + 0.0000001)
    let r = x - (floor x)
    if (compareFloat r 0.0) then []
    else q::(float2cfrac (1.0 / r))
printfn "%A" (float2cfrac 3.245)
