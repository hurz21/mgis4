﻿#ExternalChecksum("..\..\..\..\sendEmail\winSendEmail.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","F7054476CAB3CBD0FA619875CABF8C3418779D3B5AB4635D99E483E54F7F1C5B")
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

Imports mgis
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
'''winSendEmail
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class winSendEmail
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents spADsuche As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbfilter As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",22)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnsuchen As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbEmails As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",37)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbEmailszuletzt As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",45)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents spParadigma As System.Windows.Controls.StackPanel
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",48)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmbEmailsParadigma As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",58)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbReceiver As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",60)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnClearEliste As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",67)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbBetreff As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",71)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents tbbody As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",75)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents rbPNGmail As System.Windows.Controls.RadioButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",76)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents rbPDFmail As System.Windows.Controls.RadioButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",80)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnabbruch As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",81)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnsend As System.Windows.Controls.Button
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/mgisNT;component/sendemail/winsendemail.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",1)
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
            Me.spADsuche = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 2) Then
            Me.tbfilter = CType(target,System.Windows.Controls.TextBox)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",21)
            AddHandler Me.tbfilter.TextChanged, New System.Windows.Controls.TextChangedEventHandler(AddressOf Me.tbfilter_TextChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.btnsuchen = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",22)
            AddHandler Me.btnsuchen.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnsuchen_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.cmbEmails = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",24)
            AddHandler Me.cmbEmails.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cbEmails_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.cmbEmailszuletzt = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",37)
            AddHandler Me.cmbEmailszuletzt.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbEmailszuletzt_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.spParadigma = CType(target,System.Windows.Controls.StackPanel)
            Return
        End If
        If (connectionId = 7) Then
            Me.cmbEmailsParadigma = CType(target,System.Windows.Controls.ComboBox)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",48)
            AddHandler Me.cmbEmailsParadigma.SelectionChanged, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf Me.cmbEmailsParadigma_SelectionChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 8) Then
            Me.tbReceiver = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 9) Then
            Me.btnClearEliste = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",60)
            AddHandler Me.btnClearEliste.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnClearEliste_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 10) Then
            Me.tbBetreff = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 11) Then
            Me.tbbody = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 12) Then
            Me.rbPNGmail = CType(target,System.Windows.Controls.RadioButton)
            Return
        End If
        If (connectionId = 13) Then
            Me.rbPDFmail = CType(target,System.Windows.Controls.RadioButton)
            Return
        End If
        If (connectionId = 14) Then
            Me.btnabbruch = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",80)
            AddHandler Me.btnabbruch.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnabbruch_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 15) Then
            Me.btnsend = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\sendEmail\winSendEmail.xaml",81)
            AddHandler Me.btnsend.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnsend_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
