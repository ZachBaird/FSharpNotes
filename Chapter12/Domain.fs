﻿namespace Domain

type Customer = 
    { Name : string
      Age : int }

type Account = 
    { Number : int
      Owner : Customer }
