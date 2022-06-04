<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNombre = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.OpenFoto = New System.Windows.Forms.OpenFileDialog()
        Me.gridDatos = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.txtCodEmpresa = New System.Windows.Forms.TextBox()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(153, 210)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 23)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(153, 170)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(179, 23)
        Me.txtApellido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cod Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cod Empresa"
        Me.Label4.UseMnemonic = False
        '
        'btnNombre
        '
        Me.btnNombre.Location = New System.Drawing.Point(86, 368)
        Me.btnNombre.Name = "btnNombre"
        Me.btnNombre.Size = New System.Drawing.Size(75, 23)
        Me.btnNombre.TabIndex = 9
        Me.btnNombre.Text = "Nuevo"
        Me.btnNombre.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(367, 368)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'gridDatos
        '
        Me.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDatos.Location = New System.Drawing.Point(457, 77)
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RowTemplate.Height = 25
        Me.gridDatos.Size = New System.Drawing.Size(540, 262)
        Me.gridDatos.TabIndex = 12
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(153, 83)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(179, 23)
        Me.txtId.TabIndex = 2
        '
        'txtCodEmpresa
        '
        Me.txtCodEmpresa.Location = New System.Drawing.Point(153, 121)
        Me.txtCodEmpresa.Name = "txtCodEmpresa"
        Me.txtCodEmpresa.Size = New System.Drawing.Size(179, 23)
        Me.txtCodEmpresa.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 450)
        Me.Controls.Add(Me.txtCodEmpresa)
        Me.Controls.Add(Me.gridDatos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.btnNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNombre As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents OpenFoto As OpenFileDialog
    Friend WithEvents gridDatos As DataGridView
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents txtCodEmpresa As TextBox
End Class
