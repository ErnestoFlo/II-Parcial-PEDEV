﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGlibros = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdAlumno = New System.Windows.Forms.TextBox()
        Me.txtIdLibro = New System.Windows.Forms.TextBox()
        Me.txtIdPrestamo = New System.Windows.Forms.TextBox()
        Me.txtFechaRetorno = New System.Windows.Forms.TextBox()
        Me.txtIdRetorno = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.DGlibros)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(848, 369)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'DGlibros
        '
        Me.DGlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlibros.Location = New System.Drawing.Point(6, 31)
        Me.DGlibros.Name = "DGlibros"
        Me.DGlibros.Size = New System.Drawing.Size(825, 321)
        Me.DGlibros.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdAlumno)
        Me.GroupBox1.Controls.Add(Me.txtIdLibro)
        Me.GroupBox1.Controls.Add(Me.txtIdPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtFechaRetorno)
        Me.GroupBox1.Controls.Add(Me.txtIdRetorno)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(323, 225)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Libros Prestados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Retornos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Conferencias"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Multas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Visitas"
        '
        'txtIdAlumno
        '
        Me.txtIdAlumno.Location = New System.Drawing.Point(133, 68)
        Me.txtIdAlumno.Multiline = True
        Me.txtIdAlumno.Name = "txtIdAlumno"
        Me.txtIdAlumno.Size = New System.Drawing.Size(133, 27)
        Me.txtIdAlumno.TabIndex = 8
        '
        'txtIdLibro
        '
        Me.txtIdLibro.Location = New System.Drawing.Point(133, 101)
        Me.txtIdLibro.Multiline = True
        Me.txtIdLibro.Name = "txtIdLibro"
        Me.txtIdLibro.Size = New System.Drawing.Size(133, 27)
        Me.txtIdLibro.TabIndex = 7
        '
        'txtIdPrestamo
        '
        Me.txtIdPrestamo.Location = New System.Drawing.Point(133, 134)
        Me.txtIdPrestamo.Multiline = True
        Me.txtIdPrestamo.Name = "txtIdPrestamo"
        Me.txtIdPrestamo.Size = New System.Drawing.Size(133, 27)
        Me.txtIdPrestamo.TabIndex = 6
        '
        'txtFechaRetorno
        '
        Me.txtFechaRetorno.Location = New System.Drawing.Point(133, 167)
        Me.txtFechaRetorno.Multiline = True
        Me.txtFechaRetorno.Name = "txtFechaRetorno"
        Me.txtFechaRetorno.Size = New System.Drawing.Size(133, 27)
        Me.txtFechaRetorno.TabIndex = 1
        '
        'txtIdRetorno
        '
        Me.txtIdRetorno.Location = New System.Drawing.Point(133, 35)
        Me.txtIdRetorno.Multiline = True
        Me.txtIdRetorno.Name = "txtIdRetorno"
        Me.txtIdRetorno.Size = New System.Drawing.Size(133, 27)
        Me.txtIdRetorno.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_III_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(272, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 400)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGlibros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdAlumno As TextBox
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents txtIdPrestamo As TextBox
    Friend WithEvents txtFechaRetorno As TextBox
    Friend WithEvents txtIdRetorno As TextBox
    Friend WithEvents btnBuscar As Button
End Class
