﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opera_Gx
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox61 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(536, 230)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(139, 56)
        Me.TrackBar1.TabIndex = 320
        Me.TrackBar1.Value = 80
        Me.TrackBar1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(508, 498)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 46)
        Me.Panel1.TabIndex = 319
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Scegli dove scaricare l'installer"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(759, 498)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(112, 46)
        Me.Panel7.TabIndex = 318
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Scarica"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(20, 436)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(849, 22)
        Me.TextBox1.TabIndex = 317
        Me.TextBox1.Text = "Destinazione Installer"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.RoyalBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 354)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(851, 28)
        Me.ProgressBar1.TabIndex = 316
        Me.ProgressBar1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 283)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 30)
        Me.Label5.TabIndex = 315
        Me.Label5.Text = "Versione  93.0.4585.52"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(197, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 314
        Me.Label4.Text = "Opera Gx"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(720, 219)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 312
        Me.TextBox2.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.Software_Package_Installer.My.Resources.Resources._3
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(891, 103)
        Me.Panel9.TabIndex = 313
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.PictureBox61)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Location = New System.Drawing.Point(4, 4)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(887, 102)
        Me.Panel8.TabIndex = 28
        '
        'PictureBox61
        '
        Me.PictureBox61.Image = Global.Software_Package_Installer.My.Resources.Resources.Senza_titolo10
        Me.PictureBox61.Location = New System.Drawing.Point(4, 15)
        Me.PictureBox61.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox61.Name = "PictureBox61"
        Me.PictureBox61.Size = New System.Drawing.Size(72, 50)
        Me.PictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox61.TabIndex = 29
        Me.PictureBox61.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 51)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Opera Gx"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.25!)
        Me.Label2.Location = New System.Drawing.Point(721, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 70)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.25!)
        Me.Label1.Location = New System.Drawing.Point(801, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Software_Package_Installer.My.Resources.Resources._05xLigiuyW7Og4jxUDKd60e_1_2
        Me.PictureBox1.Location = New System.Drawing.Point(35, 119)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 311
        Me.PictureBox1.TabStop = False
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'Timer7
        '
        '
        'Timer8
        '
        '
        'Timer9
        '
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Opera_Gx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Software_Package_Installer.My.Resources.Resources.Immagine_2022_06_13_20345310
        Me.ClientSize = New System.Drawing.Size(889, 555)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Opera_Gx"
        Me.Text = "Opera Gx"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox61 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class