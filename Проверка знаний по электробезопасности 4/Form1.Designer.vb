<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm0
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm0))
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd1.Location = New System.Drawing.Point(15, 13)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(498, 30)
        Me.cmd1.TabIndex = 0
        Me.cmd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd2.Location = New System.Drawing.Point(15, 50)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(498, 29)
        Me.cmd2.TabIndex = 1
        Me.cmd2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd3.Location = New System.Drawing.Point(15, 85)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(498, 28)
        Me.cmd3.TabIndex = 2
        Me.cmd3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd4.Location = New System.Drawing.Point(15, 121)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(498, 27)
        Me.cmd4.TabIndex = 3
        Me.cmd4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd5.Location = New System.Drawing.Point(15, 155)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(498, 28)
        Me.cmd5.TabIndex = 4
        Me.cmd5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmd6.Location = New System.Drawing.Point(15, 190)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(498, 27)
        Me.cmd6.TabIndex = 5
        Me.cmd6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmdTest
        '
        Me.cmdTest.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest.Location = New System.Drawing.Point(15, 331)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(498, 27)
        Me.cmdTest.TabIndex = 6
        Me.cmdTest.Text = "Сдать экзамен"
        Me.cmdTest.UseVisualStyleBackColor = True
        Me.cmdTest.Visible = False
        '
        'Timer1
        '
        '
        'cmd7
        '
        Me.cmd7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmd7.Location = New System.Drawing.Point(15, 223)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(498, 27)
        Me.cmd7.TabIndex = 7
        Me.cmd7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmd8.Location = New System.Drawing.Point(15, 261)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(498, 27)
        Me.cmd8.TabIndex = 8
        Me.cmd8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'frm0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 370)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Проверка знаний по эл. безопасности 4 группа"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents cmd5 As System.Windows.Forms.Button
    Friend WithEvents cmd6 As System.Windows.Forms.Button
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
End Class
