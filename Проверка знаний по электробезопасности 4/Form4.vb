Public Class frm2
    Public Q02() As String = IO.File.ReadAllLines(Application.StartupPath & "\T2.pz", System.Text.Encoding.Default)

    Dim N() As Integer = {0, 1, 2, 3, 4, 5, 6, 7}

    Private Sub CLS()
        lbltext.Text = ""
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
        If Val(Q02(N(7))(2)) > 0 Then Vybor()
    End Sub
    Private Sub Vybor()

        Dim A() As Long = {0, 0, 0, 0, 0, 0, 0, 0}


        If Len(Q02(N(0))) < 605 Then A(0) = 250
        If Len(Q02(N(0))) < 480 Then A(0) = 200
        If Len(Q02(N(0))) < 360 Then A(0) = 150
        If Len(Q02(N(0))) < 240 Then A(0) = 100
        If Len(Q02(N(0))) < 120 Then A(0) = 90

        If Len(Q02(N(1))) < 605 Then A(1) = A(0) + 140
        If Len(Q02(N(1))) < 480 Then A(1) = A(0) + 115
        If Len(Q02(N(1))) < 360 Then A(1) = A(0) + 90
        If Len(Q02(N(1))) < 240 Then A(1) = A(0) + 65
        If Len(Q02(N(1))) < 125 Then A(1) = A(0) + 35

        If Len(Q02(N(2))) < 605 Then A(2) = A(1) + 140
        If Len(Q02(N(2))) < 480 Then A(2) = A(1) + 115
        If Len(Q02(N(2))) < 360 Then A(2) = A(1) + 90
        If Len(Q02(N(2))) < 240 Then A(2) = A(1) + 65
        If Len(Q02(N(2))) < 120 Then A(2) = A(1) + 35

        If Len(Q02(N(3))) < 605 Then A(3) = A(2) + 140
        If Len(Q02(N(3))) < 480 Then A(3) = A(2) + 115
        If Len(Q02(N(3))) < 360 Then A(3) = A(2) + 90
        If Len(Q02(N(3))) < 240 Then A(3) = A(2) + 65
        If Len(Q02(N(3))) < 120 Then A(3) = A(2) + 35

        If Len(Q02(N(4))) < 605 Then A(4) = A(3) + 140
        If Len(Q02(N(4))) < 480 Then A(4) = A(3) + 115
        If Len(Q02(N(4))) < 360 Then A(4) = A(3) + 90
        If Len(Q02(N(4))) < 240 Then A(4) = A(3) + 65
        If Len(Q02(N(4))) < 120 Then A(4) = A(3) + 35


        A(5) = A(4) + 50
        A(6) = A(4) + 50
        A(7) = A(5) + 100
        Me.Size = New Size(1050, A(7))
        lbltext.Visible = False
        lblText1.Visible = True
        lbl20.Location = New Point(20, A(0))
        lbl10.Visible = False
        lbl20.Visible = True
        lbl21.Location = New Point(20, A(1))
        lbl11.Visible = False
        lbl21.Visible = True
        lbl22.Location = New Point(20, A(2))
        lbl12.Visible = False
        lbl22.Visible = True
        lbl23.Location = New Point(20, A(3))
        lbl13.Visible = False
        lbl23.Visible = True
        lbl24.Location = New Point(20, A(4))
        lbl14.Visible = False
        lbl24.Visible = True

        cmdID1.Location = New Point(75, A(5))
        cmdID1.Visible = True
        cmdID.Visible = False
        cmdBack.Location = New Point(650, A(6))

        If Q02.Length < N(6) Then Return
        Dim D1() As Integer = {Len(Q02(N(0))) - 1, Len(Q02(N(1))) - 1, Len(Q02(N(2))) - 1,
                               Len(Q02(N(3))) - 1, Len(Q02(N(4))) - 1, Len(Q02(N(5))) - 1}

        For i As Integer = 0 To D1(0)
            lblText1.Text &= Q02(N(0))(i)
        Next i
        For i As Integer = 0 To D1(1)
            lbl20.Text &= Q02(N(1))(i)
        Next i
        For i As Integer = 0 To D1(2)
            lbl21.Text &= Q02(N(2))(i)
        Next i
        For i As Integer = 0 To D1(3)
            lbl22.Text &= Q02(N(3))(i)
        Next i
        For i As Integer = 0 To D1(4)
            lbl23.Text &= Q02(N(4))(i)
        Next i
        For i As Integer = 0 To D1(5)
            lbl24.Text &= Q02(N(5))(i)
        Next i
    End Sub

    Private Sub Schit()
        If Q02.Length < N(7) Then Return
        Dim D1() As Integer = {Len(Q02(N(0))) - 1, Len(Q02(N(1))) - 1, Len(Q02(N(2))) - 1,
                               Len(Q02(N(3))) - 1, Len(Q02(N(4))) - 1, Len(Q02(N(5))) - 1, Len(Q02(N(6))) - 1}

        For i As Integer = 0 To D1(0)
            lbltext.Text &= Q02(N(0))(i)
        Next i
        For i As Integer = 0 To D1(1)
            lbl10.Text &= Q02(N(1))(i)
        Next i
        For i As Integer = 0 To D1(2)
            lbl11.Text &= Q02(N(2))(i)
        Next i
        For i As Integer = 0 To D1(3)
            lbl12.Text &= Q02(N(3))(i)
        Next i
        For i As Integer = 0 To D1(4)
            lbl13.Text &= Q02(N(4))(i)
        Next i
        For i As Integer = 0 To D1(5)
            lbl14.Text &= Q02(N(5))(i)
        Next i
        For i As Integer = 0 To D1(6)
            lbl15.Text &= Q02(N(6))(i)
        Next i

    End Sub
    Dim P As Integer

    Private Sub Rt()
        If Q02.Length < N(7) Then cmdID.Enabled = False : Return
        lbl10.Visible = True
        lbl11.Visible = True
        lbl12.Visible = True
        lbl13.Visible = True
        lbl14.Visible = True
        lbl15.Visible = True
        If Val(Q02(N(7))(0)) = 1 Then lbl11.Visible = False : lbl12.Visible = False : lbl13.Visible = False : lbl14.Visible = False : lbl15.Visible = False
        If Val(Q02(N(7))(0)) = 2 Then lbl12.Visible = False : lbl13.Visible = False : lbl14.Visible = False : lbl15.Visible = False
        If Val(Q02(N(7))(0)) = 3 Then lbl13.Visible = False : lbl14.Visible = False : lbl15.Visible = False
        If Val(Q02(N(7))(0)) = 4 Then lbl14.Visible = False : lbl15.Visible = False
        If Val(Q02(N(7))(0)) = 5 Then lbl15.Visible = False


    End Sub
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm0.Hide()
        Me.Text = "тема: Правила технической эксплуатации электроустановок потребителей электрической энергии "
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Size = New System.Drawing.Size(1050, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        lbltext.Location = New System.Drawing.Point(20, 30)
        lbltext.Size = New System.Drawing.Size(1000, 80)
        lbltext.AutoSize = True
        lbltext.MaximumSize = New Size(1000, 80)
        lbltext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lblText1.Location = New System.Drawing.Point(20, 30)
        lblText1.Size = New System.Drawing.Size(1000, 80)
        lblText1.AutoSize = True
        lblText1.MaximumSize = New Size(1000, 80)
        lblText1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbltext.Text = ""
        lblText1.Text = ""
        lbl10.Location = New System.Drawing.Point(20, 90)
        lbl10.Size = New System.Drawing.Size(1000, 120)
        lbl10.Text = ""
        lbl10.AutoSize = True
        lbl10.MaximumSize = New Size(1000, 120)
        lbl20.Location = New System.Drawing.Point(20, 90)
        lbl20.Size = New System.Drawing.Size(1000, 120)
        lbl20.Text = ""
        lbl20.AutoSize = True
        lbl20.MaximumSize = New Size(1000, 120)
        lbl20.Visible = False
        lbl11.Location = New System.Drawing.Point(20, 180)
        lbl11.Size = New System.Drawing.Size(1000, 120)
        lbl11.Text = ""
        lbl11.AutoSize = True
        lbl11.MaximumSize = New Size(1000, 120)
        lbl21.Location = New System.Drawing.Point(20, 180)
        lbl21.Size = New System.Drawing.Size(1000, 120)
        lbl21.Text = ""
        lbl21.AutoSize = True
        lbl21.MaximumSize = New Size(1000, 120)
        lbl21.Visible = False
        lbl12.Location = New System.Drawing.Point(21, 270)
        lbl12.Size = New System.Drawing.Size(1000, 120)
        lbl12.Text = ""
        lbl12.AutoSize = True
        lbl12.MaximumSize = New Size(1000, 120)
        lbl22.Location = New System.Drawing.Point(21, 270)
        lbl22.Size = New System.Drawing.Size(1000, 120)
        lbl22.Text = ""
        lbl22.AutoSize = True
        lbl22.MaximumSize = New Size(1000, 120)
        lbl22.Visible = False
        lbl13.Location = New System.Drawing.Point(20, 360)
        lbl13.Size = New System.Drawing.Size(1000, 120)
        lbl13.Text = ""
        lbl13.AutoSize = True
        lbl13.MaximumSize = New Size(1000, 60)
        lbl23.Location = New System.Drawing.Point(20, 360)
        lbl23.Size = New System.Drawing.Size(1000, 120)
        lbl23.Text = ""
        lbl23.AutoSize = True
        lbl23.MaximumSize = New Size(1000, 60)
        lbl23.Visible = False
        lbl14.Location = New System.Drawing.Point(20, 450)
        lbl14.Size = New System.Drawing.Size(1000, 120)
        lbl14.Text = ""
        lbl14.AutoSize = True
        lbl14.MaximumSize = New Size(1000, 120)
        lbl24.Location = New System.Drawing.Point(20, 450)
        lbl24.Size = New System.Drawing.Size(1000, 120)
        lbl24.Text = ""
        lbl24.AutoSize = True
        lbl24.MaximumSize = New Size(1000, 120)
        lbl24.Visible = False
        lbl15.Location = New System.Drawing.Point(20, 540)
        lbl15.Size = New System.Drawing.Size(1000, 120)
        lbl15.Text = ""
        lbl15.AutoSize = True
        lbl15.MaximumSize = New Size(1000, 120)
        cmdBack.Text = "Назад"
        cmdBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdBack.Location = New System.Drawing.Point(200, 600)
        cmdBack.Size = New System.Drawing.Size(170, 35)
        cmdID.Text = "Проверить"
        cmdID.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdID.Location = New System.Drawing.Point(175, 600)
        cmdID.Size = New System.Drawing.Size(205, 35)
        cmdID.Visible = True
        cmdID1.Text = "Проверить"
        cmdID1.Font = New System.Drawing.Font("Times New Roman", 12.0!, FontStyle.Bold)
        cmdID1.Location = New System.Drawing.Point(175, 600)
        cmdID1.Size = New System.Drawing.Size(205, 35)
        cmdID1.Visible = False
        Loc()
        Schit()
        Rt()
    End Sub

    Private Sub Loc()
        Dim A() As Long = {0, 0, 0, 0, 0, 0, 0, 0, 0}

        If Len(Q02(N(0))) < 605 Then A(0) = 250
        If Len(Q02(N(0))) < 480 Then A(0) = 200
        If Len(Q02(N(0))) < 360 Then A(0) = 150
        If Len(Q02(N(0))) < 240 Then A(0) = 100
        If Len(Q02(N(0))) < 120 Then A(0) = 90

        If Len(Q02(N(1))) < 605 Then A(1) = A(0) + 140
        If Len(Q02(N(1))) < 480 Then A(1) = A(0) + 115
        If Len(Q02(N(1))) < 360 Then A(1) = A(0) + 90
        If Len(Q02(N(1))) < 240 Then A(1) = A(0) + 65
        If Len(Q02(N(1))) < 125 Then A(1) = A(0) + 35

        If Len(Q02(N(2))) < 605 Then A(2) = A(1) + 140
        If Len(Q02(N(2))) < 480 Then A(2) = A(1) + 115
        If Len(Q02(N(2))) < 360 Then A(2) = A(1) + 90
        If Len(Q02(N(2))) < 240 Then A(2) = A(1) + 65
        If Len(Q02(N(2))) < 120 Then A(2) = A(1) + 35

        If Len(Q02(N(3))) < 605 Then A(3) = A(2) + 140
        If Len(Q02(N(3))) < 480 Then A(3) = A(2) + 115
        If Len(Q02(N(3))) < 360 Then A(3) = A(2) + 90
        If Len(Q02(N(3))) < 240 Then A(3) = A(2) + 65
        If Len(Q02(N(3))) < 120 Then A(3) = A(2) + 35

        If Len(Q02(N(4))) < 605 Then A(4) = A(3) + 140
        If Len(Q02(N(4))) < 480 Then A(4) = A(3) + 115
        If Len(Q02(N(4))) < 360 Then A(4) = A(3) + 90
        If Len(Q02(N(4))) < 240 Then A(4) = A(3) + 65
        If Len(Q02(N(4))) < 120 Then A(4) = A(3) + 35

        If Len(Q02(N(5))) < 605 Then A(8) = A(4) + 140
        If Len(Q02(N(5))) < 480 Then A(8) = A(4) + 115
        If Len(Q02(N(5))) < 360 Then A(8) = A(4) + 90
        If Len(Q02(N(5))) < 240 Then A(8) = A(4) + 65
        If Len(Q02(N(5))) < 120 Then A(8) = A(4) + 35


        A(5) = A(8) + 50
        A(6) = A(8) + 50
        A(7) = A(5) + 100
        Me.Size = New Size(1050, A(7))
        lbl10.Location = New Point(20, A(0))
        lbl11.Location = New Point(20, A(1))
        lbl12.Location = New Point(20, A(2))
        lbl13.Location = New Point(20, A(3))
        lbl14.Location = New Point(20, A(4))
        lbl15.Location = New Point(20, A(8))
        cmdID.Location = New Point(75, A(5))
        cmdBack.Location = New Point(650, A(6))
    End Sub


    Private Sub cmdID_Click(sender As Object, e As EventArgs) Handles cmdID.Click

        If P = Val(Q02(N(7))(1)) Then 'если правильный ответ соответствует выбранному то:

            N(7) += 8  'Номер строки с кодом определения


            If Q02.Length <= N(7) Then  'Если количество строк в файле меньше или равно N(7) 
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
            If Val(Q02(N(7))(1)) = 1 Then lbl10.BackColor = Color.LightGreen
            If Val(Q02(N(7))(1)) = 2 Then lbl11.BackColor = Color.LightGreen
            If Val(Q02(N(7))(1)) = 3 Then lbl12.BackColor = Color.LightGreen
            If Val(Q02(N(7))(1)) = 4 Then lbl13.BackColor = Color.LightGreen
            If Val(Q02(N(7))(1)) = 5 Then lbl14.BackColor = Color.LightGreen
            If Val(Q02(N(7))(1)) = 6 Then lbl15.BackColor = Color.LightGreen

        End If


    End Sub




    Private Sub lbl10_Click(sender As Object, e As EventArgs) Handles lbl10.Click
        P = 1
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.FromArgb(240, 240, 240)
        lbl10.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl11_Click(sender As Object, e As EventArgs) Handles lbl11.Click
        P = 2
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl12_Click(sender As Object, e As EventArgs) Handles lbl12.Click
        P = 3
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl13_Click(sender As Object, e As EventArgs) Handles lbl13.Click
        P = 4
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl14_Click(sender As Object, e As EventArgs) Handles lbl14.Click
        P = 5
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl15_Click(sender As Object, e As EventArgs) Handles lbl15.Click
        P = 6
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.LightBlue
    End Sub
    Private Sub frm1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm0.Show()
    End Sub
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Close()
        frm0.Show()
    End Sub

    Private Sub lbl20_Click(sender As Object, e As EventArgs) Handles lbl20.Click
        P1 = 1
        lbl20.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl21_Click(sender As Object, e As EventArgs) Handles lbl21.Click
        P2 = 2
        lbl21.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl22_Click(sender As Object, e As EventArgs) Handles lbl22.Click
        P3 = 3
        lbl22.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl23_Click(sender As Object, e As EventArgs) Handles lbl23.Click
        P4 = 4
        lbl23.BackColor = Color.LightBlue
    End Sub

    Private Sub lbl24_Click(sender As Object, e As EventArgs) Handles lbl24.Click
        P = 5
        lbl24.BackColor = Color.LightBlue
    End Sub
    Dim P1, P2, P3, P4



    Private Sub cmdID1_Click(sender As Object, e As EventArgs) Handles cmdID1.Click


        If P1 = 1 And P2 = 2 And P3 = 0 And P4 = 4 Then 'если правильный ответ соответствует выбранному то:
            N(7) += 8  'Номер строки с кодом определения

            Rt()
            CLS()
            Schit()
            Loc()
            lblText1.Visible = False
            lbltext.Visible = True
            lbl20.Visible = False
            lbl21.Visible = False
            lbl22.Visible = False
            lbl23.Visible = False
            lbl24.Visible = False
            cmdID1.Visible = False
            cmdID.Visible = True
            lblText1.Text = ""
            lbl20.Text = ""
            lbl21.Text = ""
            lbl22.Text = ""
            lbl23.Text = ""
            lbl24.Text = ""
            Return
        Else
            If Val(Q02(N(7))(2)) = 1 Then lbl20.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 2 Then lbl21.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 3 Then lbl22.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 4 Then lbl23.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 5 Then lbl24.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 1 Then lbl20.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 2 Then lbl21.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 3 Then lbl22.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 4 Then lbl23.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 5 Then lbl24.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 1 Then lbl20.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 2 Then lbl21.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 3 Then lbl22.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 4 Then lbl23.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 5 Then lbl24.BackColor = Color.LightGreen
        End If

        If Val(Q02(N(7))(2)) = 5 And Val(Q02(N(7))(3)) = 6 And P3 = 0 Then 'если правильный ответ соответствует выбранному то:
            N(7) += 8  'Номер строки с кодом определения

            Rt()
            CLS()
            Schit()
            Loc()
            lblText1.Visible = False
            lbltext.Visible = True
            lbl20.Visible = False
            lbl21.Visible = False
            lbl22.Visible = False
            lbl23.Visible = False
            lbl24.Visible = False
            cmdID1.Visible = False
            cmdID.Visible = True
            lblText1.Text = ""
            lbl20.Text = ""
            lbl21.Text = ""
            lbl22.Text = ""
            lbl23.Text = ""
            lbl24.Text = ""
            Return
        Else
            If Val(Q02(N(7))(2)) = 5 Then lbl20.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 6 Then lbl21.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 3 Then lbl22.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 4 Then lbl23.BackColor = Color.LightGreen
            If Val(Q02(N(7))(2)) = 5 Then lbl24.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 5 Then lbl20.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 6 Then lbl21.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 3 Then lbl22.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 4 Then lbl23.BackColor = Color.LightGreen
            If Val(Q02(N(7))(3)) = 5 Then lbl24.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 5 Then lbl20.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 6 Then lbl21.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 3 Then lbl22.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 4 Then lbl23.BackColor = Color.LightGreen
            If Val(Q02(N(7))(4)) = 5 Then lbl24.BackColor = Color.LightGreen
        End If

    End Sub

    Private Sub frm2_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbl10.BackColor = Color.FromArgb(240, 240, 240)
        lbl11.BackColor = Color.FromArgb(240, 240, 240)
        lbl12.BackColor = Color.FromArgb(240, 240, 240)
        lbl13.BackColor = Color.FromArgb(240, 240, 240)
        lbl14.BackColor = Color.FromArgb(240, 240, 240)
        lbl15.BackColor = Color.FromArgb(240, 240, 240)
        lbl20.BackColor = Color.FromArgb(240, 240, 240)
        lbl21.BackColor = Color.FromArgb(240, 240, 240)
        lbl22.BackColor = Color.FromArgb(240, 240, 240)
        lbl23.BackColor = Color.FromArgb(240, 240, 240)
        lbl24.BackColor = Color.FromArgb(240, 240, 240)
        P1 = 0
        P2 = 0
        P3 = 0
        P4 = 0
        P = 0

    End Sub
    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        'Me.SaveFileDialog1.ShowDialog()
        'Dim Save As New SaveFileDialog

        ' If Save.ShowDialog = Windows.Forms.DialogResult.OK Then

        'End If
        If IO.File.Exists(Application.StartupPath & "\Save1.dll") Then
        Else
            IO.File.Create(Application.StartupPath & "\Save1.dll").Close()

        End If
        FileOpen(1, Application.StartupPath & "\Save1.dll", OpenMode.Output)
        Print(1, " ")
        FileClose(1)
        'IO.File.AppendText(Application.StartupPath & "\Save.dll").Close()
        'Dim myarray As String = N()
        ' Dim FileName As String = Application.StartupPath & "\Save.dll"

        'IO.File.WriteAllLines(FileName, myarray)

        '  Dim Split() = From str In File.ReadAllText(filePath).Split("|"c)
        '  Select Double.Parse(str)
        '  Dim numbers As Long() = Split.ToArray()
        'Dim str As String = InputBox("Введите ваш табельный номер", "Авторизация")

        Dim outFile As IO.StreamWriter
        'Dim intC As Integer = 0

        outFile = IO.File.AppendText("Save1.dll")
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
        If IO.File.Exists("Save1.dll") Then
            inFile = IO.File.OpenText("Save1.dll")
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