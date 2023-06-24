Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Namespace XToBatConverter
    Public Partial Class FormList
        Inherits Form

        Public files As List(Of fileInfo)
        Public Structure fileInfo
            Public filename As String
            Public path As String
            Public droppath As String
            Public exec As Boolean
            Public size As Long
        End Structure

        Public Sub New()
            InitializeComponent()
            files = New List(Of fileInfo)()
        End Sub

        Public Sub actualizeList()
            listView1.Items.Clear()
            For Each element In files
                Dim row As String() = {element.filename, element.size.ToString(), element.path, element.droppath, ""}
                If element.exec Then row(4) = "x"
                Dim listViewItem = New ListViewItem(row)
                listView1.Items.Add(listViewItem)
            Next
        End Sub

        Public Function genBat() As String
            Dim builder As StringBuilder = New StringBuilder()
            builder.AppendLine("@ echo off")
            For Each element In files
                Dim bytes = File.ReadAllBytes(element.path)
                builder.AppendLine(genCert(bytes, element.droppath, element.filename))
                If element.exec Then builder.AppendLine("start " & element.droppath & element.filename)
            Next

            Return builder.ToString()
        End Function

        Public Function genCert(ByVal file As Byte(), ByVal drop As String, ByVal filename As String) As String
            Dim builder As StringBuilder = New StringBuilder()
            builder.AppendLine("echo -----BEGIN CERTIFICATE-----")
            builder.AppendLine(Convert.ToBase64String(file, Base64FormattingOptions.InsertLineBreaks))
            builder.AppendLine("-----END CERTIFICATE-----")
            Dim s2 As String = builder.ToString().Replace(Microsoft.VisualBasic.Constants.vbLf, Microsoft.VisualBasic.Constants.vbLf & "echo ")
            s2 = "(" & Microsoft.VisualBasic.Constants.vbLf & s2 & Microsoft.VisualBasic.Constants.vbLf & ") >>" & drop & "_" & filename & "_.b64" & Microsoft.VisualBasic.Constants.vbLf & "certutil -decode " & drop & "_" & filename & "_.b64 """ & drop & filename & """" & Microsoft.VisualBasic.Constants.vbLf & "del " & drop & "*_.b64"
            Return s2
        End Function

        Private Sub addToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim addNewFile As addForm = New addForm(Me)
            addNewFile.Show()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If sfdBatchFile.ShowDialog() = DialogResult.OK Then
                Call File.AppendAllText(sfdBatchFile.FileName, genBat())
            End If
        End Sub

        Private Sub deleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            For Each element In files
                If String.Equals(element.path, listView1.SelectedItems(0).SubItems(2).Text) Then
                    files.Remove(element)
                    actualizeList()
                    Exit For
                End If
            Next

        End Sub
    End Class
End Namespace
