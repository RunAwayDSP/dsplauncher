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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Path = New System.Windows.Forms.TextBox()
        Me.Server = New System.Windows.Forms.TextBox()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.loadProfile = New System.Windows.Forms.TextBox()
        Me.saveProfile = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Windower Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Server:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.launcher.My.Resources.Resources.dslogo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Path
        '
        Me.Path.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Path.Location = New System.Drawing.Point(146, 164)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(212, 20)
        Me.Path.TabIndex = 11
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(146, 190)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(212, 20)
        Me.Server.TabIndex = 13
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(146, 216)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(212, 20)
        Me.User.TabIndex = 15
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(146, 242)
        Me.Pass.Name = "Pass"
        Me.Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass.Size = New System.Drawing.Size(212, 20)
        Me.Pass.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(346, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Launch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(238, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Load Profile"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'loadProfile
        '
        Me.loadProfile.Location = New System.Drawing.Point(12, 336)
        Me.loadProfile.Name = "loadProfile"
        Me.loadProfile.Size = New System.Drawing.Size(220, 20)
        Me.loadProfile.TabIndex = 21
        Me.loadProfile.Text = "default"
        '
        'saveProfile
        '
        Me.saveProfile.Location = New System.Drawing.Point(12, 307)
        Me.saveProfile.Name = "saveProfile"
        Me.saveProfile.Size = New System.Drawing.Size(220, 20)
        Me.saveProfile.TabIndex = 23
        Me.saveProfile.Text = "default"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(238, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Save Profile"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 368)
        Me.Controls.Add(Me.saveProfile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.loadProfile)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DSP Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Path As System.Windows.Forms.TextBox
    Friend WithEvents Server As System.Windows.Forms.TextBox
    Friend WithEvents User As System.Windows.Forms.TextBox
    Friend WithEvents Pass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents loadProfile As System.Windows.Forms.TextBox
    Friend WithEvents saveProfile As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
