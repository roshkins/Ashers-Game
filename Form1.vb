Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(104, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "UP"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Right"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Left"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(128, 256)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(16, 56)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Down"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 326)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox3.Top = PictureBox3.Top - 5
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox3.Top = PictureBox3.Top + 5
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If PictureBox3.Left < Width Then
            PictureBox3.Left = PictureBox3.Left - 5
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        PictureBox3.Left = PictureBox3.Left + 5


    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As System.Drawing.Graphics
        Dim r As New System.Drawing.Pen(Drawing.Color.Red)
        g = Me.CreateGraphics
        g.DrawLine(r, 20, 30, 100, 80)
        Dim g1 As System.Drawing.Graphics
        Dim r1 As New System.Drawing.Pen(Drawing.Color.Red)
        g = Me.CreateGraphics
        g.DrawLine(r, 21, 31, 101, 81)
        g.DrawLine(r, 22, 32, 102, 82)
        g.DrawLine(r, 23, 33, 103, 83)
        g.DrawLine(r, 20, 30, 100, 877)
        g.DrawLine(r, 20, 30, 100, 888)
        g.DrawLine(r, 20, 30, 100, 899)
        g.DrawLine(r, 20, 30, 100, 8000)
       
    End Sub
End Class
