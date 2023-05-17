Public Class frm0
    'во вермя загрузки этой формы генератор должен сгенерировать три кода из шести тем для десяти вопросов
    'затем при смене каждого вопроса генератор должен выбирать из этих трех кодов один для следующего вопроса.
    'должен герерирвать случайное число являющимся вопросом в соответствии с количеством вопросов в теме.
    '


    Private Sub Fal() ' Проверяем существуют ли файлы. Если нет то создаем их.
        If IO.File.Exists(Application.StartupPath & "\Kvp.dll") Then
        Else
            IO.File.Create(Application.StartupPath & "\Kvp.dll").Close()

            FileOpen(1, Application.StartupPath & "\Kvp.dll", OpenMode.Output)
            Print(1, "9890822210101050")
            FileClose(1)
        End If
     

        If IO.File.Exists(Application.StartupPath & "\T1.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T1.pz").Close()
            FileOpen(1, Application.StartupPath & "\T1.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If

        If IO.File.Exists(Application.StartupPath & "\T2.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T2.pz").Close()
            FileOpen(1, Application.StartupPath & "\T2.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If

        If IO.File.Exists(Application.StartupPath & "\T3.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T3.pz").Close()
            FileOpen(1, Application.StartupPath & "\T3.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If

        If IO.File.Exists(Application.StartupPath & "\T4.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T4.pz").Close()
            FileOpen(1, Application.StartupPath & "\T4.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If

        If IO.File.Exists(Application.StartupPath & "\T5.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T5.pz").Close()
            FileOpen(1, Application.StartupPath & "\T5.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If

        If IO.File.Exists(Application.StartupPath & "\T6.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T6.pz").Close()
            FileOpen(1, Application.StartupPath & "\T6.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If
        If IO.File.Exists(Application.StartupPath & "\T7.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T7.pz").Close()
            FileOpen(1, Application.StartupPath & "\T7.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If
        If IO.File.Exists(Application.StartupPath & "\T8.pz") Then
        Else
            IO.File.Create(Application.StartupPath & "\T8.pz").Close()
            FileOpen(1, Application.StartupPath & "\T8.pz", OpenMode.Output)
            Print(1, "")
            FileClose(1)
        End If
        

    End Sub
    Private Sub frm0_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Fal()

        Me.StartPosition = FormStartPosition.CenterScreen
        frmTest.Hide()
        cmd1.Text = "ПОТЭЭУ"
        cmd2.Text = "ПТЭЭП"
        cmd3.Text = "ПУЭ"
        cmd4.Text = "Инструкции по переключениям"
        cmd5.Text = "Инструкция по оказанию первой медицинской помощи"
        cmd6.Text = "Инстукция по испытанию и приминению средств защины"
        cmd7.Text = "Привила противопожарного режима в РФ"
        cmd8.Text = "Правила работы с персоналом"
        Timer1.Enabled = True
        Timer1.Interval = 100
    End Sub
    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        frmTest.Show()
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        frm6.Show()
    End Sub
    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        frm1.Visible = True
    End Sub
    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        frm2.Show()
    End Sub
    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        frm3.Show()
    End Sub
    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        frm4.Show()
    End Sub
    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        frm5.Show()
    End Sub
    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        frm10.Show()
    End Sub
    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        frm11.Show()
    End Sub
    Dim Randomize()
    Public V1(9) As Integer
    Public V2(9) As Integer
    Public V3(9) As Integer
    Public V4(9) As Integer
    Public V5(9) As Integer
    Public V6(9) As Integer
    Public V7(9) As Integer
    Public V8(9) As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'генератор последовательности тем
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V1(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V2(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V3(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V4(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V5(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V6(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V7(i) = A
        Next i
        For i As Integer = 0 To 9
            Dim A As Integer = CInt(Int((9 * Rnd()) + 1))
            V8(i) = A
        Next i
    End Sub
End Class