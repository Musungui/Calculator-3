Public Class BMIForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dbWeight As Double
        Dim dbHeight As Double
        Dim dbResults As Double

        Try
            dbWeight = txtWeight.Text
            dbHeight = txtHeight.Text
            dbResults = dbWeight / (dbHeight * dbHeight)
            dbResults = Math.Round(dbResults, 2)
        Catch ex As Exception
            MessageBox.Show("Invalid Input! Please Enter a Number")

        End Try


        Try
            If (dbWeight > 250 Or dbWeight <= 0) And (dbHeight > 2.75 Or dbHeight <= 0.5) Then
                MsgBox("The input of the weight should be 1 to 150 kgs and the height 0.5 to 2.75 meters.")
                Exit Sub
            ElseIf dbWeight > 250 Or dbWeight <= 0 Then
                MsgBox("The input is out of range. Please enter weight between 1 and 150 kilograms.")
                Exit Sub
            ElseIf dbHeight > 2.75 Or dbHeight <= 0.5 Then
                MsgBox("The input is out of range. Please enter height between 0.5 and 2.75 meters.")
                Exit Sub
            Else
                lblResults.Text = dbResults
            End If


        Catch ex As Exception
            MessageBox.Show("Invalid Input! Please Enter a Number")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHeight.Clear()
        txtWeight.Clear()
        lblResults.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BMIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(btnExit, "Esc")
        toolTip.SetToolTip(btnClear, "Alt + C")
        toolTip.SetToolTip(btnCalculate, "Enter")

        Me.Size = New Size(600, 500)
        CenterFormOnScreen()
    End Sub
    Private Sub CenterFormOnScreen()
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height

        Me.Left = (screenWidth - formWidth) / 2
        Me.Top = (screenHeight - formHeight) / 2

    End Sub
End Class