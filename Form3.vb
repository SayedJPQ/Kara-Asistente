Imports System.Speech
Imports SpeechLib
Imports System.Speech.Recognition
Public Class Form3
    Dim speech As SpVoice = New SpVoice()
    Dim WithEvents Rec As New Recognition.SpeechRecognitionEngine
    Dim synth As New Synthesis.SpeechSynthesizer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Dim Prueba As New System.Globalization.CultureInfo("es-MX")
        Dim Gramatica As New Recognition.SrgsGrammar.SrgsDocument
        Dim Regla As New Recognition.SrgsGrammar.SrgsRule("Hola")
        Dim Lista As New Recognition.SrgsGrammar.SrgsOneOf("Hola", "Como estas?")
        Regla.Add(Lista)
        Gramatica.Rules.Add(Regla)
        Gramatica.Root = Regla
        Rec.SetInputToDefaultAudioDevice()
        Rec.LoadGrammar(New Recognition.Grammar(Gramatica))
        Rec.RecognizeAsync()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub Reco_Recognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles Rec.SpeechRecognized
        Select Case e.Result.Text
            Case "Hola"
                speech.Speak("Hola", SpeechVoiceSpeakFlags.SVSFlagsAsync)
            Case Else
                speech.Rate = 0
                speech.Volume = 80
                speech.Speak("No le entendi señor", SpeechVoiceSpeakFlags.SVSFlagsAsync)
        End Select
    End Sub
    Private Sub Reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs)
        Rec.RecognizeAsync()
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