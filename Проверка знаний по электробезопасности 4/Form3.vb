Public Class frmTest
    Dim Q00() As String

    Dim N() As Integer = {0, 1, 2, 3, 4, 5, 6, 7}
    Dim i As Integer = 0
    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        frm0.Hide()
        Me.Text = "Проверка знаний по эл. безопасности 4 группа"
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Size = New System.Drawing.Size(1400, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        lblText.Location = New System.Drawing.Point(20, 10)
        lblText.Size = New System.Drawing.Size(1330, 80)
        lblText.AutoSize = False
        lblText.Text = ""
        opt1.Location = New System.Drawing.Point(20, 90)
        opt1.Size = New System.Drawing.Size(1350, 90)
        opt1.Text = ""
        opt1.Checked = False
        opt1.AutoSize = False
        opt2.Location = New System.Drawing.Point(20, 180)
        opt2.Size = New System.Drawing.Size(1350, 90)
        opt2.Text = ""
        opt2.Checked = False
        opt2.AutoSize = False
        opt3.Location = New System.Drawing.Point(21, 270)
        opt3.Size = New System.Drawing.Size(1350, 90)
        opt3.Text = ""
        opt3.Checked = False
        opt3.AutoSize = False
        opt4.Location = New System.Drawing.Point(20, 360)
        opt4.Size = New System.Drawing.Size(1350, 90)
        opt4.Text = ""
        opt4.Checked = False
        opt4.AutoSize = False
        opt5.Location = New System.Drawing.Point(20, 450)
        opt5.Size = New System.Drawing.Size(1350, 90)
        opt5.Text = ""
        opt5.Checked = False
        opt5.AutoSize = False

        cmdBack.Text = "Назад"
        cmdBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdBack.Location = New System.Drawing.Point(1030, 600)
        cmdBack.Size = New System.Drawing.Size(170, 35)
        cmdID.Text = "Проверить"
        cmdID.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdID.Location = New System.Drawing.Point(160, 600)
        cmdID.Size = New System.Drawing.Size(205, 35)
        cmdID.Visible = True

        If opt1.Checked = False Then cmdID.Enabled = False
        If opt2.Checked = False Then cmdID.Enabled = False
        If opt3.Checked = False Then cmdID.Enabled = False
        If opt4.Checked = False Then cmdID.Enabled = False
        If opt5.Checked = False Then cmdID.Enabled = False

        frm0.Timer1.Enabled = False

        Ran()
        TxT()
        Us()
        Rt()
        Schit()
    End Sub
    Dim Vt(9) As Integer ' это случайный номер темы в разнобой. 10 последовательностей. генератор находиться на frm0
    Private Sub Ran()
        Dim A0 As Integer = CInt(Int((7 * Rnd()) + 1))
        If A0 = 1 Then
            Vt = frm0.V1
        End If
        If A0 = 2 Then
            Vt = frm0.V2
        End If
        If A0 = 3 Then
            Vt = frm0.V3
        End If
        If A0 = 4 Then
            Vt = frm0.V4
        End If
        If A0 = 5 Then
            Vt = frm0.V5
        End If
        If A0 = 6 Then
            Vt = frm0.V6
        End If
        If A0 = 7 Then
            Vt = frm0.V7
        End If
        If A0 = 8 Then
            Vt = frm0.V8
        End If
    End Sub 'случайный выбор файла с темой
    Dim O As Integer ' это номер строки в файле

    Public Sc As Integer ' это количество вопросов в теме

    Dim Kvp() As String = IO.File.ReadAllLines(Application.StartupPath & "\Kvp.dll", System.Text.Encoding.Default)
    Dim Z1 As Integer = Kvp(0)(0) + Kvp(0)(1)
    Dim Z2 As Integer = Kvp(0)(2) + Kvp(0)(3)
    Dim Z3 As Integer = Kvp(0)(4) + Kvp(0)(5)
    Dim Z4 As Integer = Kvp(0)(6) + Kvp(0)(7)
    Dim Z5 As Integer = Kvp(0)(8) + Kvp(0)(9)
    Dim Z6 As Integer = Kvp(0)(10) + Kvp(0)(11)
    Dim Z7 As Integer = Kvp(0)(12) + Kvp(0)(13)
    Dim Z8 As Integer = Kvp(0)(14) + Kvp(0)(15)
    Private Sub TxT()

        N(0) = 0 : N(1) = 1 : N(2) = 2 : N(3) = 3 : N(4) = 4 : N(5) = 5 : N(6) = 6 : N(7) = 7
        If Vt(i) = 1 Then Q00 = frm1.Q01 : Sc = Val(Z1)
        If Vt(i) = 2 Then Q00 = frm2.Q02 : Sc = Val(Z2)
        If Vt(i) = 3 Then Q00 = frm3.Q03 : Sc = Val(Z3)
        If Vt(i) = 4 Then Q00 = frm4.Q04 : Sc = Val(Z4)
        If Vt(i) = 5 Then Q00 = frm5.Q05 : Sc = Val(Z5)
        If Vt(i) = 6 Then Q00 = frm6.Q06 : Sc = Val(Z6)
        If Vt(i) = 7 Then Q00 = frm10.Q07 : Sc = Val(Z7)
        If Vt(i) = 8 Then Q00 = frm11.Q08 : Sc = Val(Z8)

        'проверка на совпадение тем
        'нужно сделать так: если такой вопрос уже был то  нужно подбирать другой
        'событие Us() подбирает последовательность вопроса, чтобы были в разнобой
        'оно должно отработать после проверки на совпадение вопросов в соответствующей теме
    End Sub 'случайный выбор вопроса
    Dim U As Integer
    Public Prm(6) As Integer ' случайная последоватеьность вариантов ответов
    Dim Gh(5) As Integer 'количество вариантов ответов
    Dim Qs(9) As Integer 'Количество вопросов

    Private Sub Us()
        U = CInt(Int((Sc * Rnd()) + 1)) 'случайный выбор вопроса в теме
        If U > Sc Then Us() 'если случайное число больше чем вопросов в теме, то начать выбор с начала
        Prm(6) = 7
        O = U * 8 - 8
        Qs(i) = U
        Dim j As Integer = i
        For k As Integer = 1 To i 'проверка на копии вопросов.
            If i <> 0 Then
                j -= 1
                If Vt(i) = Vt(j) Then
                    If i <> 0 Then
                        If Qs(i) = Qs(j) Then Us()
                    End If
                End If
            End If
        Next
        N(7) = O + Prm(6)
        If Val(Q00(N(7))(0)) = 3 Then Gen0()
        If Val(Q00(N(7))(0)) = 4 Then Gen1()
        If Val(Q00(N(7))(0)) = 5 Then Gen2()
        If Val(Q00(N(7))(0)) = 6 Then Gen3()
        'выбор количества вопросов в теме для случайного выбора
        N(0) = O
        N(1) = O + Prm(0)
        N(2) = O + Prm(1)
        N(3) = O + Prm(2)
        N(4) = O + Prm(3)
        N(5) = O + Prm(4)
        N(6) = O + Prm(5)
        If Q00.Length < N(7) Then
            MsgBox("В файле нет текста")
            Return
        End If
    End Sub 'перемешивание вариантов ответа и проверка на повторяемость вопросов
    Private Sub Gen0()
        Gh(0) = CInt(Int((3 * Rnd()) + 1)) : Prm(0) = Gh(0)
        Gh(1) = CInt(Int((3 * Rnd()) + 1)) : Prm(1) = Gh(1)
        Gh(2) = CInt(Int((3 * Rnd()) + 1)) : Prm(2) = Gh(2)
        Dim Z As Integer = 0
        Dim ij As Integer = 0
        For k As Integer = 1 To 2
            ij += 1
            If Gh(Z) = Gh(Z + ij) Then Gen0()
            If ij = 2 Then
                Z = 1 : ij = 1
                If Gh(Z) = Gh(Z + ij) Then Gen0()
            End If
        Next
    End Sub
    Private Sub Gen1()
        Gh(0) = CInt(Int((4 * Rnd()) + 1)) : Prm(0) = Gh(0)
        Gh(1) = CInt(Int((4 * Rnd()) + 1)) : Prm(1) = Gh(1)
        Gh(2) = CInt(Int((4 * Rnd()) + 1)) : Prm(2) = Gh(2)
        Gh(3) = CInt(Int((4 * Rnd()) + 1)) : Prm(3) = Gh(3)
        Dim Z As Integer = 0
        Dim ij As Integer = 0
        For k As Integer = 1 To 3
            ij += 1
            If Gh(Z) = Gh(Z + ij) Then Gen1()
            If ij = 3 Then
                Z = 1 : ij = 0
                For k1 As Integer = 1 To 2
                    ij += 1
                    If Gh(Z) = Gh(Z + ij) Then Gen1()
                    If ij = 2 Then
                        Z = 2 : ij = 1
                        If Gh(Z) = Gh(Z + ij) Then Gen1()
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub Gen2()
        Gh(0) = CInt(Int((5 * Rnd()) + 1)) : Prm(0) = Gh(0)
        Gh(1) = CInt(Int((5 * Rnd()) + 1)) : Prm(1) = Gh(1)
        Gh(2) = CInt(Int((5 * Rnd()) + 1)) : Prm(2) = Gh(2)
        Gh(3) = CInt(Int((5 * Rnd()) + 1)) : Prm(3) = Gh(3)
        Gh(4) = CInt(Int((5 * Rnd()) + 1)) : Prm(4) = Gh(4)
        Dim Z As Integer = 0
        Dim ij As Integer = 0
        For k As Integer = 1 To 4
            ij += 1
            If Gh(Z) = Gh(Z + ij) Then Gen2()
            If ij = 4 Then
                Z = 1 : ij = 0
                For k1 As Integer = 1 To 3
                    ij += 1
                    If Gh(Z) = Gh(Z + ij) Then Gen2()
                    If ij = 3 Then
                        Z = 2 : ij = 0
                        For k2 As Integer = 1 To 2
                            ij += 1
                            If Gh(Z) = Gh(Z + ij) Then Gen2()
                            If ij = 2 Then
                                Z = 3 : ij = 1
                                If Gh(Z) = Gh(Z + ij) Then Gen2()
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub Gen3()
        Gh(0) = CInt(Int((6 * Rnd()) + 1)) : Prm(0) = Gh(0)
        Gh(1) = CInt(Int((6 * Rnd()) + 1)) : Prm(1) = Gh(1)
        Gh(2) = CInt(Int((6 * Rnd()) + 1)) : Prm(2) = Gh(2)
        Gh(3) = CInt(Int((6 * Rnd()) + 1)) : Prm(3) = Gh(3)
        Gh(4) = CInt(Int((6 * Rnd()) + 1)) : Prm(4) = Gh(4)
        Gh(5) = CInt(Int((6 * Rnd()) + 1)) : Prm(5) = Gh(5)
        Dim Z As Integer = 0
        Dim ij As Integer = 0
        For k As Integer = 1 To 5
            ij += 1
            If Gh(Z) = Gh(Z + ij) Then Gen3()
            If ij = 5 Then
                Z = 1 : ij = 0
                For k1 As Integer = 1 To 4
                    ij += 1
                    If Gh(Z) = Gh(Z + ij) Then Gen3()
                    If ij = 4 Then
                        Z = 2 : ij = 0
                        For k2 As Integer = 1 To 3
                            ij += 1
                            If Gh(Z) = Gh(Z + ij) Then Gen3()
                            If ij = 3 Then
                                Z = 3 : ij = 0
                                For k3 As Integer = 1 To 2
                                    ij += 1
                                    If Gh(Z) = Gh(Z + ij) Then Gen3()
                                    If ij = 2 Then
                                        Z = 4 : ij = 1
                                        If Gh(Z) = Gh(Z + ij) Then Gen3()
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub Rt() ' Определяет сколько будет видно на форме вариантов ответов
        opt1.Visible = True
        opt2.Visible = True
        opt3.Visible = True
        opt4.Visible = True
        opt5.Visible = True

        If Q00.Length < N(7) Then Return
        If Val(Q00(N(7))(0)) = 1 Then opt2.Visible = False : opt3.Visible = False : opt4.Visible = False : opt5.Visible = False
        If Val(Q00(N(7))(0)) = 2 Then opt3.Visible = False : opt4.Visible = False : opt5.Visible = False
        If Val(Q00(N(7))(0)) = 3 Then opt4.Visible = False : opt5.Visible = False
        If Val(Q00(N(7))(0)) = 4 Then opt5.Visible = False




    End Sub 'определяем какое количество вариантов ответов будет доступно и видно
    Private Sub Schit() ' Считывает текст в поля
        If Q00.Length < N(7) Then Return

        Dim D1() As Integer = {Len(Q00(N(0))) - 1, Len(Q00(N(1))) - 1, Len(Q00(N(2))) - 1,
                               Len(Q00(N(3))) - 1, Len(Q00(N(4))) - 1, Len(Q00(N(5))) - 1}
        For i As Integer = 0 To D1(0)
            lblText.Text &= Q00(N(0))(i)
        Next
        For i As Integer = 0 To D1(1)
            opt1.Text &= Q00(N(1))(i)
        Next
        For i As Integer = 0 To D1(2)
            opt2.Text &= Q00(N(2))(i)
        Next
        For i As Integer = 0 To D1(3)
            opt3.Text &= Q00(N(3))(i)
        Next
        For i As Integer = 0 To D1(4)
            opt4.Text &= Q00(N(4))(i)
        Next
        For i As Integer = 0 To D1(5)
            opt5.Text &= Q00(N(5))(i)
        Next

    End Sub ' считываем текст в поля на форме
    Public A1(9) As String 'это текст выбранного вопроса
    Public A2(9) As String 'это текст "правильно" или "неправильно"
    Dim P1 As Integer
    Private Sub cmdID_Click(sender As Object, e As EventArgs) Handles cmdID.Click
        A1(i) = lblText.Text
        If Q00.Length < N(7) Then Exit Sub
        If P1 = Val(Q00(N(7))(1)) Then
            A2(i) = "Правильно"
        Else
            A2(i) = "Неправильно"
            opt1.Enabled = False
            opt2.Enabled = False
            opt3.Enabled = False
            opt4.Enabled = False
            opt5.Enabled = False

            If Val(Q00(N(7))(1)) = Prm(0) Then opt1.BackColor = Color.LightGreen : MsgBox("Это был неправильный ответ")
            If Val(Q00(N(7))(1)) = Prm(1) Then opt2.BackColor = Color.LightGreen : MsgBox("Это был неправильный ответ")
            If Val(Q00(N(7))(1)) = Prm(2) Then opt3.BackColor = Color.LightGreen : MsgBox("Это был неправильный ответ")
            If Val(Q00(N(7))(1)) = Prm(3) Then opt4.BackColor = Color.LightGreen : MsgBox("Это был неправильный ответ")
            If Val(Q00(N(7))(1)) = Prm(4) Then opt5.BackColor = Color.LightGreen : MsgBox("Это был неправильный ответ")


        End If

        i += 1
        If i = 10 Then frmX.Show() : Hide() : cmdID.Enabled = False : Exit Sub
        TxT()
        Us()
        Rt()
        CLS()
        Schit()
        If opt1.Checked = False Then cmdID.Enabled = False : opt1.Enabled = True
        If opt2.Checked = False Then cmdID.Enabled = False : opt2.Enabled = True
        If opt3.Checked = False Then cmdID.Enabled = False : opt3.Enabled = True
        If opt4.Checked = False Then cmdID.Enabled = False : opt4.Enabled = True
        If opt5.Checked = False Then cmdID.Enabled = False : opt5.Enabled = True

    End Sub
    Private Sub CLS()
        lblText.Text = ""
        opt1.Text = ""
        opt2.Text = ""
        opt3.Text = ""
        opt4.Text = ""
        opt5.Text = ""

        opt1.Checked = False
        opt2.Checked = False
        opt3.Checked = False
        opt4.Checked = False
        opt5.Checked = False

        opt1.BackColor = Color.FromArgb(240, 240, 240)
        opt2.BackColor = Color.FromArgb(240, 240, 240)
        opt3.BackColor = Color.FromArgb(240, 240, 240)
        opt4.BackColor = Color.FromArgb(240, 240, 240)
        opt5.BackColor = Color.FromArgb(240, 240, 240)

        P1 = 0
    End Sub

    Private Sub frmTest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm0.Show()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Close()
        frm0.Show()
    End Sub
    Private Sub opt1_CheckedChanged(sender As Object, e As EventArgs) Handles opt1.CheckedChanged
        P1 = Prm(0)
        cmdID.Enabled = True

    End Sub
    Private Sub opt2_CheckedChanged(sender As Object, e As EventArgs) Handles opt2.CheckedChanged
        P1 = Prm(1)
        cmdID.Enabled = True
    End Sub
    Private Sub opt3_CheckedChanged(sender As Object, e As EventArgs) Handles opt3.CheckedChanged
        P1 = Prm(2)
        cmdID.Enabled = True

    End Sub
    Private Sub opt4_CheckedChanged(sender As Object, e As EventArgs) Handles opt4.CheckedChanged
        P1 = Prm(3)
        cmdID.Enabled = True

    End Sub
    Private Sub opt5_CheckedChanged(sender As Object, e As EventArgs) Handles opt5.CheckedChanged
        P1 = Prm(4)
        cmdID.Enabled = True

    End Sub




End Class