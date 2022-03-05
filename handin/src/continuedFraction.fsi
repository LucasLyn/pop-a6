// Part of the module "cfrac".
module cfrac


///<summary>Prints the result of a given continued fraction as float.</summary>
///<param name ="lst">A continued fraction represented as a list.</param>
///<returns>Float result of the given continued fraction.</returns>
// Continued fraction to float.
val cfrac2float : lst:int list -> float


///<summary>Prints the continued fraction as a list of a given result.</summary>
///<param name ="x">Continued fraction result.</param>
///<returns>A continued fraction represented as a list.</returns>
// Float to continued fraction.
val float2cfrac : x:float -> int list