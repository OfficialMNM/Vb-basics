<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmObjectDemonstrations
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.SampleTextFont = New System.Windows.Forms.TextBox()
        Me.cmbFontStyle = New System.Windows.Forms.GroupBox()
        Me.radiobuttonTahoma = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radiobuttonMagneto = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radiobuttonGaramond = New System.Windows.Forms.RadioButton()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnLoadPicture = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkBoxBI = New System.Windows.Forms.CheckBox()
        Me.checkBoxBold = New System.Windows.Forms.CheckBox()
        Me.checkBoxItalic = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radiobuttonRed = New System.Windows.Forms.RadioButton()
        Me.radiobuttonBlue = New System.Windows.Forms.RadioButton()
        Me.radiobuttonGreen = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialogShowDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        Me.cmbFontStyle.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.SampleTextFont)
        Me.groupBox1.Location = New System.Drawing.Point(33, 55)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(157, 98)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Display Test"
        '
        'SampleTextFont
        '
        Me.SampleTextFont.Location = New System.Drawing.Point(19, 35)
        Me.SampleTextFont.Name = "SampleTextFont"
        Me.SampleTextFont.Size = New System.Drawing.Size(92, 20)
        Me.SampleTextFont.TabIndex = 0
        Me.SampleTextFont.Text = "Sample Text"
        '
        'cmbFontStyle
        '
        Me.cmbFontStyle.BackColor = System.Drawing.SystemColors.Control
        Me.cmbFontStyle.Controls.Add(Me.radiobuttonTahoma)
        Me.cmbFontStyle.Controls.Add(Me.Label3)
        Me.cmbFontStyle.Controls.Add(Me.radiobuttonMagneto)
        Me.cmbFontStyle.Controls.Add(Me.Label2)
        Me.cmbFontStyle.Controls.Add(Me.radiobuttonGaramond)
        Me.cmbFontStyle.Controls.Add(Me.lbl)
        Me.cmbFontStyle.Location = New System.Drawing.Point(322, 55)
        Me.cmbFontStyle.Name = "cmbFontStyle"
        Me.cmbFontStyle.Size = New System.Drawing.Size(404, 133)
        Me.cmbFontStyle.TabIndex = 1
        Me.cmbFontStyle.TabStop = False
        Me.cmbFontStyle.Text = "Font"
        '
        'radiobuttonTahoma
        '
        Me.radiobuttonTahoma.AutoSize = True
        Me.radiobuttonTahoma.Location = New System.Drawing.Point(313, 36)
        Me.radiobuttonTahoma.Name = "radiobuttonTahoma"
        Me.radiobuttonTahoma.Size = New System.Drawing.Size(64, 17)
        Me.radiobuttonTahoma.TabIndex = 8
        Me.radiobuttonTahoma.TabStop = True
        Me.radiobuttonTahoma.Text = "Tahoma"
        Me.radiobuttonTahoma.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(294, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 40)
        Me.Label3.TabIndex = 7
        '
        'radiobuttonMagneto
        '
        Me.radiobuttonMagneto.AutoSize = True
        Me.radiobuttonMagneto.Location = New System.Drawing.Point(173, 35)
        Me.radiobuttonMagneto.Name = "radiobuttonMagneto"
        Me.radiobuttonMagneto.Size = New System.Drawing.Size(67, 17)
        Me.radiobuttonMagneto.TabIndex = 6
        Me.radiobuttonMagneto.TabStop = True
        Me.radiobuttonMagneto.Text = "Magneto"
        Me.radiobuttonMagneto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(163, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 40)
        Me.Label2.TabIndex = 5
        '
        'radiobuttonGaramond
        '
        Me.radiobuttonGaramond.AutoSize = True
        Me.radiobuttonGaramond.Location = New System.Drawing.Point(22, 36)
        Me.radiobuttonGaramond.Name = "radiobuttonGaramond"
        Me.radiobuttonGaramond.Size = New System.Drawing.Size(74, 17)
        Me.radiobuttonGaramond.TabIndex = 4
        Me.radiobuttonGaramond.TabStop = True
        Me.radiobuttonGaramond.Text = "Garamond"
        Me.radiobuttonGaramond.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl.Location = New System.Drawing.Point(13, 30)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(125, 40)
        Me.lbl.TabIndex = 3
        '
        'btnLoadPicture
        '
        Me.btnLoadPicture.Location = New System.Drawing.Point(35, 399)
        Me.btnLoadPicture.Name = "btnLoadPicture"
        Me.btnLoadPicture.Size = New System.Drawing.Size(94, 39)
        Me.btnLoadPicture.TabIndex = 2
        Me.btnLoadPicture.Text = "Load Picture"
        Me.btnLoadPicture.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(635, 397)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 25)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkBoxBI)
        Me.GroupBox3.Controls.Add(Me.checkBoxBold)
        Me.GroupBox3.Controls.Add(Me.checkBoxItalic)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(201, 145)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Style"
        '
        'checkBoxBI
        '
        Me.checkBoxBI.AutoSize = True
        Me.checkBoxBI.Location = New System.Drawing.Point(22, 105)
        Me.checkBoxBI.Name = "checkBoxBI"
        Me.checkBoxBI.Size = New System.Drawing.Size(72, 17)
        Me.checkBoxBI.TabIndex = 2
        Me.checkBoxBI.Text = "Bold Italic"
        Me.checkBoxBI.UseVisualStyleBackColor = True
        '
        'checkBoxBold
        '
        Me.checkBoxBold.AutoSize = True
        Me.checkBoxBold.Location = New System.Drawing.Point(22, 65)
        Me.checkBoxBold.Name = "checkBoxBold"
        Me.checkBoxBold.Size = New System.Drawing.Size(47, 17)
        Me.checkBoxBold.TabIndex = 1
        Me.checkBoxBold.Text = "Bold"
        Me.checkBoxBold.UseVisualStyleBackColor = True
        '
        'checkBoxItalic
        '
        Me.checkBoxItalic.AutoSize = True
        Me.checkBoxItalic.Location = New System.Drawing.Point(21, 33)
        Me.checkBoxItalic.Name = "checkBoxItalic"
        Me.checkBoxItalic.Size = New System.Drawing.Size(48, 17)
        Me.checkBoxItalic.TabIndex = 0
        Me.checkBoxItalic.Text = "Italic"
        Me.checkBoxItalic.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radiobuttonRed)
        Me.GroupBox4.Controls.Add(Me.radiobuttonBlue)
        Me.GroupBox4.Controls.Add(Me.radiobuttonGreen)
        Me.GroupBox4.Location = New System.Drawing.Point(579, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(137, 144)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Font Color"
        '
        'radiobuttonRed
        '
        Me.radiobuttonRed.AutoSize = True
        Me.radiobuttonRed.Location = New System.Drawing.Point(27, 104)
        Me.radiobuttonRed.Name = "radiobuttonRed"
        Me.radiobuttonRed.Size = New System.Drawing.Size(45, 17)
        Me.radiobuttonRed.TabIndex = 2
        Me.radiobuttonRed.TabStop = True
        Me.radiobuttonRed.Text = "Red"
        Me.radiobuttonRed.UseVisualStyleBackColor = True
        '
        'radiobuttonBlue
        '
        Me.radiobuttonBlue.AutoSize = True
        Me.radiobuttonBlue.Location = New System.Drawing.Point(26, 65)
        Me.radiobuttonBlue.Name = "radiobuttonBlue"
        Me.radiobuttonBlue.Size = New System.Drawing.Size(46, 17)
        Me.radiobuttonBlue.TabIndex = 1
        Me.radiobuttonBlue.TabStop = True
        Me.radiobuttonBlue.Text = "Blue"
        Me.radiobuttonBlue.UseVisualStyleBackColor = True
        '
        'radiobuttonGreen
        '
        Me.radiobuttonGreen.AutoSize = True
        Me.radiobuttonGreen.Location = New System.Drawing.Point(26, 31)
        Me.radiobuttonGreen.Name = "radiobuttonGreen"
        Me.radiobuttonGreen.Size = New System.Drawing.Size(54, 17)
        Me.radiobuttonGreen.TabIndex = 0
        Me.radiobuttonGreen.TabStop = True
        Me.radiobuttonGreen.Text = "Green"
        Me.radiobuttonGreen.UseVisualStyleBackColor = True
        '
        'OpenFileDialogShowDialog
        '
        Me.OpenFileDialogShowDialog.FileName = "OpenFileDialog"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(33, 208)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(213, 141)
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'frmObjectDemonstrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadPicture)
        Me.Controls.Add(Me.cmbFontStyle)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmObjectDemonstrations"
        Me.Text = " "
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.cmbFontStyle.ResumeLayout(False)
        Me.cmbFontStyle.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents SampleTextFont As TextBox
    Friend WithEvents cmbFontStyle As GroupBox
    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents checkBoxBI As CheckBox
    Friend WithEvents checkBoxBold As CheckBox
    Friend WithEvents checkBoxItalic As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radiobuttonRed As RadioButton
    Friend WithEvents radiobuttonBlue As RadioButton
    Friend WithEvents radiobuttonGreen As RadioButton
    Friend WithEvents OpenFileDialogShowDialog As OpenFileDialog
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radiobuttonMagneto As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents radiobuttonGaramond As RadioButton
    Friend WithEvents radiobuttonTahoma As RadioButton
End Class
