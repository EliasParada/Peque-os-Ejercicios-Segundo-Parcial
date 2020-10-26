<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvento
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTextChange = New System.Windows.Forms.TextBox()
        Me.lblTextChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Presiona el botón"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Posicione el cursor sobre el botón"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTextChange
        '
        Me.txtTextChange.Location = New System.Drawing.Point(162, 184)
        Me.txtTextChange.Name = "txtTextChange"
        Me.txtTextChange.Size = New System.Drawing.Size(195, 20)
        Me.txtTextChange.TabIndex = 2
        '
        'lblTextChange
        '
        Me.lblTextChange.AutoSize = True
        Me.lblTextChange.Location = New System.Drawing.Point(159, 228)
        Me.lblTextChange.Name = "lblTextChange"
        Me.lblTextChange.Size = New System.Drawing.Size(43, 13)
        Me.lblTextChange.TabIndex = 3
        Me.lblTextChange.Text = "Texto..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TextChange"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MouseHover"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Click:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(127, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 39)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Evento"
        '
        'frmEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 265)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTextChange)
        Me.Controls.Add(Me.txtTextChange)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmEvento"
        Me.Text = "frmEvento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTextChange As TextBox
    Friend WithEvents lblTextChange As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
