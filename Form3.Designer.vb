<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ComandosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComandosDataSet = New Asistente.ComandosDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComandosTableAdapter = New Asistente.ComandosDataSetTableAdapters.ComandosTableAdapter()
        Me.TableAdapterManager = New Asistente.ComandosDataSetTableAdapters.TableAdapterManager()
        Me.ComandosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Categoría = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ComandosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComandosBindingSource
        '
        Me.ComandosBindingSource.DataMember = "Comandos"
        Me.ComandosBindingSource.DataSource = Me.ComandosDataSet
        '
        'ComandosDataSet
        '
        Me.ComandosDataSet.DataSetName = "ComandosDataSet"
        Me.ComandosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(745, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(237, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(356, 387)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(467, 387)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 35)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Agregar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(576, 387)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 35)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Eliminar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(688, 387)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 35)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Guardar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComandosTableAdapter
        '
        Me.ComandosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComandosTableAdapter = Me.ComandosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Asistente.ComandosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComandosDataGridView
        '
        Me.ComandosDataGridView.AutoGenerateColumns = False
        Me.ComandosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComandosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Categoría, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ComandosDataGridView.DataSource = Me.ComandosBindingSource
        Me.ComandosDataGridView.Location = New System.Drawing.Point(190, 123)
        Me.ComandosDataGridView.Name = "ComandosDataGridView"
        Me.ComandosDataGridView.Size = New System.Drawing.Size(443, 220)
        Me.ComandosDataGridView.TabIndex = 9
        '
        'Categoría
        '
        Me.Categoría.DataPropertyName = "Categoría"
        Me.Categoría.HeaderText = "Categoría"
        Me.Categoría.Name = "Categoría"
        Me.Categoría.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Categoría.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Comando"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Comando"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Respuesta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Respuesta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Accion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Accion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 468)
        Me.Controls.Add(Me.ComandosDataGridView)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente de voz"
        CType(Me.ComandosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ComandosDataGridView As DataGridView
    Friend WithEvents ComandosDataSet As ComandosDataSet
    Friend WithEvents ComandosBindingSource As BindingSource
    Friend WithEvents ComandosTableAdapter As ComandosDataSetTableAdapters.ComandosTableAdapter
    Friend WithEvents TableAdapterManager As ComandosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Categoría As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
