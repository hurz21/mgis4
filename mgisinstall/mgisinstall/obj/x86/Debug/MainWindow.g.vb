﻿#ExternalChecksum("..\..\..\MainWindow.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","DB6D1E834BEA3EEF19E3B6CF3FE0B0A9C00CFDF36993D43DDC5103C5BFFD03FE")
'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports mgisinstall
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes


'''<summary>
'''MainWindow
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainWindow
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",13)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbadminBplan As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbVorabinfo As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents spTop As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnInstall As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnabbruch As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",31)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents sc1 As System.Windows.Controls.ScrollViewer
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",33)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbinfo As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",37)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents spErfolg As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",39)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnShortcut As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",41)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnExplorer As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",44)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents spAusfuehren As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",46)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnStarteUpdate As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/mgisinstall;component/mainwindow.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\MainWindow.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.tbadminBplan = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 2) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",17)
            AddHandler CType(target,System.Windows.Documents.Hyperlink).RequestNavigate, New System.Windows.Navigation.RequestNavigateEventHandler(AddressOf Me.OnNavigate)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.tbVorabinfo = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 4) Then
            Me.spTop = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 5) Then
            Me.btnInstall = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\MainWindow.xaml",25)
            AddHandler Me.btnInstall.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnInstall_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.btnabbruch = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\MainWindow.xaml",28)
            AddHandler Me.btnabbruch.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnabbruch_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 7) Then
            Me.sc1 = CType(target,System.Windows.Controls.ScrollViewer)
            Return
        End If
        If (connectionId = 8) Then
            Me.tbinfo = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 9) Then
            Me.spErfolg = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 10) Then
            Me.btnShortcut = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\MainWindow.xaml",39)
            AddHandler Me.btnShortcut.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnShortcut_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 11) Then
            Me.btnExplorer = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\MainWindow.xaml",41)
            AddHandler Me.btnExplorer.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnExplorer_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 12) Then
            Me.spAusfuehren = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 13) Then
            Me.btnStarteUpdate = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\MainWindow.xaml",46)
            AddHandler Me.btnStarteUpdate.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnStarteUpdate_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

