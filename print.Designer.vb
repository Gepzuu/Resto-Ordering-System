<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(print))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.preview = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textcomment = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.preview)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 251)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Crimson
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(395, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 72)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(399, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Receipt Preview"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Gadugi", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label10.Location = New System.Drawing.Point(432, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 57)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "↵"
        '
        'preview
        '
        Me.preview.Location = New System.Drawing.Point(8, 8)
        Me.preview.Name = "preview"
        Me.preview.ReadOnly = True
        Me.preview.Size = New System.Drawing.Size(376, 231)
        Me.preview.TabIndex = 3
        Me.preview.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(580, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 360)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LavenderBlush
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.textcomment)
        Me.Panel5.Location = New System.Drawing.Point(13, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(289, 341)
        Me.Panel5.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 32)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Thank you"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comment  💬"
        '
        'textcomment
        '
        Me.textcomment.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcomment.Location = New System.Drawing.Point(16, 198)
        Me.textcomment.Name = "textcomment"
        Me.textcomment.Size = New System.Drawing.Size(260, 124)
        Me.textcomment.TabIndex = 0
        Me.textcomment.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Crimson
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(12, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(543, 225)
        Me.Panel3.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Me.TextBox3)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(8, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(522, 195)
        Me.Panel6.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Crimson
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"GCASH", "COD", "CARD"})
        Me.ComboBox1.Location = New System.Drawing.Point(362, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 26)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "Mode of Payment"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Crimson
        Me.TextBox3.Location = New System.Drawing.Point(35, 163)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(296, 21)
        Me.TextBox3.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 22)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Phone Number"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Crimson
        Me.TextBox2.Location = New System.Drawing.Point(35, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(296, 21)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Crimson
        Me.TextBox1.Location = New System.Drawing.Point(35, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 21)
        Me.TextBox1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address  🗺"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(17, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "👤"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(155, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Customer Information ✍️"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(813, 378)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(655, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "🖶  Print "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Cyan
        Me.Button2.Location = New System.Drawing.Point(630, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "👁‍🗨  Print Preview"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(909, 516)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Orders 🛒"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textcomment As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents preview As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
