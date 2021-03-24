// Learn more about F# at http://fsharp.org

open System
open Domain
open Auditing
open Operations

[<EntryPoint>]
let main argv =
    let mutable account =
        printfn "Please enter the following:"

        let getName =
            printfn "Name: "
            Console.ReadLine()
        let getBalance =
            printfn "Initial balance: "
            Console.ReadLine() |> Decimal.Parse

        { Id = Guid.NewGuid()
          Owner = getName
          Balance = getBalance }

    printfn ""
    
    while true do
        printfn "Choose the following: (D) Deposit, (W) Withdraw, (Q) Quit"
        printfn "Enter: "
        let choice = Console.ReadLine()

        if choice.ToUpper() = "Q" then Environment.Exit 0

        printfn "Choose how to audit: (C) Console, (F) File"
        let auditAs = Console.ReadLine()
        let auditMethod = if auditAs = "C" then console else fileSystemAudit

        printfn "Amount: "

        let amount = Console.ReadLine() |> Decimal.Parse

        let withdrawWithAudit = audit auditMethod withdraw
        let depositWithAudit = audit auditMethod deposit

        account <-
            if choice = "D" then account |> depositWithAudit amount
            elif choice = "W" then account |> withdrawWithAudit amount
            else account
    0 // return an integer exit code
