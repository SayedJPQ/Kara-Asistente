Imports SpeechLib
Public Class Form2
    Dim speech As SpVoice = New SpVoice()
    Dim speechRate As Integer = 0
    Dim volume As Integer = 100
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "sayed" And TextBox2.Text = "sayed123" And CheckBox1.Checked = True Then
            speech.Rate = 0.5
            speech.Volume = 100
            speech.Speak("Bienvenido señor, mi nombre es kará, y sere su asistente personal, en este programa puedes. Interactuar con el bot, abrir programas, paginas webs, transcribir de texto a voz, y traducir palabras del español al ingles, por favor coloque los comandos tal y como estan para evitar errores", SpeechVoiceSpeakFlags.SVSFlagsAsync)
            Process.Start("UserAccountControlSettings.exe")
            Process.Start("C:\Users\PC0\Desktop\Kara\Tutorial\Tutorial.exe")
            Me.Hide()
            Form4.Show()
        ElseIf TextBox1.Text = "sayed" And TextBox2.Text = "sayed123" And CheckBox1.Checked = False Then
            speech.Rate = 0
            speech.Volume = 100
            speech.Speak("Bienvenido señor", SpeechVoiceSpeakFlags.SVSFlagsAsync)
            Me.Hide()
            Form1.Show()
        Else
            speech.Speak("Accesso denegado", SpeechVoiceSpeakFlags.SVSFlagsAsync)
            MsgBox("No estas autorizado", 48, "Accesso restringido")
            End
        End If
    End Sub
End Class