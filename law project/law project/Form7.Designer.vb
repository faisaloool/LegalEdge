<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        MenuStrip1 = New MenuStrip()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        ContactToolStripMenuItem = New ToolStripMenuItem()
        ServicesToolStripMenuItem = New ToolStripMenuItem()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        MenuStrip1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {LoginToolStripMenuItem, ContactToolStripMenuItem, ServicesToolStripMenuItem, HomeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(800, 38)
        MenuStrip1.TabIndex = 10
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.ForeColor = Color.FromArgb(CByte(220), CByte(170), CByte(90))
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(82, 34)
        LoginToolStripMenuItem.Text = "Log in"
        ' 
        ' ContactToolStripMenuItem
        ' 
        ContactToolStripMenuItem.ForeColor = Color.FromArgb(CByte(220), CByte(170), CByte(90))
        ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        ContactToolStripMenuItem.Size = New Size(97, 34)
        ContactToolStripMenuItem.Text = "Contact"
        ' 
        ' ServicesToolStripMenuItem
        ' 
        ServicesToolStripMenuItem.ForeColor = Color.FromArgb(CByte(220), CByte(170), CByte(90))
        ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        ServicesToolStripMenuItem.Size = New Size(99, 34)
        ServicesToolStripMenuItem.Text = "Services"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.ForeColor = Color.FromArgb(CByte(220), CByte(170), CByte(90))
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(81, 34)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 41)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 168)
        Panel1.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(145, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(158, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(160, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(462, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 4
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(469, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 5
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(463, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 6
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(465, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 7
        Label8.Text = "Label8"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 123)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Name = "Form7"
        Text = "Form7"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
