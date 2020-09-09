open System

// Explicitly created wrapper functions.
let buildDt year month day = DateTime(year, month, day)
//let buildDtThisYear month day = buildDt DateTime.UtcNow.Year month day
//let buildDtThisMonth day = buildDtThisYear DateTime.UtcNow.Month day

// Wrapper functions made with currying.
let buildDtThisYear = buildDt DateTime.UtcNow.Year
let buildDtThisMonth = buildDtThisYear DateTime.UtcNow.Month
