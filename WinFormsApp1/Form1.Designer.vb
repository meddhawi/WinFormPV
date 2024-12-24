<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtDisplay = New TextBox()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn0 = New Button()
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        btnEquals = New Button()
        btnClear = New Button()
        SuspendLayout()
        
        ' txtDisplay
        txtDisplay.Font = New Font("Segoe UI", 14F)
        txtDisplay.Location = New Point(12, 12)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(258, 32)
        txtDisplay.TextAlign = HorizontalAlignment.Right
        
        ' Number buttons
        btn1.Location = New Point(12, 50)
        btn1.Size = New Size(60, 40)
        btn1.Text = "1"
        
        btn2.Location = New Point(78, 50)
        btn2.Size = New Size(60, 40)
        btn2.Text = "2"
        
        btn3.Location = New Point(144, 50)
        btn3.Size = New Size(60, 40)
        btn3.Text = "3"
        
        btn4.Location = New Point(12, 96)
        btn4.Size = New Size(60, 40)
        btn4.Text = "4"
        
        btn5.Location = New Point(78, 96)
        btn5.Size = New Size(60, 40)
        btn5.Text = "5"
        
        btn6.Location = New Point(144, 96)
        btn6.Size = New Size(60, 40)
        btn6.Text = "6"
        
        btn7.Location = New Point(12, 142)
        btn7.Size = New Size(60, 40)
        btn7.Text = "7"
        
        btn8.Location = New Point(78, 142)
        btn8.Size = New Size(60, 40)
        btn8.Text = "8"
        
        btn9.Location = New Point(144, 142)
        btn9.Size = New Size(60, 40)
        btn9.Text = "9"
        
        btn0.Location = New Point(78, 188)
        btn0.Size = New Size(60, 40)
        btn0.Text = "0"
        
        ' Operator buttons
        btnAdd.Location = New Point(210, 50)
        btnAdd.Size = New Size(60, 40)
        btnAdd.Text = "+"
        
        btnSubtract.Location = New Point(210, 96)
        btnSubtract.Size = New Size(60, 40)
        btnSubtract.Text = "-"
        
        btnMultiply.Location = New Point(210, 142)
        btnMultiply.Size = New Size(60, 40)
        btnMultiply.Text = "×"
        
        btnDivide.Location = New Point(210, 188)
        btnDivide.Size = New Size(60, 40)
        btnDivide.Text = "÷"
        
        btnEquals.Location = New Point(144, 188)
        btnEquals.Size = New Size(60, 40)
        btnEquals.Text = "="
        
        btnClear.Location = New Point(12, 188)
        btnClear.Size = New Size(60, 40)
        btnClear.Text = "C"
        
        ' Form properties
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(282, 243)
        Controls.AddRange(New Control() {txtDisplay, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0, btnAdd, btnSubtract, btnMultiply, btnDivide, btnEquals, btnClear})
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnClear As Button
End Class
