// Difine placeholder values to x and lst
let mutable x = 3.245
let mutable lst = [3; 4; 12; 4]


// Compares floats and returns true if the difference it small enough.
let compareFloat (x : float) (y : float) : bool =
    System.Math.Abs(x - y) < 0.01


// Black-box test of cfrac2float and float2cfrac functions.
// First section will be for cfrac2float,
// and the 2nd section will be for float2cfrac.
// Begin cfrac2float test;
printfn "Black-box test;"
printfn "Case | Exp. Output"
printfn "__________________"
printfn "x = %A | 3.245" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            3.245)
printfn ""

lst <- [-3; 4; 12; 4]
printfn "x = %A | -2.755" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            -2.755)
printfn ""

lst <- [3; 4; 12; -4]
printfn "x = %A | 3.244" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            3.244)
printfn ""

lst <- [-3; 4; 12; -4]
printfn "x = %A | -2.755" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            -2.755)
printfn ""

lst <- [-3; -4; -12; -4]
printfn "x = %A | -3.245" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            -3.245)
printfn ""

lst <- []
printfn "x = %A | 0.0" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            0.0)
printfn ""

lst <- [3; 0; 12; 4]
printfn "x = %A | 15.250" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            15.250)
printfn ""

lst <- [0]
printfn "x = %A | 0.0" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            0.0)
printfn ""

lst <- [3; 4; 12; 0]
printfn "x = %A | Error (0.0)" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            0.0)
printfn ""

lst <- [0; 0; 0; 0]
printfn "x = %A | Error (0.0)" lst
printfn "Output: | cfrac.cfrac2float: %A" (cfrac.cfrac2float lst)
printfn "Exp. Output return: %A" (compareFloat (cfrac.cfrac2float lst) 
            0.0)
printfn ""
printfn ""
printfn ""


// Begin float2cfrac test;
printfn "Case | Exp. Output"
printfn "__________________"
printfn "x = %A | (cfrac.cfrac2float) = %A" x x
printfn "Output: | cfrac.float2cfrac: %A" (cfrac.float2cfrac x)
printfn "Exp. Output return: %A" (compareFloat x (cfrac.cfrac2float
            (cfrac.float2cfrac x)))
printfn ""

x <- -2.755
printfn "x = %A | (cfrac.cfrac2float) = %A" x x
printfn "Output: | cfrac.float2cfrac: %A" (cfrac.float2cfrac x)
printfn "Exp. Output return: %A" (compareFloat x (cfrac.cfrac2float
            (cfrac.float2cfrac x)))
printfn ""

x <- 3.244
printfn "x = %A | (cfrac.cfrac2float) = %A" x x
printfn "Output: | cfrac.float2cfrac: %A" (cfrac.float2cfrac x)
printfn "Exp. Output return: %A" (compareFloat x (cfrac.cfrac2float
            (cfrac.float2cfrac x)))
printfn ""

x <- -3.245
printfn "x = %A | (cfrac.cfrac2float) = %A" x x
printfn "Output: | cfrac.float2cfrac: %A" (cfrac.float2cfrac x)
printfn "Exp. Output return: %A" (compareFloat x (cfrac.cfrac2float
            (cfrac.float2cfrac x)))
printfn ""

x <- 15.25
printfn "x = %A | (cfrac.cfrac2float) = %A" x x
printfn "Output: | cfrac.float2cfrac: %A" (cfrac.float2cfrac x)
printfn "Exp. Output return: %A" (compareFloat x (cfrac.cfrac2float
            (cfrac.float2cfrac x)))
printfn ""

x <- 0.0
printfn "x = %A | (cfrac.cfrac2float) = %A" x x
printfn "Output: | cfrac.float2cfrac: %A" (cfrac.float2cfrac x)
printfn "Exp. Output return: %A" (compareFloat x (cfrac.cfrac2float
            (cfrac.float2cfrac x)))
printfn ""

// The Black-box test of the float2cfrac function did not exactly return
// the exact continued fraction of the input.
// This is possibly due to floating point precision errors.
// Some of the returned fractions does, however, return the same output if
// it's run through the cfrac2float function.


// Begin white-box test of cfrac2float and float2cfrac functions;
printfn ""
printfn ""
printfn ""
printfn "White-box test;"
printfn "Unit        | Branch | Condition      | Input | Expected output"
printfn "_______________________________________________________________"
printfn "cfrac2float | 1      | lst.Length = 1 |       |                "
printfn "            | 1a     | True           | [1]   | 1.0            "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (cfrac.cfrac2float [1])
            ((cfrac.cfrac2float [1]) = 1.0)

printfn ""
printfn "_______________________________________________________________"
printfn "            | 1b     | False          |      | -> Branch 2     "
printfn "_______________________________________________________________"

printfn ""
printfn "_______________________________________________________________"
printfn "cfrac2float | 2      | lst.Length < 1 |      |                 "
printfn "            | 2a     | True           | []   | 0.0             "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (cfrac.cfrac2float [])
            ((cfrac.cfrac2float []) = 0.0)

printfn ""
printfn "_______________________________________________________________"
printfn "            | 2b     | False          |      | -> Branch 3     "
printfn "_______________________________________________________________"

printfn ""
printfn "_______________________________________________________________"
printfn "cfrac2float | 3      | Else           |      |                 "
printfn "            | 3a     |                |[3; 4]| 3.25            "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (cfrac.cfrac2float [3; 4])
            ((cfrac.cfrac2float [3; 4]) = 3.25)


printfn ""
printfn ""
printfn "_______________________________________________________________"
printfn "float2cfrac | 1      | r = 0.0        |       |                "
printfn "            | 1a     | True           | 0.0   | []             "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (cfrac.float2cfrac 0.0)
            ((cfrac.float2cfrac 0.0) = [])

printfn ""
printfn "_______________________________________________________________"
printfn "            | 1b     | False          | 3.245 | [3; 4; 12; 4]  "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (cfrac.float2cfrac 3.245)
            ((cfrac.float2cfrac 3.245) = [3; 4; 12; 4])

// All of the banches have been accessed and returned true for my expected
// outputs, which means I can conclude that the test was successful.