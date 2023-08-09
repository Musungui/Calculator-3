<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMIForm
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
        Label1 = New Label()
        Label2 = New Label()
        txtWeight = New TextBox()
        txtHeight = New TextBox()
        lblBmi = New Label()
        lblResults = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(166, 66)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 28)
        Label1.TabIndex = 0
        Label1.Text = "Weight (Kg):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(166, 143)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 28)
        Label2.TabIndex = 1
        Label2.Text = "Height (m):"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(361, 66)
        txtWeight.Margin = New Padding(2)
        txtWeight.MaxLength = 4
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(122, 27)
        txtWeight.TabIndex = 2
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(361, 143)
        txtHeight.Margin = New Padding(2)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(122, 27)
        txtHeight.TabIndex = 3
        ' 
        ' lblBmi
        ' 
        lblBmi.AutoSize = True
        lblBmi.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblBmi.Location = New Point(166, 209)
        lblBmi.Margin = New Padding(2, 0, 2, 0)
        lblBmi.Name = "lblBmi"
        lblBmi.Size = New Size(55, 28)
        lblBmi.TabIndex = 4
        lblBmi.Text = "BMI: "
        ' 
        ' lblResults
        ' 
        lblResults.BackColor = Color.LightGray
        lblResults.BorderStyle = BorderStyle.Fixed3D
        lblResults.Location = New Point(358, 212)
        lblResults.Margin = New Padding(2, 0, 2, 0)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(126, 26)
        lblResults.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.CadetBlue
        btnCalculate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculate.ForeColor = Color.White
        btnCalculate.Location = New Point(166, 274)
        btnCalculate.Margin = New Padding(2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(85, 39)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(280, 274)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 39)
        btnClear.TabIndex = 7
        btnClear.Text = "&Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Coral
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(398, 274)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(85, 39)
        btnExit.TabIndex = 8
        btnExit.Text = "&Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' BMIForm
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        CancelButton = btnExit
        ClientSize = New Size(640, 360)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblResults)
        Controls.Add(lblBmi)
        Controls.Add(txtHeight)
        Controls.Add(txtWeight)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "BMIForm"
        Text = "BMIForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblBmi As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
