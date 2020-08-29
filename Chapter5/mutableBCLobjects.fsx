open System.Windows.Forms

let form = new Form()
form.Show()
// Changing mutable values on the Form object.
form.Width <- 400
form.Height <- 400
form.Text <- "Hello from F#!"

// Doing the same dealio as above with the F# shortcut for mutable
//  data structures.
let form2 = new Form(Width = 400, 
                     Height = 400, 
                     Text = "Hello from F#!")
form2.Show()