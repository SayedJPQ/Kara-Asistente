Imports System.Speech
Imports SpeechLib
Imports System.Speech.Recognition
Imports System.Runtime.InteropServices
Imports System.Speech.Recognition.SrgsGrammar
Imports System.Threading
Imports System.Globalization
Imports System.Speech.Synthesis

Public Class Form3
    Dim WithEvents Rec As New Recognition.SpeechRecognitionEngine(New System.Globalization.CultureInfo("es-MX"))
    Dim synth As New Synthesis.SpeechSynthesizer
    Private Sub Recognizer_SpeechDetected(ByVal sender As Object, ByVal e As SpeechDetectedEventArgs)
        Label1.ForeColor = Color.Green : Label1.BackColor = Color.Transparent : Label1.Text = "El reconocimiento de voz te escucho con exito"
    End Sub
    Private Sub Recognizer_SpeechRecognitionRejected(ByVal sender As Object, ByVal e As SpeechRecognitionRejectedEventArgs)
        Label1.ForeColor = Color.Red : Label1.BackColor = Color.Transparent : Label1.Text = ("Lo lamento pero " & e.Result.Text & " no es reconocido")

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Rec.SpeechDetected, AddressOf Recognizer_SpeechDetected
        AddHandler Rec.SpeechRecognitionRejected, AddressOf Recognizer_SpeechRecognitionRejected
        'AddHandler Rec.SpeakCompleted, AddressOf Termina_Hablar
        AddHandler Rec.SpeechRecognized, AddressOf Reconoce_Voz



        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-MX")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-MX")
        Dim Gramatica As New GrammarBuilder()
        Gramatica.Culture = Rec.RecognizerInfo.Culture()
        Gramatica.Append(New Choices(System.IO.File.ReadAllLines("C:\Users\PC0\Desktop\Kara\ComandosVoz.txt")))
        Rec.LoadGrammar(New Recognition.Grammar(Gramatica))
        Rec.SetInputToDefaultAudioDevice()
        Rec.RecognizeAsync()
        Label1.ForeColor = Color.Blue : Label1.BackColor = Color.Transparent : Label1.Text = "Te escucho"
    End Sub

    Private Sub Reconoce_Voz(sender As Object, e As SpeechRecognizedEventArgs)
        Label1.Text = e.Result.Text

    End Sub



    Private Sub Reco_Recognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles Rec.SpeechRecognized
        Dim Kara = CreateObject("sapi.spvoice")
        Kara.Rate = 0
        Kara.Volume = 100
        Rec.RecognizeAsyncCancel()

        Select Case e.Result.Text.ToUpper
            Case "HOLA"
                Kara.Speak("Hola")
            Case "ADIOS"
                Kara.Speak("Adios")
            Case "COMO ESTAS"
                Kara.Speak("Bien y usted")
            Case "SALUDA A TIO MICHAEL"
                Kara.Speak("Hola tio Michael, mucho gusto soy Kará, el asistente personal de Sallet, estoy apenas comenzando, pero estoy tratando de mejorar, le mando un gran saludo")
            Case "SALUDA A GABRIEL"
                Kara.Speak("Hola Gabriel, mucho gusto soy Kará, el asistente personal de Sallet, te mando un saludo")
            Case "SALUDA A DILAN"
                Kara.Speak("Hola Dilan, mucho gusto soy Kará, el asistente personal de Sallet, te mando un saludo")
            Case "ABRIR GOOGLE"
                Kara.Speak("Abriendo google señor")
                System.Diagnostics.Process.Start("explorer.exe", "https://www.google.com")
            Case "FINALIZAR"
                Kara.Speak("Hasta luego Espero vuelva pronto")
                End
            Case "IR A COMANDOS DE TEXTO"
                Me.Hide()
                Form1.Show()
            Case "AGREGAR COMANDOS"
                Kara.Speak("Abriendo para agregar comandos señor")
                Me.Hide()
                Form4.Show()
            Case Else
                Kara.Speak("No le entendi señor")
        End Select
        'Dim PRUEBA As String
        'Dim PTEXTO As String() = PRUEBA.Split(",")

        'Select Case PTEXTO(0)
        '    Case "HOLA"
        '        Kara.sPEAK(PTEXTO(1))
        'End Select



    End Sub
    Private Sub Reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles Rec.RecognizeCompleted

        Rec.RecognizeAsync()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Label1.Text = ""
        Label1.ForeColor = Color.Blue : Label1.BackColor = Color.Transparent : Label1.Text = "Te escucho"
        Try
            Rec.RecognizeAsync()
        Catch ex As Exception
            MsgBox("Hubo un error por favor vuelve a intentarlo")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MsgBox("Hasta luego", 0, "Espero vuelva pronto")
        End
    End Sub
End Class