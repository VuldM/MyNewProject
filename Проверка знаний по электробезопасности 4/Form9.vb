Public Class frmX

    Private Sub frmX_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmTest.Close()
        frm0.Show()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(900, 560)
        Me.Text = "Результат проверки знаний"
        L01.Size = New Size(750, 60)
        L01.Location = New Point(5, 5)
        L01.AutoSize = False
        L01.Text = frmTest.A1(0)
        L02.Size = New Size(750, 50)
        L02.AutoSize = False
        L02.Location = New Point(5, 55)
        L02.Text = frmTest.A1(1)
        L03.Size = New Size(750, 50)
        L03.AutoSize = False
        L03.Location = New Point(5, 105)
        L03.Text = frmTest.A1(2)
        L04.Size = New Size(750, 50)
        L04.AutoSize = False
        L04.Location = New Point(5, 155)
        L04.Text = frmTest.A1(3)
        L05.Size = New Size(750, 50)
        L05.AutoSize = False
        L05.Location = New Point(5, 205)
        L05.Text = frmTest.A1(4)
        L06.Size = New Size(750, 50)
        L06.AutoSize = False
        L06.Location = New Point(5, 255)
        L06.Text = frmTest.A1(5)
        L07.Size = New Size(750, 50)
        L07.AutoSize = False
        L07.Location = New Point(5, 305)
        L07.Text = frmTest.A1(6)
        L08.Size = New Size(750, 50)
        L08.AutoSize = False
        L08.Location = New Point(5, 355)
        L08.Text = frmTest.A1(7)
        L09.Size = New Size(750, 50)
        L09.AutoSize = False
        L09.Location = New Point(5, 405)
        L09.Text = frmTest.A1(8)
        L10.Size = New Size(750, 50)
        L10.AutoSize = False
        L10.Location = New Point(5, 455)
        L10.Text = frmTest.A1(9)
        L01.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L02.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L03.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L04.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L05.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L06.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L07.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L08.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L09.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L10.Font = New Font("Times New Roman", 9.0!, FontStyle.Bold)
        L11.Size = New Size(100, 30)
        L11.Location = New Point(750, 10)
        L11.Text = frmTest.A2(0)
        If L11.Text = "Правильно" Then L11.ForeColor = Color.LightGreen
        If L11.Text = "Неправильно" Then L11.ForeColor = Color.OrangeRed
        L12.Size = New Size(100, 20)
        L12.Location = New Point(750, 60)
        L12.Text = frmTest.A2(1)
        If L12.Text = "Правильно" Then L12.ForeColor = Color.LightGreen
        If L12.Text = "Неправильно" Then L12.ForeColor = Color.OrangeRed
        L13.Size = New Size(100, 20)
        L13.Location = New Point(750, 110)
        L13.Text = frmTest.A2(2)
        If L13.Text = "Правильно" Then L13.ForeColor = Color.LightGreen
        If L13.Text = "Неправильно" Then L13.ForeColor = Color.OrangeRed
        L14.Size = New Size(100, 20)
        L14.Location = New Point(750, 160)
        L14.Text = frmTest.A2(3)
        If L14.Text = "Правильно" Then L14.ForeColor = Color.LightGreen
        If L14.Text = "Неправильно" Then L14.ForeColor = Color.OrangeRed
        L15.Size = New Size(750, 20)
        L15.Location = New Point(750, 210)
        L15.Text = frmTest.A2(4)
        If L15.Text = "Правильно" Then L15.ForeColor = Color.LightGreen
        If L15.Text = "Неправильно" Then L15.ForeColor = Color.OrangeRed
        L16.Size = New Size(100, 20)
        L16.Location = New Point(750, 260)
        L16.Text = frmTest.A2(5)
        If L16.Text = "Правильно" Then L16.ForeColor = Color.LightGreen
        If L16.Text = "Неправильно" Then L16.ForeColor = Color.OrangeRed
        L17.Size = New Size(100, 20)
        L17.Location = New Point(750, 310)
        L17.Text = frmTest.A2(6)
        If L17.Text = "Правильно" Then L17.ForeColor = Color.LightGreen
        If L17.Text = "Неправильно" Then L17.ForeColor = Color.OrangeRed
        L18.Size = New Size(100, 20)
        L18.Location = New Point(750, 360)
        L18.Text = frmTest.A2(7)
        If L18.Text = "Правильно" Then L18.ForeColor = Color.LightGreen
        If L18.Text = "Неправильно" Then L18.ForeColor = Color.OrangeRed
        L19.Size = New Size(100, 20)
        L19.Location = New Point(750, 410)
        L19.Text = frmTest.A2(8)
        If L19.Text = "Правильно" Then L19.ForeColor = Color.LightGreen
        If L19.Text = "Неправильно" Then L19.ForeColor = Color.OrangeRed
        L20.Size = New Size(100, 20)
        L20.Location = New Point(750, 455)
        L20.Text = frmTest.A2(9)
        If L20.Text = "Правильно" Then L20.ForeColor = Color.LightGreen
        If L20.Text = "Неправильно" Then L20.ForeColor = Color.OrangeRed
        L11.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L12.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L13.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L14.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L15.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L16.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L17.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L18.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L19.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)
        L20.Font = New Font("Times New Roman", 10.0!, FontStyle.Bold)

    End Sub

End Class