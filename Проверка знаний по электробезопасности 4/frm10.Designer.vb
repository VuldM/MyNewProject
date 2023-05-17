<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm10))
        Me.cmdID = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdID
        '
        Me.cmdID.Location = New System.Drawing.Point(311, 394)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(75, 23)
        Me.cmdID.TabIndex = 6
        Me.cmdID.Text = "Button1"
        Me.cmdID.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(616, 395)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 7
        Me.cmdBack.Text = "Button2"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(452, 27)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(39, 13)
        Me.lblText.TabIndex = 8
        Me.lblText.Text = "Label1"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(452, 416)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 9
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(329, 425)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 10
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(41, 93)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(39, 13)
        Me.lbl10.TabIndex = 11
        Me.lbl10.Text = "Label1"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(40, 126)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(39, 13)
        Me.lbl11.TabIndex = 12
        Me.lbl11.Text = "Label1"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(44, 167)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(39, 13)
        Me.lbl12.TabIndex = 13
        Me.lbl12.Text = "Label1"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Location = New System.Drawing.Point(43, 198)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(39, 13)
        Me.lbl13.TabIndex = 14
        Me.lbl13.Text = "Label1"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Location = New System.Drawing.Point(43, 228)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(39, 13)
        Me.lbl14.TabIndex = 15
        Me.lbl14.Text = "Label1"
        '
        'frm10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdID As Button
    Friend WithEvents cmdBack As Button
    Friend WithEvents lblText As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents lbl14 As Label
End Class
