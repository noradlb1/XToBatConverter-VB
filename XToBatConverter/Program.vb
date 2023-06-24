Imports System
Imports System.Windows.Forms

Namespace XToBatConverter
    Friend Module Program
        ''' <summary>
        ''' Point d'entrée principal de l'application.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New FormList())
        End Sub
    End Module
End Namespace
