<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnModulus = New Button()
        btnDivide = New Button()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        lblResult = New Label()
        Label4 = New Label()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 193)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 20)
        Label1.TabIndex = 0
        Label1.Text = "Choose an operation"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.LightGray
        btnAdd.Location = New Point(52, 258)
        btnAdd.Margin = New Padding(2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(88, 29)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnSubtract
        ' 
        btnSubtract.BackColor = Color.LightGray
        btnSubtract.Location = New Point(162, 258)
        btnSubtract.Margin = New Padding(2)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(88, 29)
        btnSubtract.TabIndex = 5
        btnSubtract.Text = "Subtract"
        btnSubtract.UseVisualStyleBackColor = False
        ' 
        ' btnMultiply
        ' 
        btnMultiply.BackColor = Color.LightGray
        btnMultiply.Location = New Point(282, 258)
        btnMultiply.Margin = New Padding(2)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(90, 27)
        btnMultiply.TabIndex = 8
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = False
        ' 
        ' btnModulus
        ' 
        btnModulus.BackColor = Color.LightGray
        btnModulus.Location = New Point(529, 259)
        btnModulus.Margin = New Padding(2)
        btnModulus.Name = "btnModulus"
        btnModulus.Size = New Size(90, 27)
        btnModulus.TabIndex = 9
        btnModulus.Text = "Modulus"
        btnModulus.UseVisualStyleBackColor = False
        ' 
        ' btnDivide
        ' 
        btnDivide.BackColor = Color.LightGray
        btnDivide.Location = New Point(413, 259)
        btnDivide.Margin = New Padding(2)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(90, 27)
        btnDivide.TabIndex = 10
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = False
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(185, 22)
        txtNumber1.Margin = New Padding(2)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(182, 27)
        txtNumber1.TabIndex = 3
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(185, 86)
        txtNumber2.Margin = New Padding(2)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(182, 27)
        txtNumber2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 22)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 20)
        Label2.TabIndex = 6
        Label2.Text = "Enter First Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 86)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 20)
        Label3.TabIndex = 7
        Label3.Text = "Enter Second Number:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNumber2)
        GroupBox1.Controls.Add(txtNumber1)
        GroupBox1.Location = New Point(30, 33)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(394, 147)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Entries"
        ' 
        ' lblResult
        ' 
        lblResult.BackColor = Color.LightGray
        lblResult.BorderStyle = BorderStyle.Fixed3D
        lblResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(471, 89)
        lblResult.Margin = New Padding(2, 0, 2, 0)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(123, 31)
        lblResult.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(471, 62)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 14
        Label4.Text = "Result:"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(57, 315)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(83, 28)
        btnClear.TabIndex = 15
        btnClear.Text = "&Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Coral
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(529, 315)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(83, 28)
        btnExit.TabIndex = 16
        btnExit.Text = "&Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' CalculatorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        CancelButton = btnExit
        ClientSize = New Size(640, 360)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(Label4)
        Controls.Add(lblResult)
        Controls.Add(GroupBox1)
        Controls.Add(btnDivide)
        Controls.Add(btnModulus)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "CalculatorForm"
        Text = "CalculatorForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnModulus As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
