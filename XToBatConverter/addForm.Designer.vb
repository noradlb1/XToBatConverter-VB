Imports System

Namespace XToBatConverter
    Partial Class addForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        <Obsolete>
        Private Sub InitializeComponent()
            lblPath = New System.Windows.Forms.Label()
            btnAdd = New System.Windows.Forms.Button()
            tbFile = New System.Windows.Forms.TextBox()
            tbDrop = New System.Windows.Forms.TextBox()
            label1 = New System.Windows.Forms.Label()
            opnFileDialog = New System.Windows.Forms.OpenFileDialog()
            chboxExec = New System.Windows.Forms.CheckBox()
            SuspendLayout()
            ' 
            ' lblPath
            ' 
            lblPath.AutoSize = True
            lblPath.Location = New Drawing.Point(13, 13)
            lblPath.Name = "lblPath"
            lblPath.Size = New Drawing.Size(23, 13)
            lblPath.TabIndex = 0
            lblPath.Text = "file:"
            ' 
            ' btnAdd
            ' 
            btnAdd.Location = New Drawing.Point(135, 86)
            btnAdd.Name = "btnAdd"
            btnAdd.Size = New Drawing.Size(75, 23)
            btnAdd.TabIndex = 1
            btnAdd.Text = "save"
            btnAdd.UseVisualStyleBackColor = True
            AddHandler btnAdd.Click, New EventHandler(AddressOf btnAdd_Click)
            ' 
            ' tbFile
            ' 
            tbFile.Location = New Drawing.Point(62, 10)
            tbFile.Name = "tbFile"
            tbFile.Size = New Drawing.Size(148, 20)
            tbFile.TabIndex = 2
            AddHandler tbFile.Click, New EventHandler(AddressOf textBox1_Click)
            ' 
            ' tbDrop
            ' 
            tbDrop.Location = New Drawing.Point(62, 36)
            tbDrop.Name = "tbDrop"
            tbDrop.Size = New Drawing.Size(148, 20)
            tbDrop.TabIndex = 3
            tbDrop.Text = "%cd%\"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(13, 39)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(43, 13)
            label1.TabIndex = 4
            label1.Text = "drop to:"
            ' 
            ' opnFileDialog
            ' 
            opnFileDialog.FileName = "openFileDialog1"
            ' 
            ' chboxExec
            ' 
            chboxExec.AutoSize = True
            chboxExec.Location = New Drawing.Point(16, 62)
            chboxExec.Name = "chboxExec"
            chboxExec.Size = New Drawing.Size(137, 17)
            chboxExec.TabIndex = 5
            chboxExec.Text = "execute after extraction"
            chboxExec.UseVisualStyleBackColor = True
            ' 
            ' addForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(220, 121)
            Controls.Add(chboxExec)
            Controls.Add(label1)
            Controls.Add(tbDrop)
            Controls.Add(tbFile)
            Controls.Add(btnAdd)
            Controls.Add(lblPath)
            Name = "addForm"
            Text = "addForm"
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private lblPath As System.Windows.Forms.Label
        Private btnAdd As System.Windows.Forms.Button
        Private tbFile As System.Windows.Forms.TextBox
        Private tbDrop As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private opnFileDialog As System.Windows.Forms.OpenFileDialog
        Private chboxExec As System.Windows.Forms.CheckBox
    End Class
End Namespace
