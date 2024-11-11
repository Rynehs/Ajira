Public Class frmsettings
    Private Sub frmsettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Define the relative path to your HTML file
        Dim faqHtmlPath As String = Application.StartupPath & "\Resources\faq.html"

        ' Check if the file exists before reading
        If IO.File.Exists(faqHtmlPath) Then
            ' Read and inject the HTML content into the WebBrowser control
            Dim faqHtml As String = IO.File.ReadAllText(faqHtmlPath)
            WebBrowser1.DocumentText = faqHtml
        Else
            MessageBox.Show("FAQ file not found.")
        End If
    End Sub



End Class