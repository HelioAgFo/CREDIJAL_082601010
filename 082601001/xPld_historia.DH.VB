'*****************************************************************************
' <Copyright File='xpld_historia.sdo.vb' Company='JanuSanthosh Inc'> 
' Dynamics SL - DH File Creation
' Created by D.Santhosh - SL Consultant 
' </Copyright> 
'*****************************************************************************
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxpld_historia
    Public Class xpld_historia
        Inherits SolomonDataObject
        < _
        DataBinding(PropertyIndex:=0, StringSize:=50) _
        > _
        Public Property Autorizo() As String
            Get
                Return Me.GetPropertyValue("Autorizo")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Autorizo", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=1) _
        > _
        Public Property Crtd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("Crtd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("Crtd_DateTime", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=2, StringSize:=10) _
        > _
        Public Property Crtd_Prog() As String
            Get
                Return Me.GetPropertyValue("Crtd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_Prog", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=3, StringSize:=10) _
        > _
        Public Property Crtd_User() As String
            Get
                Return Me.GetPropertyValue("Crtd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_User", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=4, StringSize:=15) _
        > _
        Public Property CustId() As String
            Get
                Return Me.GetPropertyValue("CustId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CustId", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=5) _
        > _
        Public Property Lupd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("Lupd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("Lupd_DateTime", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=6, StringSize:=8) _
        > _
        Public Property Lupd_Prog() As String
            Get
                Return Me.GetPropertyValue("Lupd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Lupd_Prog", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=7, StringSize:=10) _
        > _
        Public Property Lupd_User() As String
            Get
                Return Me.GetPropertyValue("Lupd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Lupd_User", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=8, StringSize:=30) _
        > _
        Public Property s4Future01() As String
            Get
                Return Me.GetPropertyValue("s4Future01")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4Future01", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=9, StringSize:=30) _
        > _
        Public Property s4future02() As String
            Get
                Return Me.GetPropertyValue("s4future02")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4future02", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=10) _
        > _
        Public Property s4Future03() As Double
            Get
                Return Me.GetPropertyValue("s4Future03")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future03", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=11) _
        > _
        Public Property s4Future04() As Double
            Get
                Return Me.GetPropertyValue("s4Future04")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future04", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=12) _
        > _
        Public Property s4Future05() As Double
            Get
                Return Me.GetPropertyValue("s4Future05")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future05", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=13) _
        > _
        Public Property s4Future06() As Double
            Get
                Return Me.GetPropertyValue("s4Future06")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future06", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=14) _
        > _
        Public Property s4Future07() As Integer
            Get
                Return Me.GetPropertyValue("s4Future07")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future07", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=15) _
        > _
        Public Property s4Future08() As Integer
            Get
                Return Me.GetPropertyValue("s4Future08")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future08", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=16) _
        > _
        Public Property s4Future09() As Integer
            Get
                Return Me.GetPropertyValue("s4Future09")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future09", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=17) _
        > _
        Public Property s4Future10() As Integer
            Get
                Return Me.GetPropertyValue("s4Future10")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future10", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=18, StringSize:=10) _
        > _
        Public Property s4future11() As String
            Get
                Return Me.GetPropertyValue("s4future11")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4future11", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=19, StringSize:=10) _
        > _
        Public Property s4Future12() As String
            Get
                Return Me.GetPropertyValue("s4Future12")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4Future12", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=20, StringSize:=15) _
        > _
        Public Property TipodeRiesgo() As String
            Get
                Return Me.GetPropertyValue("TipodeRiesgo")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TipodeRiesgo", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=21, StringSize:=30) _
        > _
        Public Property User1() As String
            Get
                Return Me.GetPropertyValue("User1")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User1", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=22, StringSize:=30) _
        > _
        Public Property User2() As String
            Get
                Return Me.GetPropertyValue("User2")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User2", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=23) _
        > _
        Public Property User3() As Double
            Get
                Return Me.GetPropertyValue("User3")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("User3", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=24) _
        > _
        Public Property User4() As Double
            Get
                Return Me.GetPropertyValue("User4")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("User4", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=25, StringSize:=10) _
        > _
        Public Property User5() As String
            Get
                Return Me.GetPropertyValue("User5")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User5", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=26, StringSize:=10) _
        > _
        Public Property User6() As String
            Get
                Return Me.GetPropertyValue("User6")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User6", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=27) _
        > _
        Public Property User7() As Integer
            Get
                Return Me.GetPropertyValue("User7")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User7", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=28) _
        > _
        Public Property User8() As Integer
            Get
                Return Me.GetPropertyValue("User8")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User8", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=29) _
        > _
        Public Property xpldHistoriaId() As Integer
            Get
                Return Me.GetPropertyValue("xpldHistoriaId")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("xpldHistoriaId", setval)
            End Set
        End Property

    End Class
    Public bxPld_historia As xPld_historia = New xPld_historia, nxPld_historia As xPld_historia = New xPld_historia

    Public CSR_xPld_historia As Short
    Public Sub Init_xPld_historia(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bxPld_historia", bxPld_historia, nxPld_historia)
        If x_Cursor = True Then
            Call SqlCursorEx(CSR_xPld_historia, x_Level, "CSR_xPld_historia", "xPld_historia", "xPld_historia")
        End If
    End Sub

End Module
