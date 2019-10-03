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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblNaslov = New System.Windows.Forms.Label()
        Me.btnPlayPause = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(639, 419)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'lblNaslov
        '
        Me.lblNaslov.AutoSize = True
        Me.lblNaslov.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaslov.Location = New System.Drawing.Point(3, 427)
        Me.lblNaslov.Name = "lblNaslov"
        Me.lblNaslov.Size = New System.Drawing.Size(162, 40)
        Me.lblNaslov.TabIndex = 3
        Me.lblNaslov.Text = "ZADATAK 2"
        '
        'btnPlayPause
        '
        Me.btnPlayPause.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayPause.Location = New System.Drawing.Point(411, 432)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(216, 35)
        Me.btnPlayPause.TabIndex = 4
        Me.btnPlayPause.Text = "PAUZIRAJ"
        Me.btnPlayPause.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 476)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.lblNaslov)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "Form1"
        Me.Text = "Zadatak 2"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblNaslov As Label
    Friend WithEvents btnPlayPause As Button
End Class
