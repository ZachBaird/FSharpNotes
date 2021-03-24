module Domain

open System

type Account =
    { Owner: string; Balance: decimal; Id: Guid; }