Public Class UnitsForm
    Private Sub btnMtoFt_Click(sender As Object, e As EventArgs) Handles btnMtoFt.Click
        Dim dbEntry As Double
        Const Ft As Double = 3.28084

        If Double.TryParse(txtUnits.Text, dbEntry) Then
            dbEntry = txtUnits.Text
            lblDisplay.Text = Math.Round((dbEntry * Ft), 2)

        Else
            MsgBox("Invalid Input. Please enter a number.")

        End If
    End Sub

    Private Sub btnFttoM_Click(sender As Object, e As EventArgs) Handles btnFttoM.Click
        Dim dbEntry As Double
        Const Ft As Double = 3.28084


        If Double.TryParse(txtUnits.Text, dbEntry) Then
            dbEntry = txtUnits.Text
            lblDisplay.Text = Math.Round((dbEntry / Ft), 2)

        Else
            MsgBox("Invalid Input. Please enter a number.")

        End If
    End Sub

    Private Sub btnPoundstoKg_Click(sender As Object, e As EventArgs) Handles btnPoundstoKg.Click
        Dim dbEntry As Double
        Const Pound As Double = 0.45359237

        If Double.TryParse(txtUnits.Text, dbEntry) Then
            dbEntry = txtUnits.Text
            lblDisplay.Text = Math.Round((dbEntry * Pound), 3)

        Else
            MsgBox("Invalid Input. Please enter a number.")

        End If



    End Sub

    Private Sub btnKgtoPounds_Click(sender As Object, e As EventArgs) Handles btnKgtoPounds.Click
        Dim dbEntry As Double
        Const Pound As Double = 0.45359237
        If Double.TryParse(txtUnits.Text, dbEntry) Then
            dbEntry = txtUnits.Text
            lblDisplay.Text = Math.Round((dbEntry / Pound), 3)

        Else
            MsgBox("Invalid Input. Please enter a number.")

        End If
    End Sub

    Private Sub btnExitUnit_Click(sender As Object, e As EventArgs) Handles btnExitUnit.Click
        Me.Close()
    End Sub

    Private Sub UnitsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(btnExitUnit, "Esc")
        toolTip.SetToolTip(btnClearUnit, "Alt + C")

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
    Private Sub btnClearUnit_Click(sender As Object, e As EventArgs) Handles btnClearUnit.Click
        txtUnits.Clear()
    End Sub
End Class