Imports System.Security.Cryptography.X509Certificates

Public Class ResultForm
    Public Sub New(ByVal result As Integer)

        InitializeComponent()


        lblResult.Text = result.ToString()
    End Sub
End Class