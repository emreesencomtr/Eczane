<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFormCount = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFormCount
        '
        Me.txtFormCount.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtFormCount.Location = New System.Drawing.Point(5, 48)
        Me.txtFormCount.Name = "txtFormCount"
        Me.txtFormCount.Size = New System.Drawing.Size(37, 33)
        Me.txtFormCount.TabIndex = 2
        Me.txtFormCount.Text = "1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.PictureBox1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(1093, 104)
        Me.GroupControl1.TabIndex = 4
        '
        'GroupControl2
        '
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.txtFormCount)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(921, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(172, 104)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "GroupControl2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(46, 39)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(123, 45)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Sanal Eczane Oluştur"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Eczane.My.Resources.Resources.header
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1020, 99)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 456)
        Me.Controls.Add(Me.GroupControl1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Eczane Simulasyonu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFormCount As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
