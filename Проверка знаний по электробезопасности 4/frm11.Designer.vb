<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm11))
        Me.lblText = New System.Windows.Forms.Label()
        Me.cmdID = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
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
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(69, 46)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(38, 13)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "lblText"
        '
        'cmdID
        '
        Me.cmdID.Location = New System.Drawing.Point(122, 366)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(75, 23)
        Me.cmdID.TabIndex = 1
        Me.cmdID.Text = "cmdID"
        Me.cmdID.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(612, 365)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 2
        Me.cmdBack.Text = "cmdBack"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(54, 80)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(39, 13)
        Me.lbl10.TabIndex = 3
        Me.lbl10.Text = "Label1"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(57, 114)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(39, 13)
        Me.lbl11.TabIndex = 4
        Me.lbl11.Text = "Label1"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(68, 146)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(39, 13)
        Me.lbl12.TabIndex = 5
        Me.lbl12.Text = "Label1"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Location = New System.Drawing.Point(57, 179)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(39, 13)
        Me.lbl13.TabIndex = 6
        Me.lbl13.Text = "Label1"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Location = New System.Drawing.Point(60, 221)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
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
        'frm11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdID)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm11"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents cmdID As Button
    Friend WithEvents cmdBack As Button
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
