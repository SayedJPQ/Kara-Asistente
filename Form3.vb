Imports System.Speech
Imports SpeechLib
Imports System.Speech.Recognition
Imports System.Runtime.InteropServices
Imports System.Speech.Recognition.SrgsGrammar
Imports System.Threading
Imports System.Globalization
Public Class Form3
    Dim speech As SpVoice = New SpVoice()
    Dim WithEvents Rec As New Recognition.SpeechRecognitionEngine(New System.Globalization.CultureInfo("es-MX"))
    Dim synth As New Synthesis.SpeechSynthesizer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-MX")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-MX")
            Dim Gramatica As New GrammarBuilder()
            Gramatica.Culture = Rec.RecognizerInfo.Culture()
            Gramatica.Append(New Choices(System.IO.File.ReadAllLines("C:\Users\PC0\Desktop\Kara\ComandosVoz.txt")))
            Rec.LoadGrammar(New Recognition.Grammar(Gramatica))
            Rec.SetInputToDefaultAudioDevice()
            Rec.RecognizeAsync()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub Reco_Recognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles Rec.SpeechRecognized
        speech.Rate = 0
        speech.Volume = 80
        Select Case e.Result.Text
            Case "Hola"
                speech.Speak("Hola", SpeechVoiceSpeakFlags.SVSFlagsAsync)
            Case "Adios"
                speech.Speak("Adios", SpeechVoiceSpeakFlags.SVSFlagsAsync)
            Case Else
                speech.Rate = 0
                speech.Volume = 80
                speech.Speak("No le entendi señor", SpeechVoiceSpeakFlags.SVSFlagsAsync)
        End Select
    End Sub
    Private Sub Reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs)
        Do
            Rec.RecognizeAsync()
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rec.Dispose()
        synth.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class