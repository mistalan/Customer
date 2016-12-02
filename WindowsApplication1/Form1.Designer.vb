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
        Me.OpenToolStripMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.InformationBox = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Customer = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.OpenToolStripMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenToolStripMenu
        '
        Me.OpenToolStripMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OpenToolStripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.OpenToolStripMenu.Location = New System.Drawing.Point(0, 0)
        Me.OpenToolStripMenu.Name = "OpenToolStripMenu"
        Me.OpenToolStripMenu.Size = New System.Drawing.Size(863, 27)
        Me.OpenToolStripMenu.TabIndex = 3
        Me.OpenToolStripMenu.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.add2_32
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.Text = "OpenToolStripMenuItem"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(160, 41)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(179, 22)
        Me.TextBox5.TabIndex = 4
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(160, 69)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(179, 22)
        Me.IDBox.TabIndex = 5
        '
        'InformationBox
        '
        Me.InformationBox.Location = New System.Drawing.Point(160, 97)
        Me.InformationBox.Name = "InformationBox"
        Me.InformationBox.Size = New System.Drawing.Size(564, 202)
        Me.InformationBox.TabIndex = 6
        Me.InformationBox.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(166, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "File Name"
        '
        'Customer
        '
        Me.Customer.AutoSize = True
        Me.Customer.Location = New System.Drawing.Point(27, 44)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(127, 17)
        Me.Customer.TabIndex = 8
        Me.Customer.Text = "Opened Customer:"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(27, 72)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(25, 17)
        Me.ID.TabIndex = 9
        Me.ID.Text = "ID:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 395)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Customer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.InformationBox)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.OpenToolStripMenu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.OpenToolStripMenu.ResumeLayout(False)
        Me.OpenToolStripMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenToolStripMenu As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents IDBox As TextBox
    Friend WithEvents InformationBox As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Customer As Label
    Friend WithEvents ID As Label
End Class
