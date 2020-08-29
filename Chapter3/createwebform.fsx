open System
open System.Net
open System.Windows.Forms

let browser url = 
    let uri =
        let webClient = new WebClient()
        webClient.DownloadString(Uri url)

    new WebBrowser(ScriptErrorsSuppressed = true,
                   Dock = DockStyle.Fill,
                   DocumentText = uri)

let form = new Form(Text = "Hello from F#!")
form.Controls.Add(browser("http://fsharp.org"))
form.Show()
