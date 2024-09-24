Public Class Form1
    Dim x As DialogResult
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Format(Now, "dd/mm/yyyy")
        Label2.Text = Format(Now, "hh:mm:ss")
        TM.Text = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Format(Now, "hh:mm:ss")
    End Sub


    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        Dim PKg As Double
        Dim tailM As Double
        Dim Pg As Double
        Dim tailCm As Double
        Dim indiceDeMAss As Double
        If Double.TryParse(PoidKG.Text, PKg) Or Double.TryParse(PoidG.Text, Pg) Or Double.TryParse(TM.Text, tailM) Or Double.TryParse(TCM.Text, tailCm) Then
            Pg *= 10 ^ -2
            tailCm *= 10 ^ -2
            indiceDeMAss = (PKg + Pg) / ((tailM + tailCm) ^ 2)
            IDM.Text = indiceDeMAss
            If indiceDeMAss <= 18.5 Then
                OBS.Text = "Maigre"
            ElseIf indiceDeMAss > 25 Then
                OBS.Text = "Obese"
            Else
                OBS.Text = "Normale"
            End If
        Else
            x = MessageBox.Show("veuillez utiliser uniquement des chiffres", "Indice De Masse Corporelle : Action Fermer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If x = MsgBoxResult.Yes Then
                Beep()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        x = MessageBox.Show("Voulez Vous Fermer ?", "Indice De Masse Corporelle : Action Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            Beep()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = MessageBox.Show("Voulez Vous Effaçer ?", "Indice De Masse Corporelle : Action Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            Beep()
            PoidKG.Text = Nothing
            PoidG.Text = Nothing
            TM.Text = Nothing
            TCM.Text = Nothing
        End If
    End Sub
End Class