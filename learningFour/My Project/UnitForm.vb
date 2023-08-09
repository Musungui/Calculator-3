Public Class UnitForm
    Private Sub btnConvert1_Click(sender As Object, e As EventArgs) Handles btnConvert1.Click
        Dim dbEntry As Double
        Const Ft As Double = 3.28084

        dbEntry = txtEntry.Text

        'this constant is 1m = 3.28084ft

        lblResult.Text = Math.Round((dbEntry / Ft), 2)

    End Sub

    Private Sub btnConvert2_Click(sender As Object, e As EventArgs) Handles btnConvert2.Click
        Dim dbEntry As Double
        Const Ft As Double = 3.28084

        dbEntry = txtEntry.Text

        'this constant is 1m = 3.28084ft

        lblResult.Text = Math.Round((dbEntry * Ft), 2)
    End Sub
End Class