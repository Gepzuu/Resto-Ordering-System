<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaladToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SushiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Tw Cen MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(93, 26)
        Me.HomeToolStripMenuItem.Text = "🏠 Home"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.AboutUsToolStripMenuItem.Text = "Homepage 🏠"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrinksToolStripMenuItem, Me.SaladToolStripMenuItem, Me.RamenToolStripMenuItem, Me.SushiToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(92, 26)
        Me.MenuToolStripMenuItem.Text = "📑 Menu"
        '
        'DrinksToolStripMenuItem
        '
        Me.DrinksToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.DrinksToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.DrinksToolStripMenuItem.Name = "DrinksToolStripMenuItem"
        Me.DrinksToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.DrinksToolStripMenuItem.Text = "Drinks"
        '
        'SaladToolStripMenuItem
        '
        Me.SaladToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SaladToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.SaladToolStripMenuItem.Name = "SaladToolStripMenuItem"
        Me.SaladToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SaladToolStripMenuItem.Text = "Salad"
        '
        'RamenToolStripMenuItem
        '
        Me.RamenToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RamenToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.RamenToolStripMenuItem.Name = "RamenToolStripMenuItem"
        Me.RamenToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.RamenToolStripMenuItem.Text = "Ramen"
        '
        'SushiToolStripMenuItem
        '
        Me.SushiToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SushiToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.SushiToolStripMenuItem.Name = "SushiToolStripMenuItem"
        Me.SushiToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SushiToolStripMenuItem.Text = "Sushi"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToOrderToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(96, 26)
        Me.HelpToolStripMenuItem.Text = "🏳 About"
        '
        'HowToOrderToolStripMenuItem
        '
        Me.HowToOrderToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson
        Me.HowToOrderToolStripMenuItem.Name = "HowToOrderToolStripMenuItem"
        Me.HowToOrderToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.HowToOrderToolStripMenuItem.Text = "Giorno Giovanna 📝"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 494)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.IndianRed
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giornogiorno Giovanna Restaurant"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaladToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RamenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SushiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToOrderToolStripMenuItem As ToolStripMenuItem
End Class
