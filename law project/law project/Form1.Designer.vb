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
        MenuStrip1 = New MenuStrip()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        ContactToolStripMenuItem = New ToolStripMenuItem()
        ServicesToolStripMenuItem = New ToolStripMenuItem()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        MenuStrip1.TabIndex = 4
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
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 39)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(800, 174)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(220), CByte(170), CByte(90))
        Label1.Location = New Point(130, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(519, 47)
        Label1.TabIndex = 7
        Label1.Text = "LegalEdge Associates Law Office"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(27, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 52)
        Label2.TabIndex = 8
        Label2.Text = "About us:"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(379, 81)
        Label3.TabIndex = 9
        Label3.Text = "LegalEdge Associates is one of the best law offices you can deal with, we can guarantee to find the best solution to your case."
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 364)
        Label4.Name = "Label4"
        Label4.Size = New Size(379, 53)
        Label4.TabIndex = 10
        Label4.Text = "We also have one of the best law crew to guarantee your rights."
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(468, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(283, 52)
        Label5.TabIndex = 11
        Label5.Text = "Awards we got:"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(495, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(237, 23)
        Label6.TabIndex = 12
        Label6.Text = "International Law Awards"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(495, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(204, 23)
        Label7.TabIndex = 13
        Label7.Text = "Legal Excellence Awards"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(495, 332)
        Label8.Name = "Label8"
        Label8.Size = New Size(215, 23)
        Label8.TabIndex = 14
        Label8.Text = "Legal Innovation Awards"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(495, 363)
        Label9.Name = "Label9"
        Label9.Size = New Size(215, 23)
        Label9.TabIndex = 15
        Label9.Text = "Legal Ranking Awards"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "LegalEdge Associates"
        TransparencyKey = Color.Transparent
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class
