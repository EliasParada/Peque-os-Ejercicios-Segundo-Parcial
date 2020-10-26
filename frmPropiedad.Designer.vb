<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropiedad
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtVisible = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(142, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 39)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Evento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enable"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(293, 66)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Habilitar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Deshabilitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Visible"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(190, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Ocultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(101, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Mostrar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtVisible
        '
        Me.txtVisible.Location = New System.Drawing.Point(293, 135)
        Me.txtVisible.Name = "txtVisible"
        Me.txtVisible.Size = New System.Drawing.Size(100, 20)
        Me.txtVisible.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Value"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(101, 217)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Cambiar valor a 5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(273, 217)
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(120, 20)
        Me.nudValue.TabIndex = 19
        '
        'frmPropiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 291)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVisible)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmPropiedad"
        Me.Text = "frmPropiedad"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtVisible As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents nudValue As NumericUpDown
End Class
