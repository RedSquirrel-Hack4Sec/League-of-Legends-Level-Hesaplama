Public Class Form1

    Dim suanki, gereken, sure, sonuc, oyunsayisi, gelenxp As Integer
    Dim kontrol, acikmiydi As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb_suanki.Text += gelenxp
        suanki = tb_suanki.Text
        gereken = tb_gereken.Text
        sonuc = gereken - suanki
        lbl_sonuc.Text = sonuc
        gelenxp = tb_gelenxp.Text
        oyunsayisi = sonuc / gelenxp
        sure = tb_sure.Text
        sure = oyunsayisi * sure
        lbl_not.Text = "Bir sonraki lw için gereken oyun sayısı " & oyunsayisi & " Toplam Süre: " & sure & " dk"
        sure = tb_sure.Text
        My.Settings.suanki = suanki
        My.Settings.gereken = gereken
        My.Settings.sure = sure
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_gereken.Text = My.Settings.gereken
        tb_suanki.Text = My.Settings.suanki
        tb_sure.Text = My.Settings.sure
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        suanki = tb_suanki.Text
        gereken = tb_gereken.Text
        sonuc = gereken - suanki
        lbl_sonuc.Text = sonuc
        gelenxp = tb_gelenxp.Text
        oyunsayisi = sonuc / gelenxp
        sure = tb_sure.Text
        sure = oyunsayisi * sure
        lbl_not.Text = "Bir sonraki lw için gereken ortalama oyun sayısı " & oyunsayisi & " Ortalama Süre: " & sure & " dk"
        sure = tb_sure.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.suanki = tb_suanki.Text
        My.Settings.gereken = tb_gereken.Text
        My.Settings.sure = tb_sure.Text
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub oyuntara_Tick(sender As Object, e As EventArgs) Handles oyuntara.Tick
        Dim processList As Process() = Process.GetProcessesByName("League of Legends")
        If processList.Length = 1 Then
            kontrol = True
            acikmiydi = True
            Me.Hide()
        Else
            Me.Show()
            kontrol = False
        End If

        If kontrol = False And acikmiydi = True Then
            oyuntara.Stop()
            acikmiydi = False
            tb_gelenxp.Text = InputBox("Lütfen Ortalama Gelen xp'yi irin", "PointeR - Lol lw", "")
            oyuntara.Start()
        End If
    End Sub

    Private Sub tb_sure_DoubleClick(sender As Object, e As EventArgs) Handles tb_sure.DoubleClick
        If tb_sure.ReadOnly = False Then
            tb_sure.ReadOnly = True
            lbl_3.ForeColor = Color.Orange
        Else
            tb_sure.ReadOnly = False
            lbl_3.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub tb_gereken_DoubleClick(sender As Object, e As EventArgs) Handles tb_gereken.DoubleClick
        If Button2.Visible = False Then
            Button2.Visible = True
            tb_gereken.ReadOnly = False
            tb_suanki.ReadOnly = False
            tb_sure.ReadOnly = False
            lbl_1.ForeColor = Color.LimeGreen
            lbl_2.ForeColor = Color.LimeGreen
            lbl_3.ForeColor = Color.LimeGreen
            lbl_4.ForeColor = Color.LimeGreen
        Else
            Button2.Visible = False
            tb_gereken.ReadOnly = True
            tb_suanki.ReadOnly = True
            tb_sure.ReadOnly = True
            lbl_1.ForeColor = Color.Red
            lbl_2.ForeColor = Color.Red
            lbl_3.ForeColor = Color.Orange
            lbl_4.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub tb_suanki_DoubleClick(sender As Object, e As EventArgs) Handles tb_suanki.DoubleClick
        If Button2.Visible = False Then
            Button2.Visible = True
            tb_gereken.ReadOnly = False
            tb_suanki.ReadOnly = False
            tb_sure.ReadOnly = False
            tb_gereken.Select()
            lbl_1.ForeColor = Color.LimeGreen
            lbl_2.ForeColor = Color.LimeGreen
            lbl_3.ForeColor = Color.LimeGreen
            lbl_4.ForeColor = Color.LimeGreen
        Else
            Button2.Visible = False
            tb_gereken.ReadOnly = True
            tb_suanki.ReadOnly = True
            tb_sure.ReadOnly = True
            lbl_1.ForeColor = Color.Red
            lbl_2.ForeColor = Color.Red
            lbl_3.ForeColor = Color.Orange
            lbl_4.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub tb_gelenxp_DoubleClick(sender As Object, e As EventArgs) Handles tb_gelenxp.DoubleClick

    End Sub

End Class
