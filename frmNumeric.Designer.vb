<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumeric
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupNumero = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.nupNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ComboBox"
        '
        'nupNumero
        '
        Me.nupNumero.Location = New System.Drawing.Point(74, 100)
        Me.nupNumero.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nupNumero.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nupNumero.Name = "nupNumero"
        Me.nupNumero.Size = New System.Drawing.Size(120, 20)
        Me.nupNumero.TabIndex = 3
        Me.nupNumero.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aumentar limite maximo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 49)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Disminuir limite maximo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(172, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 49)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Disminuir limite minimo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 130)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 49)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Aumentar limite minimo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 191)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nupNumero)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNumeric"
        Me.Text = "frmNumeric"
        CType(Me.nupNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nupNumero As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
