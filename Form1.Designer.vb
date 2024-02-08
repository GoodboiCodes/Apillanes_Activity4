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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblResult = New Label()
        txtFirstnum = New TextBox()
        txtSecondnum = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 15)
        Label1.TabIndex = 0
        Label1.Text = "Multiplication Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 1
        Label2.Text = "First Number: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 2
        Label3.Text = "Second Number: "
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(190, 132)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(48, 15)
        lblResult.TabIndex = 3
        lblResult.Text = "Result..."
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(154, 48)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(124, 23)
        txtFirstnum.TabIndex = 4
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(154, 82)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(124, 23)
        txtSecondnum.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(19, 132)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Multiply"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(335, 187)
        Controls.Add(Button1)
        Controls.Add(txtSecondnum)
        Controls.Add(txtFirstnum)
        Controls.Add(lblResult)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Button1 As Button
End Class
