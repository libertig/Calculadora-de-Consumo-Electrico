<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_kw = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_kw = New System.Windows.Forms.TextBox()
        Me.lbl_importe_total = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_kw
        '
        Me.lbl_kw.AutoSize = True
        Me.lbl_kw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kw.Location = New System.Drawing.Point(33, 68)
        Me.lbl_kw.Name = "lbl_kw"
        Me.lbl_kw.Size = New System.Drawing.Size(206, 16)
        Me.lbl_kw.TabIndex = 0
        Me.lbl_kw.Text = "Ingrese el total de KWs a calcular"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(123, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(260, 25)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Calculadora de Consumo "
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(150, 111)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(89, 16)
        Me.lbl_total.TabIndex = 2
        Me.lbl_total.Text = "Total a pagar"
        '
        'txt_kw
        '
        Me.txt_kw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kw.Location = New System.Drawing.Point(245, 65)
        Me.txt_kw.Name = "txt_kw"
        Me.txt_kw.Size = New System.Drawing.Size(127, 22)
        Me.txt_kw.TabIndex = 3
        '
        'lbl_importe_total
        '
        Me.lbl_importe_total.AutoSize = True
        Me.lbl_importe_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importe_total.Location = New System.Drawing.Point(246, 111)
        Me.lbl_importe_total.Name = "lbl_importe_total"
        Me.lbl_importe_total.Size = New System.Drawing.Size(87, 16)
        Me.lbl_importe_total.TabIndex = 4
        Me.lbl_importe_total.Text = "Importe Total"
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_calcular.Location = New System.Drawing.Point(320, 150)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(84, 38)
        Me.btn_calcular.TabIndex = 5
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 200)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.lbl_importe_total)
        Me.Controls.Add(Me.txt_kw)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_kw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_kw As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_kw As TextBox
    Friend WithEvents lbl_importe_total As Label
    Friend WithEvents btn_calcular As Button
End Class
