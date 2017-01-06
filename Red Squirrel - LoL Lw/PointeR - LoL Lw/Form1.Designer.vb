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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tb_suanki = New System.Windows.Forms.TextBox()
        Me.tb_gereken = New System.Windows.Forms.TextBox()
        Me.tb_gelenxp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_not = New System.Windows.Forms.Label()
        Me.lbl_sonuc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_sure = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.oyuntara = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_suanki
        '
        Me.tb_suanki.BackColor = System.Drawing.Color.Black
        Me.tb_suanki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_suanki.ForeColor = System.Drawing.Color.White
        Me.tb_suanki.Location = New System.Drawing.Point(263, 47)
        Me.tb_suanki.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_suanki.Name = "tb_suanki"
        Me.tb_suanki.ReadOnly = True
        Me.tb_suanki.Size = New System.Drawing.Size(133, 22)
        Me.tb_suanki.TabIndex = 3
        '
        'tb_gereken
        '
        Me.tb_gereken.BackColor = System.Drawing.Color.Black
        Me.tb_gereken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_gereken.ForeColor = System.Drawing.Color.White
        Me.tb_gereken.Location = New System.Drawing.Point(263, 11)
        Me.tb_gereken.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gereken.Name = "tb_gereken"
        Me.tb_gereken.ReadOnly = True
        Me.tb_gereken.Size = New System.Drawing.Size(133, 22)
        Me.tb_gereken.TabIndex = 2
        '
        'tb_gelenxp
        '
        Me.tb_gelenxp.BackColor = System.Drawing.Color.Black
        Me.tb_gelenxp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_gelenxp.ForeColor = System.Drawing.Color.White
        Me.tb_gelenxp.Location = New System.Drawing.Point(263, 111)
        Me.tb_gelenxp.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gelenxp.Name = "tb_gelenxp"
        Me.tb_gelenxp.Size = New System.Drawing.Size(133, 22)
        Me.tb_gelenxp.TabIndex = 0
        Me.tb_gelenxp.Text = "120"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Şuanki xp:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gereken xp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ortalama Gelen xp:"
        '
        'lbl_not
        '
        Me.lbl_not.AutoSize = True
        Me.lbl_not.ForeColor = System.Drawing.Color.Orange
        Me.lbl_not.Location = New System.Drawing.Point(39, 182)
        Me.lbl_not.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_not.Name = "lbl_not"
        Me.lbl_not.Size = New System.Drawing.Size(23, 17)
        Me.lbl_not.TabIndex = 6
        Me.lbl_not.Text = "---"
        '
        'lbl_sonuc
        '
        Me.lbl_sonuc.AutoSize = True
        Me.lbl_sonuc.ForeColor = System.Drawing.Color.Orange
        Me.lbl_sonuc.Location = New System.Drawing.Point(71, 206)
        Me.lbl_sonuc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sonuc.Name = "lbl_sonuc"
        Me.lbl_sonuc.Size = New System.Drawing.Size(23, 17)
        Me.lbl_sonuc.TabIndex = 7
        Me.lbl_sonuc.Text = "---"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Not:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 206)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kalan xp:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(296, 143)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ortalama Süre:"
        '
        'tb_sure
        '
        Me.tb_sure.BackColor = System.Drawing.Color.Black
        Me.tb_sure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_sure.ForeColor = System.Drawing.Color.White
        Me.tb_sure.Location = New System.Drawing.Point(263, 79)
        Me.tb_sure.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_sure.Name = "tb_sure"
        Me.tb_sure.ReadOnly = True
        Me.tb_sure.Size = New System.Drawing.Size(133, 22)
        Me.tb_sure.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Aqua
        Me.Button2.Location = New System.Drawing.Point(188, 143)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Ayarla"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'oyuntara
        '
        Me.oyuntara.Enabled = True
        Me.oyuntara.Interval = 4000
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.ForeColor = System.Drawing.Color.Red
        Me.lbl_1.Location = New System.Drawing.Point(400, 15)
        Me.lbl_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(13, 17)
        Me.lbl_1.TabIndex = 13
        Me.lbl_1.Text = "•"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.ForeColor = System.Drawing.Color.Red
        Me.lbl_2.Location = New System.Drawing.Point(400, 50)
        Me.lbl_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(13, 17)
        Me.lbl_2.TabIndex = 14
        Me.lbl_2.Text = "•"
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.ForeColor = System.Drawing.Color.Orange
        Me.lbl_3.Location = New System.Drawing.Point(400, 81)
        Me.lbl_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(13, 17)
        Me.lbl_3.TabIndex = 15
        Me.lbl_3.Text = "•"
        '
        'lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_4.Location = New System.Drawing.Point(400, 114)
        Me.lbl_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(13, 17)
        Me.lbl_4.TabIndex = 16
        Me.lbl_4.Text = "•"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(543, 242)
        Me.Controls.Add(Me.lbl_4)
        Me.Controls.Add(Me.lbl_3)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_sure)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_sonuc)
        Me.Controls.Add(Me.lbl_not)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_gelenxp)
        Me.Controls.Add(Me.tb_gereken)
        Me.Controls.Add(Me.tb_suanki)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RedSquirrel - LoL Lw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_suanki As System.Windows.Forms.TextBox
    Friend WithEvents tb_gereken As System.Windows.Forms.TextBox
    Friend WithEvents tb_gelenxp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_not As System.Windows.Forms.Label
    Friend WithEvents lbl_sonuc As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_sure As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents oyuntara As System.Windows.Forms.Timer
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_4 As System.Windows.Forms.Label

End Class
