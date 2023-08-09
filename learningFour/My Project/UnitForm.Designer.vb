<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblResult = New Label()
        txtEntry = New TextBox()
        btnConvert1 = New Button()
        btnConvert2 = New Button()
        SuspendLayout()
        ' 
        ' lblResult
        ' 
        lblResult.BorderStyle = BorderStyle.Fixed3D
        lblResult.Location = New Point(399, 80)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(174, 34)
        lblResult.TabIndex = 1
        ' 
        ' txtEntry
        ' 
        txtEntry.Location = New Point(187, 83)
        txtEntry.Name = "txtEntry"
        txtEntry.Size = New Size(169, 31)
        txtEntry.TabIndex = 3
        ' 
        ' btnConvert1
        ' 
        btnConvert1.Location = New Point(187, 172)
        btnConvert1.Name = "btnConvert1"
        btnConvert1.Size = New Size(190, 41)
        btnConvert1.TabIndex = 4
        btnConvert1.Text = "Ft to M"
        btnConvert1.UseVisualStyleBackColor = True
        ' 
        ' btnConvert2
        ' 
        btnConvert2.Location = New Point(399, 172)
        btnConvert2.Name = "btnConvert2"
        btnConvert2.Size = New Size(190, 41)
        btnConvert2.TabIndex = 5
        btnConvert2.Text = "M to Ft"
        btnConvert2.UseVisualStyleBackColor = True
        ' 
        ' UnitForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnConvert2)
        Controls.Add(btnConvert1)
        Controls.Add(txtEntry)
        Controls.Add(lblResult)
        Name = "UnitForm"
        Text = "UnitForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents txtEntry As TextBox
    Friend WithEvents btnConvert1 As Button
    Friend WithEvents btnConvert2 As Button
End Class
