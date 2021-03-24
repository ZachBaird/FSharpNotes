module Operations

open Domain

let deposit (amount:decimal) (account:Account) : Account =
    { account with Balance = account.Balance + amount }

let withdraw (amount:decimal) (account:Account) : Account =
    if account.Balance - amount < 0M then account
    else { account with Balance = account.Balance - amount }

let audit auditAs action amount account =
    let result = action amount account

    if result.Balance = account.Balance then
        auditAs account "Could not complete the requested action on the account."
        account
    else
        auditAs result "Action successful."
        result
    