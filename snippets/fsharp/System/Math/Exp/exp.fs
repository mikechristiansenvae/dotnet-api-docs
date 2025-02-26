﻿//<snippet1>
// Example for the Math.Exp( double ) method.
// The exp function may be used instead.

open System
printfn "This example of Math.Exp( double ) generates the following output.\n"
printfn "Evaluate [e ^ ln(X) = ln(e ^ X) = X] with selected values for X:"

// Evaluate logarithmic/exponential identity with a given argument.
let useLnExp arg =
    // Evaluate e ^ ln(X) = ln(e ^ X) = X.
    printfn $"\n      Math.Exp(Math.Log({arg})) = {Math.Exp(Math.Log arg):E16}\n      Math.Log(Math.Exp({arg})) = {Math.Log(Math.Exp arg):E16}"

// Evaluate exponential identities that are functions of two arguments.
let useTwoArgs argX argY =
    // Evaluate (e ^ X) * (e ^ Y) = e ^ (X + Y).
    printfn $"""
Math.Exp({argX}) * Math.Exp({argY}) = {Math.Exp argX * Math.Exp argY:E16}" +
          Math.Exp({argX} + {argY}) = {Math.Exp(argX + argY):E16}"""

    // Evaluate (e ^ X) ^ Y = e ^ (X * Y).
    printfn $" Math.Pow(Math.Exp({argX}), {argY}) = {Math.Pow(Math.Exp argX, argY):E16}\n          Math.Exp({argX} * {argY}) = {Math.Exp(argX * argY):E16}"

    // Evaluate X ^ Y = e ^ (Y * ln(X)).
    printfn $"           Math.Pow({argX}, {argY}) = {Math.Pow(argX, argY):E16}\nMath.Exp({argY} * Math.Log({argX})) = {Math.Exp(argY * Math.Log argX):E16}"

useLnExp 0.1
useLnExp 1.2
useLnExp 4.9
useLnExp 9.9

printfn "\nEvaluate these identities with selected values for X and Y:"
printfn "   (e ^ X) * (e ^ Y) = e ^ (X + Y)"
printfn "   (e ^ X) ^ Y = e ^ (X * Y)"
printfn "   X ^ Y = e ^ (Y * ln(X))"

useTwoArgs 0.1 1.2
useTwoArgs 1.2 4.9
useTwoArgs 4.9 9.9

// This example of Math.Exp( double ) generates the following output.
//
// Evaluate [e ^ ln(X) = ln(e ^ X) = X] with selected values for X:
//
//       Math.Exp(Math.Log(0.1)) = 1.0000000000000001E-001
//       Math.Log(Math.Exp(0.1)) = 1.0000000000000008E-001
//
//       Math.Exp(Math.Log(1.2)) = 1.2000000000000000E+000
//       Math.Log(Math.Exp(1.2)) = 1.2000000000000000E+000
//
//       Math.Exp(Math.Log(4.9)) = 4.9000000000000012E+000
//       Math.Log(Math.Exp(4.9)) = 4.9000000000000004E+000
//
//       Math.Exp(Math.Log(9.9)) = 9.9000000000000004E+000
//       Math.Log(Math.Exp(9.9)) = 9.9000000000000004E+000
//
// Evaluate these identities with selected values for X and Y:
//    (e ^ X) * (e ^ Y) = e ^ (X + Y)
//    (e ^ X) ^ Y = e ^ (X * Y)
//    X ^ Y = e ^ (Y * ln(X))
//
// Math.Exp(0.1) * Math.Exp(1.2) = 3.6692966676192444E+000
//           Math.Exp(0.1 + 1.2) = 3.6692966676192444E+000
//  Math.Pow(Math.Exp(0.1), 1.2) = 1.1274968515793757E+000
//           Math.Exp(0.1 * 1.2) = 1.1274968515793757E+000
//            Math.Pow(0.1, 1.2) = 6.3095734448019331E-002
// Math.Exp(1.2 * Math.Log(0.1)) = 6.3095734448019344E-002
//
// Math.Exp(1.2) * Math.Exp(4.9) = 4.4585777008251705E+002
//           Math.Exp(1.2 + 4.9) = 4.4585777008251716E+002
//  Math.Pow(Math.Exp(1.2), 4.9) = 3.5780924170885260E+002
//           Math.Exp(1.2 * 4.9) = 3.5780924170885277E+002
//            Math.Pow(1.2, 4.9) = 2.4433636334442981E+000
// Math.Exp(4.9 * Math.Log(1.2)) = 2.4433636334442981E+000
//
// Math.Exp(4.9) * Math.Exp(9.9) = 2.6764450551890982E+006
//           Math.Exp(4.9 + 9.9) = 2.6764450551891015E+006
//  Math.Pow(Math.Exp(4.9), 9.9) = 1.1684908531676833E+021
//           Math.Exp(4.9 * 9.9) = 1.1684908531676829E+021
//            Math.Pow(4.9, 9.9) = 6.8067718210957060E+006
// Math.Exp(9.9 * Math.Log(4.9)) = 6.8067718210956985E+006
//</snippet1>