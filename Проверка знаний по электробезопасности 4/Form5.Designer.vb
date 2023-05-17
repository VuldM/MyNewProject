<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm3))
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdID = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.МенюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(199, 221)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 0
        Me.cmdBack.Text = "Button1"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdID
        '
        Me.cmdID.Location = New System.Drawing.Point(13, 221)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(75, 23)
        Me.cmdID.TabIndex = 1
        Me.cmdID.Text = "Button1"
        Me.cmdID.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(55, 88)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(167, 23)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "Label1"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(13, 61)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(39, 13)
        Me.lbl10.TabIndex = 3
        Me.lbl10.Text = "Label1"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(10, 88)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(39, 13)
        Me.lbl11.TabIndex = 4
        Me.lbl11.Text = "Label1"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(16, 114)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(39, 13)
        Me.lbl12.TabIndex = 5
        Me.lbl12.Text = "Label1"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Location = New System.Drawing.Point(19, 131)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(39, 13)
        Me.lbl13.TabIndex = 6
        Me.lbl13.Text = "Label1"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Location = New System.Drawing.Point(19, 157)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(39, 13)
        Me.lbl14.TabIndex = 7
        Me.lbl14.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МенюToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'МенюToolStripMenuItem
        '
        Me.МенюToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СохранитьToolStripMenuItem, Me.ОткрытьToolStripMenuItem})
        Me.МенюToolStripMenuItem.Name = "МенюToolStripMenuItem"
        Me.МенюToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.МенюToolStripMenuItem.Text = "Меню"
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ОткрытьToolStripMenuItem.Text = "Открыть"
        '
        'frm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.cmdID)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdID As System.Windows.Forms.Button
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents lbl14 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents МенюToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
End Class
