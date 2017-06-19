'*****************************************************************************
' <Copyright File='xnew_paisbase.sdo.vb' Company='JanuSanthosh Inc'> 
' Dynamics SL - DH File Creation
' Created by D.Santhosh - SL Consultant 
' </Copyright> 
'*****************************************************************************
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxnew_paisbase
    Public Class xnew_paisbase
        Inherits SolomonDataObject
        < _
        DataBinding(PropertyIndex:=0) _
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
        DataBinding(PropertyIndex:=1, StringSize:=8) _
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
        DataBinding(PropertyIndex:=2, StringSize:=10) _
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
        DataBinding(PropertyIndex:=3, StringSize:=30) _
        > _
        Public Property S4Future01() As String
            Get
                Return Me.GetPropertyValue("S4Future01")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future01", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=4, StringSize:=30) _
        > _
        Public Property S4Future02() As String
            Get
                Return Me.GetPropertyValue("S4Future02")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future02", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=5) _
        > _
        Public Property S4Future03() As Double
            Get
                Return Me.GetPropertyValue("S4Future03")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future03", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=6) _
        > _
        Public Property S4Future04() As Double
            Get
                Return Me.GetPropertyValue("S4Future04")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future04", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=7) _
        > _
        Public Property S4Future05() As Double
            Get
                Return Me.GetPropertyValue("S4Future05")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future05", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=8) _
        > _
        Public Property S4Future06() As Double
            Get
                Return Me.GetPropertyValue("S4Future06")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future06", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=9) _
        > _
        Public Property S4Future07() As Integer
            Get
                Return Me.GetPropertyValue("S4Future07")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future07", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=10) _
        > _
        Public Property S4Future08() As Integer
            Get
                Return Me.GetPropertyValue("S4Future08")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future08", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=11) _
        > _
        Public Property S4Future09() As Integer
            Get
                Return Me.GetPropertyValue("S4Future09")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future09", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=12) _
        > _
        Public Property S4Future10() As Integer
            Get
                Return Me.GetPropertyValue("S4Future10")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future10", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=13, StringSize:=10) _
        > _
        Public Property S4Future11() As String
            Get
                Return Me.GetPropertyValue("S4Future11")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future11", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=14, StringSize:=10) _
        > _
        Public Property S4Future12() As String
            Get
                Return Me.GetPropertyValue("S4Future12")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future12", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=15) _
        > _
        Public Property LUpd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("LUpd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("LUpd_DateTime", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=16, StringSize:=8) _
        > _
        Public Property LUpd_Prog() As String
            Get
                Return Me.GetPropertyValue("LUpd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LUpd_Prog", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=17, StringSize:=10) _
        > _
        Public Property LUpd_User() As String
            Get
                Return Me.GetPropertyValue("LUpd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LUpd_User", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=18, StringSize:=100) _
        > _
        Public Property new_name() As String
            Get
                Return Me.GetPropertyValue("new_name")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("new_name", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=19, StringSize:=5) _
        > _
        Public Property new_IDPais() As String
            Get
                Return Me.GetPropertyValue("new_IDPais")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("new_IDPais", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=20, StringSize:=4) _
        > _
        Public Property new_RegistroPLD() As String
            Get
                Return Me.GetPropertyValue("new_RegistroPLD")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("new_RegistroPLD", setval)
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

    End Class
    Public bxnew_paisBase As xnew_paisBase = New xnew_paisBase, nxnew_paisBase As xnew_paisBase = New xnew_paisBase

    Public CSR_xnew_paisBase As Short
    Public Sub Init_xnew_paisBase(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bxnew_paisBase", bxnew_paisBase, nxnew_paisBase)
        If x_Cursor = True Then
            Call SqlCursorEx(CSR_xnew_paisBase, x_Level, "CSR_xnew_paisBase", "xnew_paisBase", "xnew_paisBase")
        End If
    End Sub

End Module
