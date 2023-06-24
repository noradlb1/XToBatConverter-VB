Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms

Namespace XToBatConverter
    Public Partial Class addForm
        Inherits Form
        Public newFile As FormList.fileInfo
        Public files As List(Of FormList.fileInfo)
        Public formPrincipal As FormList

        Public Sub New(ByVal form As FormList)
            InitializeComponent()
            newFile = New FormList.fileInfo()
            formPrincipal = form
        End Sub

        <Obsolete>
        Private Sub textBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If opnFileDialog.ShowDialog() = DialogResult.OK Then
                tbFile.Text = CSharpImpl.__Assign(newFile.path, opnFileDialog.FileName)
                newFile.filename = opnFileDialog.SafeFileName
                newFile.size = New FileInfo(newFile.path).Length
            End If
        End Sub

        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            newFile.exec = chboxExec.Checked
            newFile.droppath = tbDrop.Text
            formPrincipal.files.Add(newFile)
            formPrincipal.actualizeList()
            Close()
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
