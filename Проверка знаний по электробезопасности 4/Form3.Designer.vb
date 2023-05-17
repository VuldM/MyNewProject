<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest))
        Me.lblText = New System.Windows.Forms.Label()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt5 = New System.Windows.Forms.RadioButton()
        Me.cmdID = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(13, 13)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(39, 13)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Label1"
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(29, 70)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(14, 13)
        Me.opt1.TabIndex = 1
        Me.opt1.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(38, 122)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(14, 13)
        Me.opt2.TabIndex = 2
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(29, 172)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(14, 13)
        Me.opt3.TabIndex = 3
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(16, 213)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(14, 13)
        Me.opt4.TabIndex = 4
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt5
        '
        Me.opt5.AutoSize = True
        Me.opt5.Location = New System.Drawing.Point(29, 272)
        Me.opt5.Name = "opt5"
        Me.opt5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.opt5.Size = New System.Drawing.Size(14, 13)
        Me.opt5.TabIndex = 5
        Me.opt5.UseVisualStyleBackColor = True
        '
        'cmdID
        '
        Me.cmdID.Location = New System.Drawing.Point(49, 355)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(75, 23)
        Me.cmdID.TabIndex = 6
        Me.cmdID.Text = "Button1"
        Me.cmdID.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(479, 355)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 7
        Me.cmdBack.Text = "cmdBack"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 700)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdID)
        Me.Controls.Add(Me.opt5)
        Me.Controls.Add(Me.opt4)
        Me.Controls.Add(Me.opt3)
        Me.Controls.Add(Me.opt2)
        Me.Controls.Add(Me.opt1)
        Me.Controls.Add(Me.lblText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Экзамен"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt5 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdID As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
End Class
