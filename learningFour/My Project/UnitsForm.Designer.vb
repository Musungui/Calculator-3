<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitsForm
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
        lblDisplay = New Label()
        txtUnits = New TextBox()
        btnMtoFt = New Button()
        btnFttoM = New Button()
        btnPoundstoKg = New Button()
        btnKgtoPounds = New Button()
        btnExitUnit = New Button()
        Label1 = New Label()
        Label3 = New Label()
        btnClearUnit = New Button()
        SuspendLayout()
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BackColor = Color.LightGray
        lblDisplay.BorderStyle = BorderStyle.Fixed3D
        lblDisplay.Location = New Point(363, 70)
        lblDisplay.Margin = New Padding(2, 0, 2, 0)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(96, 34)
        lblDisplay.TabIndex = 0
        ' 
        ' txtUnits
        ' 
        txtUnits.Location = New Point(187, 70)
        txtUnits.Margin = New Padding(2)
        txtUnits.Name = "txtUnits"
        txtUnits.Size = New Size(98, 27)
        txtUnits.TabIndex = 1
        ' 
        ' btnMtoFt
        ' 
        btnMtoFt.Location = New Point(262, 135)
        btnMtoFt.Margin = New Padding(2)
        btnMtoFt.Name = "btnMtoFt"
        btnMtoFt.Size = New Size(122, 27)
        btnMtoFt.TabIndex = 2
        btnMtoFt.Text = "M to Ft"
        btnMtoFt.UseVisualStyleBackColor = True
        ' 
        ' btnFttoM
        ' 
        btnFttoM.Location = New Point(262, 215)
        btnFttoM.Margin = New Padding(2)
        btnFttoM.Name = "btnFttoM"
        btnFttoM.Size = New Size(122, 27)
        btnFttoM.TabIndex = 3
        btnFttoM.Text = "Ft to M"
        btnFttoM.UseVisualStyleBackColor = True
        ' 
        ' btnPoundstoKg
        ' 
        btnPoundstoKg.Location = New Point(262, 295)
        btnPoundstoKg.Margin = New Padding(2)
        btnPoundstoKg.Name = "btnPoundstoKg"
        btnPoundstoKg.Size = New Size(122, 29)
        btnPoundstoKg.TabIndex = 4
        btnPoundstoKg.Text = "Pounds to Kg"
        btnPoundstoKg.UseVisualStyleBackColor = True
        ' 
        ' btnKgtoPounds
        ' 
        btnKgtoPounds.Location = New Point(262, 388)
        btnKgtoPounds.Margin = New Padding(2)
        btnKgtoPounds.Name = "btnKgtoPounds"
        btnKgtoPounds.Size = New Size(122, 29)
        btnKgtoPounds.TabIndex = 5
        btnKgtoPounds.Text = "Kg to Pounds"
        btnKgtoPounds.UseVisualStyleBackColor = True
        ' 
        ' btnExitUnit
        ' 
        btnExitUnit.BackColor = Color.Coral
        btnExitUnit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExitUnit.ForeColor = Color.White
        btnExitUnit.Location = New Point(485, 388)
        btnExitUnit.Name = "btnExitUnit"
        btnExitUnit.Size = New Size(94, 29)
        btnExitUnit.TabIndex = 6
        btnExitUnit.Text = "&Exit"
        btnExitUnit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(187, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 7
        Label1.Text = "Input:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(363, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 9
        Label3.Text = "Output:"
        ' 
        ' btnClearUnit
        ' 
        btnClearUnit.BackColor = Color.LightGray
        btnClearUnit.FlatStyle = FlatStyle.System
        btnClearUnit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClearUnit.ForeColor = Color.Black
        btnClearUnit.Location = New Point(66, 388)
        btnClearUnit.Name = "btnClearUnit"
        btnClearUnit.Size = New Size(94, 29)
        btnClearUnit.TabIndex = 10
        btnClearUnit.Text = "&Clear"
        btnClearUnit.UseVisualStyleBackColor = False
        ' 
        ' UnitsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        CancelButton = btnExitUnit
        ClientSize = New Size(640, 506)
        Controls.Add(btnClearUnit)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnExitUnit)
        Controls.Add(btnKgtoPounds)
        Controls.Add(btnPoundstoKg)
        Controls.Add(btnFttoM)
        Controls.Add(btnMtoFt)
        Controls.Add(txtUnits)
        Controls.Add(lblDisplay)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "UnitsForm"
        Text = "UnitsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnMtoFt As Button
    Friend WithEvents btnFttoM As Button
    Friend WithEvents btnPoundstoKg As Button
    Friend WithEvents btnKgtoPounds As Button
    Friend WithEvents btnExitUnit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearUnit As Button
End Class
