<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnIzracunaj = New System.Windows.Forms.Button()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.lblNaslov = New System.Windows.Forms.Label()
        Me.txtRezultat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIzracunaj
        '
        Me.btnIzracunaj.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzracunaj.Location = New System.Drawing.Point(12, 93)
        Me.btnIzracunaj.Name = "btnIzracunaj"
        Me.btnIzracunaj.Size = New System.Drawing.Size(216, 35)
        Me.btnIzracunaj.TabIndex = 0
        Me.btnIzracunaj.Text = "IZRACUNAJ"
        Me.btnIzracunaj.UseVisualStyleBackColor = True
        '
        'txtX
        '
        Me.txtX.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(12, 54)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(216, 33)
        Me.txtX.TabIndex = 1
        '
        'lblNaslov
        '
        Me.lblNaslov.AutoSize = True
        Me.lblNaslov.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaslov.Location = New System.Drawing.Point(5, 11)
        Me.lblNaslov.Name = "lblNaslov"
        Me.lblNaslov.Size = New System.Drawing.Size(162, 40)
        Me.lblNaslov.TabIndex = 2
        Me.lblNaslov.Text = "ZADATAK 1"
        '
        'txtRezultat
        '
        Me.txtRezultat.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRezultat.Location = New System.Drawing.Point(12, 134)
        Me.txtRezultat.Name = "txtRezultat"
        Me.txtRezultat.Size = New System.Drawing.Size(216, 33)
        Me.txtRezultat.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 175)
        Me.Controls.Add(Me.txtRezultat)
        Me.Controls.Add(Me.lblNaslov)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.btnIzracunaj)
        Me.Name = "Form1"
        Me.Text = "Zadatak 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIzracunaj As Button
    Friend WithEvents txtX As TextBox
    Friend WithEvents lblNaslov As Label
    Friend WithEvents txtRezultat As TextBox
End Class
