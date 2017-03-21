(**
- title : F# Lang
- description : Intro to F# programming.
- author : Kornelije Sajler
- theme : solarized
- transition : default

***

### F#

> Kornelije Sajler
>

> Blog: [learnaholic.me](http://learnaholic.me)
>
> Photography: [ksphoto.me](http://ksphoto.me)

***

### Binding

*)
let a = 5
(*** include-value: a ***)

5 = a
let b = 5 = a
(*** include-value: b ***)

let c =
  if a < 5 then
    "Less than"
  else
    "Greater than"

(*** include-value: c ***)
(**
---
### Binding cont.
*)
let range =
  [
    for n in  1..10 ->
      n * 2
  ]

(*** include-value: range ***)
(**
---
### Module, Namespace, Attribute, Constant

    namespace SuperApp
    [<Literal>]
    let meaningOfLife = 42

    module Util =
      let crackIt = ()

    let doCracking = Util.crackIt

---
### Tuple
*)
let item = (1, "apple", 2.99)
let id, name, price = item
let _, productName, productPrice = item


(*** include-value: id ***)
(*** include-value: name ***)
(*** include-value: price ***)
(**
---

### Pattern Matching
*)
let numbers = [ 1..10 ]

let result =
  match numbers with
  | [] -> "Nothing in collection"
  | _ -> sprintf "Collection count: %i" numbers.Length

(*** include-value:  result ***)
(**

---

### Option
*)

let nothing = None
let something = Some 1

let optionResult =
  match something with
  | None -> "nothing something"
  | Some n -> sprintf "something: %i" n

(*** include-value:  optionResult ***)
(**

---

### Function
*)

let add n1 n2 =
  n1 + n2

add 1 2
(*** include-value:  add 1 2 ***)
(**
----
### Partial Application
*)

let addWithTwo = (+) 2

addWithTwo 4

(*** include-value: addWithTwo 4 ***)
(**

---
### Record

*)
type User = {
  id: int
  firstName: string
  lastName: string
  email: string
  roles: string list option
}
with member x.fullname = sprintf "%s %s" x.firstName x.lastName

let user = {
  id = 1
  firstName = "pero"
  lastName = "peric"
  email = "pero@ab.ba"
  roles = None
}

(*** include-value: user.fullname ***)
(**

---
### Discriminated Unions

*)

type Shape =
  | Square of float
  | Rectangle of float * float
  | Circle of float

let square = Square 3.
let rectangle = Rectangle(2., 1.5)
let circle = Circle(1.0)

(*** include-value: rectangle ***)
(**

---
### Enum

*)

type RoleType =
  | Admin = 0
  | Manager = 1
  | Agent = 2

let role = RoleType.Admin

(*** include-value: role ***)
(**

***
### Collections

*)

let array = [| 1; 2; 4 |]
let list = [
  "apple"
  "orange"
  "peach"
]
let sequence = seq { 0..99 }
let index = list.[0]

(*** include-value: array ***)
(*** include-value: list ***)
(*** include-value: sequence ***)
(*** include-value: index ***)
(**

---
### For & Yield

*)

let squares = [
  for n in 0..99 do
    yield n * n ]

(*** include-value: squares ***)
(**

---
### Filter & Pipe
*)

let isEven n = n % 2 = 0
let even = squares |> List.filter (fun x -> isEven x)

(*** include-value: even ***)
(**

---
### Sort
*)

let sortedFruit = List.sort [ "pear"; "orange"; "apple" ]

(*** include-value: sortedFruit ***)
(**

---
### Map
*)

type Person = { firstName: string; lastName: string }
let people = [
  { firstName = "pero"; lastName = "peric" }
  { firstName = "djuro"; lastName = "djuric" }
  { firstName = "ivo"; lastName = "ivic" } ]

let firstNames = people |> List.map (fun x -> x.firstName)
(*** include-value: people ***)
(**

---
### Multiple pipes
*)

squares
|> List.filter isEven
|> List.sortDescending
|> List.take 5
|> List.iter (fun n -> printfn "%i" n)

(*** include-value: (squares |> List.filter isEven |> List.sortDescending |> List.take 5) ***)
(**

---
### Sequence example
*)
open System.IO

let bigFiles =
  Directory.EnumerateFiles(@"/Applications/Mail.app/Contents/Resources")
  |> Seq.map (fun name -> FileInfo name)
  |> Seq.filter (fun fi -> fi.Length > 10000L)
  |> Seq.map (fun fi -> fi.Name)

(*** include-value: bigFiles ***)
(**

***
### Pros

- Readability and joy to write
- First class function
- Powerful type inference and true strong typed language
- Piping
- Patern matching
- Collections builtin (no namespace imports needed)
- Option (hard to get null reference exception)
- Have modules and namespaces
- Usual OOP Design Patterns = Function in F#
- Functionl (proper) and OOP
- Type Provider

---

### Cons

- Not easy to start for usual OOP developer
- Part of .NET Framework (which is OOP and C# oriented)
- Dealing with C# - espcially "functional C#" `Action<T>` and `Func<T>`
- Mostly any proven library is C# based
- Abandoned by Microsoft (more emphasis on node.js and even C++)
- Part of .NET Languages
- Lacking of Visual Studio support (as C#/node.js/C++ have)
  - Some funky errors, not easy to comprehend

***

### Real life examples

***

### Questions?!

***

### Slides

- [source](https://github.com/xajler/fsharp-lang-slides)
- [output](http://metaintellect.com/fs-lang-slides/#/)
*)

