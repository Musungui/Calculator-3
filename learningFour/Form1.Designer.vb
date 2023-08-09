<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCalculator = New Button()
        btnBmi = New Button()
        Label1 = New Label()
        btnUnitConvert = New Button()
        btnExitScreen = New Button()
        SuspendLayout()
        ' 
        ' btnCalculator
        ' 
        btnCalculator.BackColor = Color.LightGray
        btnCalculator.Location = New Point(185, 95)
        btnCalculator.Margin = New Padding(2)
        btnCalculator.Name = "btnCalculator"
        btnCalculator.Size = New Size(204, 41)
        btnCalculator.TabIndex = 0
        btnCalculator.Text = "Calculator"
        btnCalculator.UseVisualStyleBackColor = False
        ' 
        ' btnBmi
        ' 
        btnBmi.BackColor = Color.LightGray
        btnBmi.Location = New Point(185, 179)
        btnBmi.Margin = New Padding(2)
        btnBmi.Name = "btnBmi"
        btnBmi.Size = New Size(204, 42)
        btnBmi.TabIndex = 1
        btnBmi.Text = "BMI"
        btnBmi.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(214, 48)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 20)
        Label1.TabIndex = 3
        Label1.Text = "Choose an operation:"
        ' 
        ' btnUnitConvert
        ' 
        btnUnitConvert.BackColor = Color.LightGray
        btnUnitConvert.Location = New Point(186, 270)
        btnUnitConvert.Margin = New Padding(2)
        btnUnitConvert.Name = "btnUnitConvert"
        btnUnitConvert.Size = New Size(195, 35)
        btnUnitConvert.TabIndex = 4
        btnUnitConvert.Text = "Unit Converter"
        btnUnitConvert.UseVisualStyleBackColor = False
        ' 
        ' btnExitScreen
        ' 
        btnExitScreen.AccessibleRole = AccessibleRole.OutlineButton
        btnExitScreen.BackColor = Color.Coral
        btnExitScreen.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExitScreen.ForeColor = Color.White
        btnExitScreen.Location = New Point(460, 306)
        btnExitScreen.Name = "btnExitScreen"
        btnExitScreen.Size = New Size(94, 29)
        btnExitScreen.TabIndex = 5
        btnExitScreen.Text = "Exit"
        btnExitScreen.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        CancelButton = btnExitScreen
        ClientSize = New Size(612, 360)
        Controls.Add(btnExitScreen)
        Controls.Add(btnUnitConvert)
        Controls.Add(Label1)
        Controls.Add(btnBmi)
        Controls.Add(btnCalculator)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculator As Button
    Friend WithEvents btnBmi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUnitConvert As Button
    Friend WithEvents btnExitScreen As Button
End Class
