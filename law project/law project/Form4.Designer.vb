<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        MenuStrip1 = New MenuStrip()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        ContactToolStripMenuItem = New ToolStripMenuItem()
        ServicesToolStripMenuItem = New ToolStripMenuItem()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        MenuStrip1.TabIndex = 7
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
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 24F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(204, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 51)
        Label1.TabIndex = 9
        Label1.Text = "Choose Account Type"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(90, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 23)
        Label2.TabIndex = 10
        Label2.Text = "Lawyer"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(246, 214)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(87, 130)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(252, 243)
        Panel1.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(462, 130)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(252, 243)
        Panel2.TabIndex = 15
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(246, 214)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(101, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 23)
        Label3.TabIndex = 10
        Label3.Text = "Client"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Name = "Form4"
        Text = "Form4"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
End Class
