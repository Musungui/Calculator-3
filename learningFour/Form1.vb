Public Class Form1
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Dim calculatorForm As New CalculatorForm()

        calculatorForm.Show()

    End Sub

    Private Sub btnBmi_Click(sender As Object, e As EventArgs) Handles btnBmi.Click
        Dim bmiForm As New BMIForm()

        bmiForm.Show()
    End Sub


    Private Sub btnUnitConvert_Click(sender As Object, e As EventArgs) Handles btnUnitConvert.Click
        Dim unitsConverterForm As New UnitsForm()

        unitsConverterForm.Show()
    End Sub

    Private Sub btnExitScreen_Click(sender As Object, e As EventArgs) Handles btnExitScreen.Click
        MsgBox("Thank you for using Calculator 3!")
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(btnExitScreen, "Esc")
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
