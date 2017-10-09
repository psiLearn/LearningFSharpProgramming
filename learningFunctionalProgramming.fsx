(*** hide ***)
#nowarn "211"
#load "packages/FSharp.Formatting/FSharp.Formatting.fsx"
open FSharp.Literate
open FSharp.Markdown


// Create evaluator & register simple formatter for lists

// let fsiOl = FSharp.Literate.FsiEvaluator()
// fsiOl.RegisterTransformation(fun (o, ty) ->
//   // If the type of value is an F# list, format it nicely
//   if ty.IsGenericType && ty.GetGenericTypeDefinition() = typedefof<list<_>> then
//     let items = 
//       // Get items as objects and create paragraph for each item
//       [ for it in Seq.cast<obj> (unbox o) -> 
//           [ Paragraph([Literal(it.ToString(), None)], None) ] ]
//     // Return option value (success) with ordered list
//     Some [ ListBlock(MarkdownListKind.Ordered, items, None) ]
//   else None)

(**
Functional Programming with F#
==============================

This is my documentation of reading the book
[Introduction to Functional Programming](https://usi-pl.github.io/lc/sp-2015/doc/Bird_Wadler.%20Introduction%20to%20Functional%20Programming.1ed.pdf)
by Richard Bird an Phillip Walder

1 Fundamental Concepts
----------------------

Every thing should be an expression. Asimple Number for example.
*)

(*** define-output:FourtyTwo ***)
42
(*** include-it:FourtyTwo ***)
(*** define-output:FourtyTwo2 ***)
6*7
(*** include-it:FourtyTwo2 ***)

(**
Hope this look simular to the book, though the prompt differs.
And now some functions.
*)

let square x = x*x
(*** include-value:square ***)
let min x y =
    if x < y then x
    else y
(*** include-value:min ***)

let min2 x y = 
    match x with
    | x when x < y -> x
    | x when x >= y -> y

(*** include-value:min2 ***)

(** 
And now see the result of the functions.
*)

(*** define-output:function2 ***)
square (3+4)
(*** include-it:function2 ***)
(*** define-output:function3 ***)
min 3 4
(*** include-it:function3 ***)