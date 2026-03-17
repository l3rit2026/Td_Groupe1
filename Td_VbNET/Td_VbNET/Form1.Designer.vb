<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BntModifier = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nb1 = New System.Windows.Forms.TextBox()
        Me.nb2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label kevin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label kevin"
        '
        'BntModifier
        '
        Me.BntModifier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BntModifier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BntModifier.Location = New System.Drawing.Point(35, 336)
        Me.BntModifier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BntModifier.Name = "BntModifier"
        Me.BntModifier.Size = New System.Drawing.Size(147, 43)
        Me.BntModifier.TabIndex = 2
        Me.BntModifier.Text = "MODIFIER "
        Me.BntModifier.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "somme deux nombre"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nb1
        '
        Me.nb1.Location = New System.Drawing.Point(203, 308)
        Me.nb1.Name = "nb1"
        Me.nb1.Size = New System.Drawing.Size(45, 22)
        Me.nb1.TabIndex = 4
        '
        'nb2
        '
        Me.nb2.Location = New System.Drawing.Point(287, 308)
        Me.nb2.Name = "nb2"
        Me.nb2.Size = New System.Drawing.Size(45, 22)
        Me.nb2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 407)
        Me.Controls.Add(Me.nb2)
        Me.Controls.Add(Me.nb1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BntModifier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BntModifier As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nb1 As System.Windows.Forms.TextBox
    Friend WithEvents nb2 As System.Windows.Forms.TextBox

End Class
