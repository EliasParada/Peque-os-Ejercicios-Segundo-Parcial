<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExepciones
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
        Me.txtNumRes1 = New System.Windows.Forms.TextBox()
        Me.txtNumRes2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumRes1
        '
        Me.txtNumRes1.Location = New System.Drawing.Point(197, 87)
        Me.txtNumRes1.Name = "txtNumRes1"
        Me.txtNumRes1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumRes1.TabIndex = 2
        '
        'txtNumRes2
        '
        Me.txtNumRes2.Location = New System.Drawing.Point(322, 87)
        Me.txtNumRes2.Name = "txtNumRes2"
        Me.txtNumRes2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumRes2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Try...Catch"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(119, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 39)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Exepciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "-"
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Location = New System.Drawing.Point(290, 113)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(44, 13)
        Me.lblRes.TabIndex = 11
        Me.lblRes.Text = "Resta..."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Restar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmExepciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 130)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumRes2)
        Me.Controls.Add(Me.txtNumRes1)
        Me.Name = "frmExepciones"
        Me.Text = "frmCondiciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumRes1 As TextBox
    Friend WithEvents txtNumRes2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRes As Label
    Friend WithEvents Button2 As Button
End Class
