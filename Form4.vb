Public Class Form4
    Private Sub ComandosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComandosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComandosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ComandosDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComandosDataSet.Comandos' table. You can move, or remove it, as needed.
        Me.ComandosTableAdapter.Fill(Me.ComandosDataSet.Comandos)

    End Sub
End Class