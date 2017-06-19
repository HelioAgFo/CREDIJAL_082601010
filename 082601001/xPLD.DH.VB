'*****************************************************************************
' <Copyright File='xPLD.sdo.vb' Company='JanuSanthosh Inc'> 
' Dynamics SL - DH File Creation
' Created by D.Santhosh - SL Consultant 
' </Copyright> 
'*****************************************************************************
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxPLD
    Public Class xPLD
        Inherits SolomonDataObject
        < _
        DataBinding(PropertyIndex:=0, StringSize:=200) _
        > _
        Public Property ActividadPrep() As String
            Get
                Return Me.GetPropertyValue("ActividadPrep")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ActividadPrep", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=1, StringSize:=20) _
        > _
        Public Property ClasifPEP() As String
            Get
                Return Me.GetPropertyValue("ClasifPEP")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ClasifPEP", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=2, StringSize:=15) _
        > _
        Public Property Clave() As String
            Get
                Return Me.GetPropertyValue("Clave")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Clave", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=3, StringSize:=50) _
        > _
        Public Property CriterioCdR() As String
            Get
                Return Me.GetPropertyValue("CriterioCdR")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CriterioCdR", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=4) _
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
        DataBinding(PropertyIndex:=5, StringSize:=10) _
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
        DataBinding(PropertyIndex:=6, StringSize:=10) _
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
        DataBinding(PropertyIndex:=7, StringSize:=15) _
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
        DataBinding(PropertyIndex:=8, StringSize:=20) _
        > _
        Public Property DestinodC() As String
            Get
                Return Me.GetPropertyValue("DestinodC")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DestinodC", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=9, StringSize:=50) _
        > _
        Public Property DetalledCPEP() As String
            Get
                Return Me.GetPropertyValue("DetalledCPEP")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DetalledCPEP", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=10, StringSize:=1) _
        > _
        Public Property EditarcPLD() As String
            Get
                Return Me.GetPropertyValue("EditarcPLD")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("EditarcPLD", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=11) _
        > _
        Public Property ManejoEf() As Double
            Get
                Return Me.GetPropertyValue("ManejoEf")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("ManejoEf", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=12) _
        > _
        Public Property MontoEfeMen() As Double
            Get
                Return Me.GetPropertyValue("MontoEfeMen")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("MontoEfeMen", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=13) _
        > _
        Public Property MontoEstMM() As Double
            Get
                Return Me.GetPropertyValue("MontoEstMM")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("MontoEstMM", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=14, StringSize:=30) _
        > _
        Public Property Name() As String
            Get
                Return Me.GetPropertyValue("Name")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Name", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=15, StringSize:=20) _
        > _
        Public Property NombrePEP() As String
            Get
                Return Me.GetPropertyValue("NombrePEP")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("NombrePEP", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=16) _
        > _
        Public Property NumeroEdMM() As Double
            Get
                Return Me.GetPropertyValue("NumeroEdMM")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("NumeroEdMM", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=17, StringSize:=20) _
        > _
        Public Property NumeroSFE() As String
            Get
                Return Me.GetPropertyValue("NumeroSFE")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("NumeroSFE", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=18, StringSize:=50) _
        > _
        Public Property PaisdN() As String
            Get
                Return Me.GetPropertyValue("PaisdN")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("PaisdN", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=19, StringSize:=50) _
        > _
        Public Property PaisdR() As String
            Get
                Return Me.GetPropertyValue("PaisdR")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("PaisdR", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=20, StringSize:=20) _
        > _
        Public Property ParentescoPep() As String
            Get
                Return Me.GetPropertyValue("ParentescoPep")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ParentescoPep", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=21, StringSize:=20) _
        > _
        Public Property RiesgoDC() As String
            Get
                Return Me.GetPropertyValue("RiesgoDC")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("RiesgoDC", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=22, StringSize:=20) _
        > _
        Public Property Status() As String
            Get
                Return Me.GetPropertyValue("Status")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Status", setval)
            End Set
        End Property

        < _
        DataBinding(PropertyIndex:=23) _
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
        DataBinding(PropertyIndex:=24, StringSize:=8) _
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
        DataBinding(PropertyIndex:=25, StringSize:=10) _
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
        DataBinding(PropertyIndex:=26, StringSize:=30) _
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
        DataBinding(PropertyIndex:=27, StringSize:=30) _
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
        DataBinding(PropertyIndex:=28) _
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
        DataBinding(PropertyIndex:=29) _
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
        DataBinding(PropertyIndex:=30) _
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
        DataBinding(PropertyIndex:=31) _
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
        DataBinding(PropertyIndex:=32) _
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
        DataBinding(PropertyIndex:=33) _
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
        DataBinding(PropertyIndex:=34) _
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
        DataBinding(PropertyIndex:=35) _
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
        DataBinding(PropertyIndex:=36, StringSize:=10) _
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
        DataBinding(PropertyIndex:=37, StringSize:=10) _
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
        DataBinding(PropertyIndex:=38, StringSize:=30) _
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
        DataBinding(PropertyIndex:=39, StringSize:=30) _
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
        DataBinding(PropertyIndex:=40) _
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
        DataBinding(PropertyIndex:=41) _
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
        DataBinding(PropertyIndex:=42, StringSize:=10) _
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
        DataBinding(PropertyIndex:=43, StringSize:=10) _
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
        DataBinding(PropertyIndex:=44) _
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
        DataBinding(PropertyIndex:=45) _
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
        DataBinding(PropertyIndex:=46, StringSize:=10) _
        > _
        Public Property Zip() As String
            Get
                Return Me.GetPropertyValue("Zip")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Zip", setval)
            End Set
        End Property

    End Class
    Public bxPld As xPLD = New xPLD, nxPld As xPLD = New xPLD, bxPld2 As xPLD = New xPLD

    Public CSR_xPld As Short
    Public Sub Init_xPld(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bxPld", bxPld, nxPld)
        If x_Cursor = True Then
            Call SqlCursorEx(CSR_xPld, x_Level, "CSR_xPld", "xPld", "xPld")
        End If
    End Sub

End Module
