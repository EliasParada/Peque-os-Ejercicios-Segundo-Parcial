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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTextBox = New System.Windows.Forms.Button()
        Me.btnComboBox = New System.Windows.Forms.Button()
        Me.btnNumeric = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(93, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Controles Visual basic"
        '
        'btnTextBox
        '
        Me.btnTextBox.Location = New System.Drawing.Point(64, 86)
        Me.btnTextBox.Name = "btnTextBox"
        Me.btnTextBox.Size = New System.Drawing.Size(75, 23)
        Me.btnTextBox.TabIndex = 1
        Me.btnTextBox.Text = "TextBox"
        Me.btnTextBox.UseVisualStyleBackColor = True
        '
        'btnComboBox
        '
        Me.btnComboBox.Location = New System.Drawing.Point(224, 86)
        Me.btnComboBox.Name = "btnComboBox"
        Me.btnComboBox.Size = New System.Drawing.Size(75, 23)
        Me.btnComboBox.TabIndex = 2
        Me.btnComboBox.Text = "ComboBox"
        Me.btnComboBox.UseVisualStyleBackColor = True
        '
        'btnNumeric
        '
        Me.btnNumeric.Location = New System.Drawing.Point(381, 86)
        Me.btnNumeric.Name = "btnNumeric"
        Me.btnNumeric.Size = New System.Drawing.Size(75, 23)
        Me.btnNumeric.TabIndex = 3
        Me.btnNumeric.Text = "NumericUpDown"
        Me.btnNumeric.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(69, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Validaciones Visual basic"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(44, 209)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Por Control"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(224, 209)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Por Evento"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(381, 209)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Por Propiedad"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(183, 247)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(158, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Condiciones y Excepciones"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 282)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNumeric)
        Me.Controls.Add(Me.btnComboBox)
        Me.Controls.Add(Me.btnTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnTextBox As Button
    Friend WithEvents btnComboBox As Button
    Friend WithEvents btnNumeric As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
