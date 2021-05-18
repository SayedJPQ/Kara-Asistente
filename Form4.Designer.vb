<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim ComandoLabel As System.Windows.Forms.Label
        Dim RespuestaLabel As System.Windows.Forms.Label
        Dim AccionLabel As System.Windows.Forms.Label
        Me.ComandosDataSet = New Asistente.ComandosDataSet()
        Me.ComandosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComandosTableAdapter = New Asistente.ComandosDataSetTableAdapters.ComandosTableAdapter()
        Me.TableAdapterManager = New Asistente.ComandosDataSetTableAdapters.TableAdapterManager()
        Me.ComandosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ComandosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ComandoTextBox = New System.Windows.Forms.TextBox()
        Me.RespuestaTextBox = New System.Windows.Forms.TextBox()
        Me.AccionTextBox = New System.Windows.Forms.TextBox()
        Me.ComandosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        ComandoLabel = New System.Windows.Forms.Label()
        RespuestaLabel = New System.Windows.Forms.Label()
        AccionLabel = New System.Windows.Forms.Label()
        CType(Me.ComandosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComandosBindingNavigator.SuspendLayout()
        CType(Me.ComandosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComandosDataSet
        '
        Me.ComandosDataSet.DataSetName = "ComandosDataSet"
        Me.ComandosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComandosBindingSource
        '
        Me.ComandosBindingSource.DataMember = "Comandos"
        Me.ComandosBindingSource.DataSource = Me.ComandosDataSet
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
        'ComandosBindingNavigator
        '
        Me.ComandosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ComandosBindingNavigator.BindingSource = Me.ComandosBindingSource
        Me.ComandosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComandosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ComandosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComandosBindingNavigatorSaveItem})
        Me.ComandosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComandosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComandosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComandosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComandosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComandosBindingNavigator.Name = "ComandosBindingNavigator"
        Me.ComandosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComandosBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ComandosBindingNavigator.TabIndex = 0
        Me.ComandosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ComandosBindingNavigatorSaveItem
        '
        Me.ComandosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComandosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComandosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComandosBindingNavigatorSaveItem.Name = "ComandosBindingNavigatorSaveItem"
        Me.ComandosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ComandosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ComandoLabel
        '
        ComandoLabel.AutoSize = True
        ComandoLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComandoLabel.Location = New System.Drawing.Point(12, 59)
        ComandoLabel.Name = "ComandoLabel"
        ComandoLabel.Size = New System.Drawing.Size(88, 21)
        ComandoLabel.TabIndex = 1
        ComandoLabel.Text = "Comando:"
        '
        'ComandoTextBox
        '
        Me.ComandoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComandosBindingSource, "Comando", True))
        Me.ComandoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComandoTextBox.Location = New System.Drawing.Point(109, 51)
        Me.ComandoTextBox.Name = "ComandoTextBox"
        Me.ComandoTextBox.Size = New System.Drawing.Size(193, 29)
        Me.ComandoTextBox.TabIndex = 2
        '
        'RespuestaLabel
        '
        RespuestaLabel.AutoSize = True
        RespuestaLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RespuestaLabel.Location = New System.Drawing.Point(12, 101)
        RespuestaLabel.Name = "RespuestaLabel"
        RespuestaLabel.Size = New System.Drawing.Size(91, 21)
        RespuestaLabel.TabIndex = 3
        RespuestaLabel.Text = "Respuesta:"
        '
        'RespuestaTextBox
        '
        Me.RespuestaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComandosBindingSource, "Respuesta", True))
        Me.RespuestaTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespuestaTextBox.Location = New System.Drawing.Point(109, 98)
        Me.RespuestaTextBox.Name = "RespuestaTextBox"
        Me.RespuestaTextBox.Size = New System.Drawing.Size(193, 29)
        Me.RespuestaTextBox.TabIndex = 4
        '
        'AccionLabel
        '
        AccionLabel.AutoSize = True
        AccionLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccionLabel.Location = New System.Drawing.Point(12, 147)
        AccionLabel.Name = "AccionLabel"
        AccionLabel.Size = New System.Drawing.Size(68, 21)
        AccionLabel.TabIndex = 5
        AccionLabel.Text = "Accion:"
        '
        'AccionTextBox
        '
        Me.AccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComandosBindingSource, "Accion", True))
        Me.AccionTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccionTextBox.Location = New System.Drawing.Point(109, 139)
        Me.AccionTextBox.Name = "AccionTextBox"
        Me.AccionTextBox.Size = New System.Drawing.Size(193, 29)
        Me.AccionTextBox.TabIndex = 6
        '
        'ComandosDataGridView
        '
        Me.ComandosDataGridView.AutoGenerateColumns = False
        Me.ComandosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComandosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ComandosDataGridView.DataSource = Me.ComandosBindingSource
        Me.ComandosDataGridView.Location = New System.Drawing.Point(404, 28)
        Me.ComandosDataGridView.Name = "ComandosDataGridView"
        Me.ComandosDataGridView.Size = New System.Drawing.Size(343, 220)
        Me.ComandosDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Comando"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Comando"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Respuesta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Respuesta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Accion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Accion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(125, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(227, 330)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 36)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(329, 330)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 36)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(425, 330)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 36)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Agregar Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(581, 330)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 36)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Elminar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(684, 330)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(79, 36)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Guardar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 521)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComandosDataGridView)
        Me.Controls.Add(ComandoLabel)
        Me.Controls.Add(Me.ComandoTextBox)
        Me.Controls.Add(RespuestaLabel)
        Me.Controls.Add(Me.RespuestaTextBox)
        Me.Controls.Add(AccionLabel)
        Me.Controls.Add(Me.AccionTextBox)
        Me.Controls.Add(Me.ComandosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar comandos"
        CType(Me.ComandosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComandosBindingNavigator.ResumeLayout(False)
        Me.ComandosBindingNavigator.PerformLayout()
        CType(Me.ComandosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComandosDataSet As ComandosDataSet
    Friend WithEvents ComandosBindingSource As BindingSource
    Friend WithEvents ComandosTableAdapter As ComandosDataSetTableAdapters.ComandosTableAdapter
    Friend WithEvents TableAdapterManager As ComandosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComandosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ComandosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ComandoTextBox As TextBox
    Friend WithEvents RespuestaTextBox As TextBox
    Friend WithEvents AccionTextBox As TextBox
    Friend WithEvents ComandosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
