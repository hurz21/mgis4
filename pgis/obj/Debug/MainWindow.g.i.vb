﻿#ExternalChecksum("..\..\MainWindow.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","8D06D44B57AC3CB4791C0D363E9A15C205A227823BA235FA2B85A83CEDE95399")
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

Imports pgis
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
Imports System.Windows.Shell


'''<summary>
'''MainWindow
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainWindow
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\MainWindow.xaml",19)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents dockMenu As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbAdresse As System.Windows.Controls.TabItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbGemeinde As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbgemeinde As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",35)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbStrasse As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",36)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbStrasse As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",42)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbHausnr As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",43)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbHausnr As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",51)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbFstueck As System.Windows.Controls.TabItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",54)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbGemarkung As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",55)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbgemarkung As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",65)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbFlur As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",66)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbFlur As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",72)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbZaehler As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",73)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbZaehler As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",78)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbNenner As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",79)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbNenner As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",83)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents gbEigentuemer As System.Windows.Controls.GroupBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",90)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbGrund As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",93)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnEigentuemer As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",94)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbWeitergabeVerbot As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",106)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbrechts As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",110)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbhoch As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",112)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents startKoord As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",118)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btngoogle3d As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",120)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnInfo As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\MainWindow.xaml",131)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents wbSample As System.Windows.Controls.WebBrowser
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/pgis;component/mainwindow.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\MainWindow.xaml",1)
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
            Me.dockMenu = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 2) Then
            Me.tbAdresse = CType(target,System.Windows.Controls.TabItem)
            Return
        End If
        If (connectionId = 3) Then
            Me.tbGemeinde = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 4) Then
            Me.cmbgemeinde = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",31)
            AddHandler Me.cmbgemeinde.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbgemeinde_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.tbStrasse = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 6) Then
            Me.cmbStrasse = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",36)
            AddHandler Me.cmbStrasse.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbStrasse_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 7) Then
            Me.tbHausnr = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 8) Then
            Me.cmbHausnr = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",43)
            AddHandler Me.cmbHausnr.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbHausnr_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 9) Then
            Me.tbFstueck = CType(target,System.Windows.Controls.TabItem)
            Return
        End If
        If (connectionId = 10) Then
            Me.tbGemarkung = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 11) Then
            Me.cmbgemarkung = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",61)
            AddHandler Me.cmbgemarkung.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbgemarkung_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 12) Then
            Me.tbFlur = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 13) Then
            Me.cmbFlur = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",68)
            AddHandler Me.cmbFlur.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbFlur_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 14) Then
            Me.tbZaehler = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 15) Then
            Me.cmbZaehler = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",73)
            AddHandler Me.cmbZaehler.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbZaehler_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 16) Then
            Me.tbNenner = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 17) Then
            Me.cmbNenner = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\MainWindow.xaml",81)
            AddHandler Me.cmbNenner.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbNenner_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 18) Then
            Me.gbEigentuemer = CType(target,System.Windows.Controls.GroupBox)
            Return
        End If
        If (connectionId = 19) Then
            Me.tbGrund = CType(target,System.Windows.Controls.TextBox)
            
            #ExternalSource("..\..\MainWindow.xaml",89)
            AddHandler Me.tbGrund.SelectionChanged, New System.Windows.RoutedEventHandler(AddressOf Me.tbGrund_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 20) Then
            Me.btnEigentuemer = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\MainWindow.xaml",93)
            AddHandler Me.btnEigentuemer.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnEigentuemer_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 21) Then
            Me.tbWeitergabeVerbot = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 22) Then
            Me.tbrechts = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 23) Then
            Me.tbhoch = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 24) Then
            Me.startKoord = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\MainWindow.xaml",112)
            AddHandler Me.startKoord.Click, New System.Windows.RoutedEventHandler(AddressOf Me.startKoord_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 25) Then
            Me.btngoogle3d = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\MainWindow.xaml",118)
            AddHandler Me.btngoogle3d.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btngoogle3d_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 26) Then
            Me.btnInfo = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\MainWindow.xaml",120)
            AddHandler Me.btnInfo.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnInfo_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 27) Then
            Me.wbSample = CType(target,System.Windows.Controls.WebBrowser)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
