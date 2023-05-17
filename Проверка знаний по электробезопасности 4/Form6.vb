Public Class frm4
    Public Q04() As String = IO.File.ReadAllLines(Application.StartupPath & "\T4.pz", System.Text.Encoding.Default)

    Dim N() As Integer = {0, 1, 2, 3, 4, 5, 6, 7}

    Private Sub CLS()
        lblText.Text = ""
        lbl10.Text = ""
        lbl11.Text = ""
        lbl12.Text = ""
        lbl13.Text = ""
        lbl14.Text = ""
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        N(0) += 8
        N(1) += 8
        N(2) += 8
        N(3) += 8
        N(4) += 8
        N(5) += 8
        N(6) += 8
        P = 0

    End Sub

    Private Sub Schit()
        If Q04.Length < N(7) Then Return
        Dim D1() As Integer = {Len(Q04(N(0))) - 1, Len(Q04(N(1))) - 1, Len(Q04(N(2))) - 1,
                               Len(Q04(N(3))) - 1, Len(Q04(N(4))) - 1, Len(Q04(N(5))) - 1, Len(Q04(N(6))) - 1}

        For i As Integer = 0 To D1(0)
            lblText.Text &= Q04(N(0))(i)
        Next i
        For i As Integer = 0 To D1(1)
            lbl10.Text &= Q04(N(1))(i)
        Next i
        For i As Integer = 0 To D1(2)
            lbl11.Text &= Q04(N(2))(i)
        Next i
        For i As Integer = 0 To D1(3)
            lbl12.Text &= Q04(N(3))(i)
        Next i
        For i As Integer = 0 To D1(4)
            lbl13.Text &= Q04(N(4))(i)
        Next i
        For i As Integer = 0 To D1(5)
            lbl14.Text &= Q04(N(5))(i)
        Next i


    End Sub
    Dim P As Integer
    Private i As Integer = 0
    Private Sub Rt()
        If Q04.Length < N(7) Then cmdID.Enabled = False : Return
        lbl10.Visible = True
        lbl11.Visible = True
        lbl12.Visible = True
        lbl13.Visible = True
        lbl14.Visible = True

        If Val(Q04(N(7))(0)) = 1 Then lbl11.Visible = False : lbl12.Visible = False : lbl13.Visible = False : lbl14.Visible = False
        If Val(Q04(N(7))(0)) = 2 Then lbl12.Visible = False : lbl13.Visible = False : lbl14.Visible = False
        If Val(Q04(N(7))(0)) = 3 Then lbl13.Visible = False : lbl14.Visible = False
        If Val(Q04(N(7))(0)) = 4 Then lbl14.Visible = False


    End Sub
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm0.Hide()


        Me.Text = "тема: Правила переключений в электроустановках"
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Size = New System.Drawing.Size(1050, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        lblText.Location = New System.Drawing.Point(20, 30)
        lblText.Size = New System.Drawing.Size(1000, 80)
        lblText.AutoSize = True
        lblText.MaximumSize = New Size(1000, 80)
        lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lblText.Text = ""
        lbl10.Location = New System.Drawing.Point(20, 90)
        lbl10.Size = New System.Drawing.Size(1000, 120)
        lbl10.Text = ""
        lbl10.AutoSize = True
        lbl10.MaximumSize = New Size(1000, 120)
        lbl11.Location = New System.Drawing.Point(20, 180)
        lbl11.Size = New System.Drawing.Size(1000, 120)
        lbl11.Text = ""
        lbl11.AutoSize = True
        lbl11.MaximumSize = New Size(1000, 120)
        lbl12.Location = New System.Drawing.Point(21, 270)
        lbl12.Size = New System.Drawing.Size(1000, 120)
        lbl12.Text = ""
        lbl12.AutoSize = True
        lbl12.MaximumSize = New Size(1000, 120)
        lbl13.Location = New System.Drawing.Point(20, 360)
        lbl13.Size = New System.Drawing.Size(1000, 120)
        lbl13.Text = ""
        lbl13.AutoSize = True
        lbl13.MaximumSize = New Size(1000, 60)
        lbl14.Location = New System.Drawing.Point(20, 450)
        lbl14.Size = New System.Drawing.Size(1000, 120)
        lbl14.Text = ""
        lbl14.AutoSize = True
        lbl14.MaximumSize = New Size(1000, 120)

        cmdBack.Text = "Назад"
        cmdBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdBack.Location = New System.Drawing.Point(200, 600)
        cmdBack.Size = New System.Drawing.Size(170, 35)
        cmdID.Text = "Проверить"
        cmdID.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdID.Location = New System.Drawing.Point(175, 600)
        cmdID.Size = New System.Drawing.Size(205, 35)
        cmdID.Visible = True
        Loc()
        Schit()
        Rt()
    End Sub

    Private Sub Loc()
        Dim A() As Long = {0, 0, 0, 0, 0, 0, 0, 0}

        If Len(Q04(N(0))) < 605 Then A(0) = 250
        If Len(Q04(N(0))) < 480 Then A(0) = 200
        If Len(Q04(N(0))) < 360 Then A(0) = 150
        If Len(Q04(N(0))) < 240 Then A(0) = 100
        If Len(Q04(N(0))) < 120 Then A(0) = 90

        If Len(Q04(N(1))) < 605 Then A(1) = A(0) + 140
        If Len(Q04(N(1))) < 480 Then A(1) = A(0) + 115
        If Len(Q04(N(1))) < 360 Then A(1) = A(0) + 90
        If Len(Q04(N(1))) < 240 Then A(1) = A(0) + 65
        If Len(Q04(N(1))) < 125 Then A(1) = A(0) + 35

        If Len(Q04(N(2))) < 605 Then A(2) = A(1) + 140
        If Len(Q04(N(2))) < 480 Then A(2) = A(1) + 115
        If Len(Q04(N(2))) < 360 Then A(2) = A(1) + 90
        If Len(Q04(N(2))) < 240 Then A(2) = A(1) + 65
        If Len(Q04(N(2))) < 120 Then A(2) = A(1) + 35

        If Len(Q04(N(3))) < 605 Then A(3) = A(2) + 140
        If Len(Q04(N(3))) < 480 Then A(3) = A(2) + 115
        If Len(Q04(N(3))) < 360 Then A(3) = A(2) + 90
        If Len(Q04(N(3))) < 240 Then A(3) = A(2) + 65
        If Len(Q04(N(3))) < 120 Then A(3) = A(2) + 35

        If Len(Q04(N(4))) < 605 Then A(4) = A(3) + 140
        If Len(Q04(N(4))) < 480 Then A(4) = A(3) + 115
        If Len(Q04(N(4))) < 360 Then A(4) = A(3) + 90
        If Len(Q04(N(4))) < 240 Then A(4) = A(3) + 65
        If Len(Q04(N(4))) < 120 Then A(4) = A(3) + 35


        A(5) = A(4) + 50
        A(6) = A(4) + 50
        A(7) = A(5) + 100
        Me.Size = New Size(1050, A(7))
        lbl10.Location = New Point(20, A(0))
        lbl11.Location = New Point(20, A(1))
        lbl12.Location = New Point(20, A(2))
        lbl13.Location = New Point(20, A(3))
        lbl14.Location = New Point(20, A(4))
        cmdID.Location = New Point(75, A(5))
        cmdBack.Location = New Point(650, A(6))
    End Sub
    Private Sub cmdID_Click(sender As Object, e As EventArgs) Handles cmdID.Click


        If P = Val(Q04(N(7))(1)) Then 'если правильный ответ соответствует выбранному то:
            i += 1


            N(7) += 8  'Номер строки с кодом определения


            If Q04.Length <= N(7) Then  'Если количество строк в файле меньше или равно N(7) 
                MsgBox("Вы закончили подготовку по этой теме")
                Me.Close()
                frm0.Show()
                Exit Sub
            Else
                Rt()
                CLS()
                Schit()
                Loc()
            End If
        Else
            If Val(Q04(N(7))(1)) = 1 Then lbl10.BackColor = Color.LightGreen
            If Val(Q04(N(7))(1)) = 2 Then lbl11.BackColor = Color.LightGreen
            If Val(Q04(N(7))(1)) = 3 Then lbl12.BackColor = Color.LightGreen
            If Val(Q04(N(7))(1)) = 4 Then lbl13.BackColor = Color.LightGreen
            If Val(Q04(N(7))(1)) = 5 Then lbl14.BackColor = Color.LightGreen


        End If


    End Sub




    Private Sub lbl10_Click(sender As Object, e As EventArgs) Handles lbl10.Click
        P = 1
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl10.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl11_Click(sender As Object, e As EventArgs) Handles lbl11.Click
        P = 2
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl12_Click(sender As Object, e As EventArgs) Handles lbl12.Click
        P = 3
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl13_Click(sender As Object, e As EventArgs) Handles lbl13.Click
        P = 4
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl14_Click(sender As Object, e As EventArgs) Handles lbl14.Click
        P = 5
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.LightBlue
    End Sub

    Private Sub frm1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm0.Show()
    End Sub
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Close()
        frm0.Show()
    End Sub

    Private Sub frm1_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        P = 0
    End Sub
    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        'Me.SaveFileDialog1.ShowDialog()
        'Dim Save As New SaveFileDialog

        ' If Save.ShowDialog = Windows.Forms.DialogResult.OK Then

        'End If
        If IO.File.Exists(Application.StartupPath & "\Save3.dll") Then
        Else
            IO.File.Create(Application.StartupPath & "\Save3.dll").Close()
            FileOpen(1, Application.StartupPath & "\Save3.dll", OpenMode.Output)
            Print(1, " ")
            FileClose(1)
        End If
        FileOpen(1, Application.StartupPath & "\Save3.dll", OpenMode.Output)
        Print(1, " ")
        FileClose(1)
        'IO.File.AppendText(Application.StartupPath & "\Save.dll").Close()
        'Dim myarray As String = N()
        ' Dim FileName As String = Application.StartupPath & "\Save.dll"

        'IO.File.WriteAllLines(FileName, myarray)

        '  Dim Split() = From str In File.ReadAllText(filePath).Split("|"c)
        '  Select Double.Parse(str)
        '  Dim numbers As Long() = Split.ToArray()
        ' Dim str As String = InputBox("Введите ваш табельный номер", "Авторизация")

        Dim outFile As IO.StreamWriter
        Dim intC As Integer = 0

        outFile = IO.File.AppendText("Save3.dll")
        outFile.WriteLine(N(0))
        'Do Until i = 6           'Повторяйте цикл до тех пор, пока <условие> не будет True.
        ' Do While intC <= 7      'Повторяйте цикл до тех пор, пока <условие> не будет False.
        '    intC += 1
        ' Loop                    'Завершает определение Do цикла.

        outFile.Close()

    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        'Me.OpenFileDialog1.ShowDialog()
        'Dim FileName As String = Application.StartupPath & "\myarray.txt"
        'Dim myarray() As String = File.ReadAllLines(FileName)

        Dim inFile As IO.StreamReader
        ' Dim strInfo As String
        Dim strInfo As String
        If IO.File.Exists("Save3.dll") Then
            inFile = IO.File.OpenText("Save3.dll")
            strInfo = inFile.ReadLine
            Dim vOut As Long = Convert.ToInt64(strInfo)
            N(0) = vOut
            N(0) = N(0) - 8
            For i = 0 To 6
                N(i + 1) = N(i) + 1
            Next
            inFile.Close()
            N(7) = N(7) + 8
            Rt()
            CLS()
            Schit()
            Loc()

        Else
            MessageBox.Show("Can't find the persons.txt file", "Person Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class