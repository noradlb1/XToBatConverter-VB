﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace XToBatConverter.Properties


    ''' <summary>
    '''   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    ''' </summary>
    ' Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    ' à l'aide d'un outil, tel que ResGen ou Visual Studio.
    ' Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    ' avec l'option /str ou régénérez votre projet VS.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Class Resources

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>
        Friend Sub New()
        End Sub

        ''' <summary>
        '''   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared ReadOnly Property ResourceManager As Global.System.Resources.ResourceManager
            Get
                If resourceMan Is Nothing Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("XToBatConverter.Properties.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared Property Culture As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Class
End Namespace
