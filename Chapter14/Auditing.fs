module Auditing

open System
open System.IO
open Domain

let console (account:Account) (message:string) = 
    Console.WriteLine($"{message}. {account.Owner} - {account.Id}: {account.Balance}")

let fileSystemAudit (account:Account) (message:string) =
    let appendStream = File.AppendText(@"C:/Dev/test/bank_log.txt")
    appendStream.WriteLine($"{message}. {account.Owner} - {account.Id}: {account.Balance}")