<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm5
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm5))
        Me.lblText = New System.Windows.Forms.Label()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdID = New System.Windows.Forms.Button()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(13, 13)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(259, 23)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Label1"
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(197, 227)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 6
        Me.cmdBack.Text = "Button1"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdID
        '
        Me.cmdID.Location = New System.Drawing.Point(16, 227)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(75, 23)
        Me.cmdID.TabIndex = 7
        Me.cmdID.Text = "Button1"
        Me.cmdID.UseVisualStyleBackColor = True
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(16, 62)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(39, 13)
        Me.lbl10.TabIndex = 8
        Me.lbl10.Text = "Label1"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(16, 79)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(39, 13)
        Me.lbl11.TabIndex = 9
        Me.lbl11.Text = "Label1"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(19, 110)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(39, 13)
        Me.lbl12.TabIndex = 10
        Me.lbl12.Text = "Label1"
        '
        'frm5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.cmdID)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.lblText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdID As System.Windows.Forms.Button
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl12 As Label
End Class
