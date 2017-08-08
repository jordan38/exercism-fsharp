module LeapYear

let isDivideBy4 year = 
    year % 4 = 0

let isDivideBy100 year =
    year % 100 = 0
    
let isDivideBy400 year =
    year % 400 = 0

let isLeapYear year = 
    let isLeapYear = isDivideBy4 year
    
    if not isLeapYear then isLeapYear 
    elif isDivideBy100 year then isDivideBy400 year
    else true

