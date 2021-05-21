Imports SpeechLib
Public Class Form1
    Dim speech As SpVoice = New SpVoice()
    Dim speechRate As Integer = 0 ' Rango desde -10 hasta 10 
    Dim volume As Integer = 100 ' Rango desde 0 hasta 100.
    Declare Sub Sleep Lib "kernel32.dll" (ByVal Milliseconds As Integer)
    'Dim procesos As Process()
    Private Sub CodigoElse(texto As String, Traduce As Boolean)
        Try
            If Traduce = False Then
                speech.Voice = speech.GetVoices.Item(0)
                Select Case texto

'Interaccion con el bot
                    Case "hola"
                        Respuesta.Text = "Hola!"
                    Case "como estas?"
                        Respuesta.Text = "Bien y usted señor"
                    Case "ir a comandos de voz"
                        speech.Speak("Abriendo comandos de voz señor", SpeechVoiceSpeakFlags.SVSFlagsAsync)
                        Sleep(3000)
                        Me.Hide()
                        Sleep(3000)
                        Form3.Show()
                    Case "agregar comandos"
                        speech.Speak("Abriendo para agregar comandos señor", SpeechVoiceSpeakFlags.SVSFlagsAsync)
                        Me.Hide()
                        Form4.Show()
'Abrir programas
                    Case "python"
                        Respuesta.Text = "Python abierto señor"
                        Process.Start("python.exe")
'Abrir webs
                    Case "youtube"
                        Respuesta.Text = "Facebook abierto señor"
'Tutorial
                    Case "que puedo traducir"
                        Respuesta.Text = "Se presentara a continuacion la lista de palabras que puede traducir, por favor pongalas tal y como estan para evitar errores"
                        Process.Start("C:\Users\PC0\Desktop\Kara\Translate\Translate.exe")
'Cerrar programa
                    Case "cerrar programa"
                        MsgBox("Hasta luego")
                        End
                    Case Else
                        Respuesta.Text = "No le entendi señor"
                End Select
                speech.Rate = 0
                speech.Volume = 80
                speech.Speak(Respuesta.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
            Else
                speech.Voice = speech.GetVoices.Item(1)
                'Traducir
                Select Case texto
'Saludos y despedidas
                    Case "saludo"
                        Traducido.Text = "Greeting"
                    Case Else
                        speech.Voice = speech.GetVoices.Item(0)
                        Traducido.Text = "No le entendi señor"
                End Select
                speech.Rate = 0
                speech.Volume = 100
                speech.Speak(Traducido.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Token As ISpeechObjectToken In speech.GetVoices(String.Empty, String.Empty)
            ComboBox1.Items.Add(Token.GetDescription(49))
            ComboBox1.SelectedIndex = 0
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CodigoElse(TextBox1.Text, False)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CodigoElse(TextBox3.Text, True)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        speech.Rate = speechRate
        speech.Volume = volume
        speech.Speak(TextBox2.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Hasta luego", 0, "Espero vuelva pronto")
        End
    End Sub

    Private Sub TrackBarVolumen_Scroll(sender As Object, e As EventArgs) Handles TrackBarVolumen.Scroll
        volume = TrackBarVolumen.Value
    End Sub

    Private Sub TrackBarVelocidad_Scroll(sender As Object, e As EventArgs) Handles TrackBarVelocidad.Scroll
        speechRate = TrackBarVelocidad.Value
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        speech.Voice = speech.GetVoices(String.Empty, String.Empty).Item(ComboBox1.SelectedIndex)
    End Sub
End Class
