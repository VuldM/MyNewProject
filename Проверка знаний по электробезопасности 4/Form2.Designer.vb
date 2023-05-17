<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.cmdID = New System.Windows.Forms.Button()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.МенюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(618, 600)
        Me.cmdBack.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(169, 35)
        Me.cmdBack.TabIndex = 0
        Me.cmdBack.Text = "Назад"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(6, 24)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(963, 81)
        Me.lblText.TabIndex = 1
        '
        'cmdID
        '
        Me.cmdID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdID.Location = New System.Drawing.Point(75, 600)
        Me.cmdID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(204, 35)
        Me.cmdID.TabIndex = 8
        Me.cmdID.Text = "Проверить"
        Me.cmdID.UseVisualStyleBackColor = True
        '
        'lbl10
        '
        Me.lbl10.Location = New System.Drawing.Point(13, 100)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(956, 94)
        Me.lbl10.TabIndex = 11
        Me.lbl10.Text = "Label1"
        '
        'lbl11
        '
        Me.lbl11.Location = New System.Drawing.Point(17, 194)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(952, 60)
        Me.lbl11.TabIndex = 12
        Me.lbl11.Text = "Label1"
        '
        'lbl12
        '
        Me.lbl12.Location = New System.Drawing.Point(17, 291)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(952, 83)
        Me.lbl12.TabIndex = 13
        Me.lbl12.Text = "Label1"
        '
        'lbl13
        '
        Me.lbl13.Location = New System.Drawing.Point(25, 400)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(944, 91)
        Me.lbl13.TabIndex = 14
        Me.lbl13.Text = "Label1"
        '
        'lbl14
        '
        Me.lbl14.Location = New System.Drawing.Point(29, 491)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(940, 94)
        Me.lbl14.TabIndex = 15
        Me.lbl14.Text = "Label1"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(324, 616)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(55, 19)
        Me.lbl1.TabIndex = 16
        Me.lbl1.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МенюToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(50, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "Дата"
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
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ОткрытьToolStripMenuItem.Text = "Открыть"
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 656)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.cmdID)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm1"
        Me.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Проверка знаний по эл. безопасности 4 группа"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents cmdID As System.Windows.Forms.Button
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents lbl14 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents МенюToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
End Class
