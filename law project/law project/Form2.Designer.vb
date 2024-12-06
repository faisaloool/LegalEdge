<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
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
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
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
        MenuStrip1.TabIndex = 5
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
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(491, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(297, 161)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(465, 43)
        Label1.TabIndex = 8
        Label1.Text = "Our office is dedicated to providing assistance across a variety of legal matters. We specialize in:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(76, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 9
        Label2.Text = "Family Law"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(76, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 10
        Label3.Text = "Tax Law"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(76, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 21)
        Label4.TabIndex = 11
        Label4.Text = "General Law Consultation"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(76, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 21)
        Label5.TabIndex = 12
        Label5.Text = "Employement Law"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(12, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(421, 55)
        Label6.TabIndex = 13
        Label6.Text = "Our team is adept at handling diverse case types to ensure the protection and advacacy of your rights."
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(86, 321)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 100)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(257, 321)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 100)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(428, 321)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 100)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(599, 321)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(100, 100)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 17
        PictureBox6.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(287, 262)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 45)
        Label7.TabIndex = 18
        Label7.Text = "Our Law Crew"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(86, 426)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 19
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(257, 426)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 15)
        Label9.TabIndex = 20
        Label9.Text = "Label9"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(428, 424)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 15)
        Label10.TabIndex = 21
        Label10.Text = "Label10"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(599, 426)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 15)
        Label11.TabIndex = 22
        Label11.Text = "Label11"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(800, 450)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
