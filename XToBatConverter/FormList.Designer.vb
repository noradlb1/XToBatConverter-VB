Imports System

Namespace XToBatConverter
    Partial Class FormList
        ''' <summary>
        ''' Variable nécessaire au concepteur.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Nettoyage des ressources utilisées.
        ''' </summary>
        ''' <paramname="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Code généré par le Concepteur Windows Form"

        ''' <summary>
        ''' Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        ''' le contenu de cette méthode avec l'éditeur de code.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.colFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colDroppath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colExec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.contextMenuFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.addToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGenerate = New System.Windows.Forms.Button()
            Me.sfdBatchFile = New System.Windows.Forms.SaveFileDialog()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.groupBox1.SuspendLayout()
            Me.contextMenuFile.SuspendLayout()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.listView1)
            Me.groupBox1.Location = New System.Drawing.Point(12, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(409, 237)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "files"
            '
            'listView1
            '
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFilename, Me.colSize, Me.colPath, Me.colDroppath, Me.colExec})
            Me.listView1.ContextMenuStrip = Me.contextMenuFile
            Me.listView1.FullRowSelect = True
            Me.listView1.GridLines = True
            Me.listView1.HideSelection = False
            Me.listView1.Location = New System.Drawing.Point(6, 19)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(397, 212)
            Me.listView1.TabIndex = 0
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            '
            'colFilename
            '
            Me.colFilename.Text = "Filename"
            '
            'colSize
            '
            Me.colSize.Text = "Size"
            '
            'colPath
            '
            Me.colPath.Text = "Path"
            '
            'colDroppath
            '
            Me.colDroppath.Text = "Drop Path"
            '
            'colExec
            '
            Me.colExec.Text = "Execute"
            Me.colExec.Width = 53
            '
            'contextMenuFile
            '
            Me.contextMenuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addToolStripMenuItem, Me.deleteToolStripMenuItem})
            Me.contextMenuFile.Name = "contextMenuFile"
            Me.contextMenuFile.Size = New System.Drawing.Size(107, 48)
            '
            'addToolStripMenuItem
            '
            Me.addToolStripMenuItem.Name = "addToolStripMenuItem"
            Me.addToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
            Me.addToolStripMenuItem.Text = "add"
            '
            'deleteToolStripMenuItem
            '
            Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
            Me.deleteToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
            Me.deleteToolStripMenuItem.Text = "delete"
            '
            'btnGenerate
            '
            Me.btnGenerate.Location = New System.Drawing.Point(340, 255)
            Me.btnGenerate.Name = "btnGenerate"
            Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
            Me.btnGenerate.TabIndex = 1
            Me.btnGenerate.Text = "generate"
            Me.btnGenerate.UseVisualStyleBackColor = True
            '
            'sfdBatchFile
            '
            Me.sfdBatchFile.Filter = "Batch File|*.bat"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(15, 259)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(149, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "MyTelegram:@MONSTERMC"
            '
            'FormList
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(434, 284)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnGenerate)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "FormList"
            Me.Text = "xtobatconvert"
            Me.groupBox1.ResumeLayout(False)
            Me.contextMenuFile.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private groupBox1 As System.Windows.Forms.GroupBox
        Private listView1 As System.Windows.Forms.ListView
        Private btnGenerate As System.Windows.Forms.Button
        Private sfdBatchFile As System.Windows.Forms.SaveFileDialog
        Private contextMenuFile As System.Windows.Forms.ContextMenuStrip
        Private addToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private colFilename As System.Windows.Forms.ColumnHeader
        Private colSize As System.Windows.Forms.ColumnHeader
        Private colPath As System.Windows.Forms.ColumnHeader
        Private colDroppath As System.Windows.Forms.ColumnHeader
        Private colExec As System.Windows.Forms.ColumnHeader
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace
