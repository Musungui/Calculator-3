Public Class CalculatorForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim number1 As Integer
        Dim number2 As Integer


        If Integer.TryParse(txtNumber1.Text, number1) AndAlso Integer.TryParse(txtNumber2.Text, number2) Then
            Dim result As Integer = number1 + number2
            lblResult.Text = result


        Else
            MsgBox("Invalid Input. please Enter a number")

        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim number1 As Integer
        Dim number2 As Integer

        If Integer.TryParse(txtNumber1.Text, number1) AndAlso Integer.TryParse(txtNumber2.Text, number2) Then
            Dim result As Integer = number1 - number2
            lblResult.Text = result


        Else
            MsgBox("Invalid Input. please Enter a number")

        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim number1 As Integer
        Dim number2 As Integer

        If Integer.TryParse(txtNumber1.Text, number1) AndAlso Integer.TryParse(txtNumber2.Text, number2) Then
            Dim result As Integer = number1 * number2
            lblResult.Text = result


        Else
            MsgBox("Invalid Input. please Enter a number")

        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim number1 As Integer
        Dim number2 As Integer

        If Integer.TryParse(txtNumber1.Text, number1) AndAlso Integer.TryParse(txtNumber2.Text, number2) Then
            Dim result As Double = number1 / number2
            lblResult.Text = result

        Else
            MsgBox("Invalid Input. please Enter a number")

        End If
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        Dim number1 As Integer
        Dim number2 As Integer

        If Integer.TryParse(txtNumber1.Text, number1) AndAlso Integer.TryParse(txtNumber2.Text, number2) Then
            Dim result As Integer = number1 Mod number2
            lblResult.Text = result


        Else
            MsgBox("Invalid Input. please Enter a number")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblResult.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(btnExit, "Esc")
        toolTip.SetToolTip(btnClear, "Alt + C")
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