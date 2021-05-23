Public Class Form4
    Private Sub ComandosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ComandosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComandosDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComandosDataSet.Comandos' table. You can move, or remove it, as needed.
        Me.ComandosTableAdapter.Fill(Me.ComandosDataSet.Comandos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComandosBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComandosBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComandosBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComandosBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComandosBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            ComandosBindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            ComandosBindingSource.EndEdit()
            ComandosTableAdapter.Update(ComandosDataSet)
        Catch ex As Exception
            MsgBox("Error en la base de datos: " & ex.Message)
        End Try
    End Sub
End Class