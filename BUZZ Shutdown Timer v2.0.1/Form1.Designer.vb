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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.NumBox1 = New System.Windows.Forms.NumericUpDown()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.NumBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.BackgroundImage = Global.BUZZ_Shutdown_Timer.My.Resources.Resources.Start
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.FlatAppearance.BorderSize = 4
        Me.Button1.Font = New System.Drawing.Font("AngryBirds", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(204, 189)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Azure
        Me.Button6.BackgroundImage = Global.BUZZ_Shutdown_Timer.My.Resources.Resources.Cancel2
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.FlatAppearance.BorderSize = 4
        Me.Button6.Font = New System.Drawing.Font("AngryBirds", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.IndianRed
        Me.Button6.Location = New System.Drawing.Point(57, 258)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(259, 44)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = False
        '
        'NumBox1
        '
        Me.NumBox1.BackColor = System.Drawing.Color.Azure
        Me.NumBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumBox1.ForeColor = System.Drawing.Color.Maroon
        Me.NumBox1.Location = New System.Drawing.Point(57, 189)
        Me.NumBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumBox1.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.NumBox1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumBox1.Name = "NumBox1"
        Me.NumBox1.Size = New System.Drawing.Size(108, 44)
        Me.NumBox1.TabIndex = 6
        Me.NumBox1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(190, 333)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(177, 15)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.hridoy-buzz.blogspot.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(54, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "* Insert Time in Minutes (1 -1440)"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.BUZZ_Shutdown_Timer.My.Resources.Resources.Title
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(380, 357)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.NumBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 400)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "BUZZ Shutdown Timer"
        CType(Me.NumBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents NumBox1 As NumericUpDown
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
End Class
