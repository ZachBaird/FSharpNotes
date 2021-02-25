module Operations

open Domain

let getCustomer =
    let zach =
        { Name = "Zach"
          Age = 26 }
    zach

let createAccount customer =
    let account =
        { Number = 12121212
          Owner = customer }
    account

let getZachAccount =
    let zachAccount = getCustomer |> createAccount
    zachAccount