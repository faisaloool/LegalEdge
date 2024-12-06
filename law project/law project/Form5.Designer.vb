<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        MenuStrip1 = New MenuStrip()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        ContactToolStripMenuItem = New ToolStripMenuItem()
        ServicesToolStripMenuItem = New ToolStripMenuItem()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        MenuStrip1.TabIndex = 8
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
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14F)
        TextBox1.Location = New Point(318, 159)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(242, 32)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 14F)
        TextBox2.Location = New Point(318, 258)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(242, 32)
        TextBox2.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(199, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 21)
        Label1.TabIndex = 12
        Label1.Text = "Card Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(199, 264)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 13
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 14F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(334, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 46)
        Button1.TabIndex = 14
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(283, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(213, 47)
        Label3.TabIndex = 15
        Label3.Text = "Hello lawyer, please fill out the form below to get started"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Name = "Form5"
        Text = "Form5"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
