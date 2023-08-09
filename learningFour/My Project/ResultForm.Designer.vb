<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultForm
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
        SuspendLayout()
        ' 
        ' lblResult
        ' 
        lblResult.BorderStyle = BorderStyle.Fixed3D
        lblResult.Location = New Point(168, 127)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(472, 117)
        lblResult.TabIndex = 0
        ' 
        ' ResultForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Name = "ResultForm"
        Text = "ResultForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblResult As Label
End Class
