'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
Option Explicit On
Option Strict Off
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
	End Property

    Dim RiesgoAnterior As String
    Dim FechaAnterior As String
    Dim UsuarioAnterior As String

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        Call ApplInit()
        Call Init_xPld(LEVEL0, True)


        Call ScreenInit()

        Call InitBuffer()

        With Timer1
            .Interval = 10000
            .Enabled = True
            .Start()
        End With



    End Sub

    Private Sub InitBuffer()
        With bxPld
            .ActividadPrep = " "
            .ClasifPEP = " "
            .Clave = ""
            .CriterioCdR = " "
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            ' .CustId = " "
            .DestinodC = " "
            .DetalledCPEP = " "
            .EditarcPLD = " "
            .ManejoEf = 0
            .MontoEfeMen = 0
            .MontoEstMM = 0
            .Name = ""
            .NombrePEP = " "
            .NumeroEdMM = 0
            .NumeroSFE = " "
            .PaisdN = " "
            .PaisdR = " "
            .ParentescoPep = " "
            .RiesgoDC = " "
            .Status = " "
            .Lupd_DateTime = bpes.Today
            .Lupd_Prog = bpes.ScrnNbr
            .Lupd_User = bpes.UserId
            .s4Future01 = " "
            .s4future02 = " "
            .s4Future03 = "0 "
            .s4Future04 = "0 "
            .s4Future05 = "0 "
            .s4Future06 = "0 "
            .s4Future07 = 0
            .s4Future08 = 0
            .s4Future09 = 0
            .s4Future10 = 0
            .s4future11 = " "
            .s4Future12 = " "
            .User1 = " "
            .User2 = " "
            .User3 = 0
            .User4 = 0
            .User5 = " "
            .User6 = " "
            .User7 = 0
            .User8 = 0
        End With

    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub cCustid_0_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cCustid_0.ChkEvent
        'Stop
        'bxPld.Name = ""
        'bCustomer = nCustomer
        serr = PVChkFetch1(PNULL, CSR_xPld, ChkStrg, bCustomer)
        If serr = NOTFOUND Then
            RetVal = NoAutoChk
        End If

        Dim Query As String
        Query = "Select * from xpld where custid = " + SParm(Trim(ChkStrg))
        Call sql(c1, Query)
        serr1 = SFetch1(c1, bxPld)
        If serr1 = NOTFOUND Then
            RetVal = NoAutoChk

            With bxPld
                .ActividadPrep = " "
                .ClasifPEP = " "
                .Clave = ""
                .CriterioCdR = " "
                .Crtd_DateTime = bpes.Today
                .Crtd_Prog = bpes.ScrnNbr
                .Crtd_User = bpes.UserId
                ' .CustId = " "
                .DestinodC = " "
                .DetalledCPEP = " "
                .EditarcPLD = " "
                .ManejoEf = 0
                .MontoEfeMen = 0
                .MontoEstMM = 0
                .Name = ""
                .NombrePEP = " "
                .NumeroEdMM = 0
                .NumeroSFE = " "
                .PaisdN = " "
                .PaisdR = " "
                .ParentescoPep = " "
                .RiesgoDC = "Riesgo Bajo"
                .Status = "Acreditado"
                .Lupd_DateTime = bpes.Today
                .Lupd_Prog = bpes.ScrnNbr
                .Lupd_User = bpes.UserId
                .s4Future01 = " "
                .s4future02 = " "
                .s4Future03 = "0 "
                .s4Future04 = "0 "
                .s4Future05 = "0 "
                .s4Future06 = "0 "
                .s4Future07 = 0
                .s4Future08 = 0
                .s4Future09 = 0
                .s4Future10 = 0
                .s4future11 = " "
                .s4Future12 = " "
                .User1 = " "
                .User2 = " "
                .User3 = 0
                .User4 = 0
                .User5 = " "
                .User6 = " "
                .User7 = 0
                .User8 = 0
            End With

        End If
        cNombrePEP_0.Enabled = "False"
        cParentescoPep_0.Enabled = "False"
        'If serr1 <> NOTFOUND Then
        '    With bxPld
        '        .ActividadPrep = RTrim(bxPld2.ActividadPrep)
        '        .ClasifPEP = RTrim(bxPld2.ClasifPEP)
        '        .Clave = RTrim(bxPld2.Clave)
        '        .CriterioCdR = RTrim(bxPld2.CriterioCdR)
        '        .Crtd_DateTime = RTrim(bxPld2.Crtd_DateTime)
        '        .Crtd_Prog = RTrim(bxPld2.Crtd_Prog)
        '        .Crtd_User = RTrim(bxPld2.Crtd_User)
        '        '.CustId = RTrim(bxPld2.ActividadPrep)
        '        .DestinodC = RTrim(bxPld2.DestinodC)
        '        .DetalledCPEP = RTrim(bxPld2.DetalledCPEP)
        '        .EditarcPLD = RTrim(bxPld2.EditarcPLD)
        '        .ManejoEf = RTrim(bxPld2.ManejoEf)
        '        .MontoEfeMen = RTrim(bxPld2.MontoEfeMen)
        '        .MontoEstMM = RTrim(bxPld2.MontoEstMM)
        '        .Name = RTrim(bxPld2.Name)
        '        .NombrePEP = RTrim(bxPld2.NombrePEP)
        '        .NumeroEdMM = RTrim(bxPld2.NumeroEdMM)
        '        .NumeroSFE = RTrim(bxPld2.NumeroSFE)
        '        .PaisdN = RTrim(bxPld2.PaisdN)
        '        .PaisdR = RTrim(bxPld2.PaisdR)
        '        .ParentescoPep = RTrim(bxPld2.ParentescoPep)
        '        .RiesgoDC = RTrim(bxPld2.RiesgoDC)
        '        .Status = RTrim(bxPld2.Status)
        '        .Lupd_DateTime = RTrim(bxPld2.Lupd_DateTime)
        '        .Lupd_Prog = RTrim(bxPld2.Lupd_Prog)
        '        .Lupd_User = RTrim(bxPld2.Lupd_User)
        '        .s4Future01 = RTrim(bxPld2.s4Future01)
        '        .s4future02 = RTrim(bxPld2.s4future02)
        '        .s4Future03 = RTrim(bxPld2.s4Future03)
        '        .s4Future04 = RTrim(bxPld2.s4Future04)
        '        .s4Future05 = RTrim(bxPld2.s4Future05)
        '        .s4Future06 = RTrim(bxPld2.s4Future06)
        '        .s4Future07 = RTrim(bxPld2.s4Future07)
        '        .s4Future08 = RTrim(bxPld2.s4Future08)
        '        .s4Future09 = RTrim(bxPld2.s4Future09)
        '        .s4Future10 = RTrim(bxPld2.s4Future10)
        '        .s4future11 = RTrim(bxPld2.s4future11)
        '        .s4Future12 = RTrim(bxPld2.s4Future12)
        '        .User1 = RTrim(bxPld2.User1)
        '        .User2 = RTrim(bxPld2.User2)
        '        .User3 = RTrim(bxPld2.User3)
        '        .User4 = RTrim(bxPld2.User4)
        '        .User5 = RTrim(bxPld2.User5)
        '        .User6 = RTrim(bxPld2.User6)
        '        .User7 = RTrim(bxPld2.User7)
        '        .User8 = RTrim(bxPld2.User8)
        '    End With
        'Else
        '    bxPld.Name = ""
        'End If

    End Sub

    Private Sub cClasifPEP_0_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short)

    End Sub





    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Update1_UpdateEvent(Level As Short, InsertFlg As Short, LevelsDone As Short, LevelsLeft As Short, ByRef RetVal As Short) Handles Update1.UpdateEvent
        'Stop
        Dim Query As String

        If Level = LEVEL0 Then
            Query = "Select * from xPld where custid = " + SParm(RTrim(bxPld.CustId))
            Call sql(CSR_xPld, Query)
            serr1 = SFetch1(CSR_xPld, bxPld2)

            If serr1 = NOTFOUND Then
                Try
                    Call TranBeg(True)
                    Call SInsert1(CSR_xPld, "xPld", bxPld) 'Inserta
                Catch ex As Exception
                    TranAbort()
                Finally
                    TranEnd()
                End Try
            Else
                Try
                    Call TranBeg(True)
                    Call SUpdate1(CSR_xPld, "xPld", bxPld) 'Actualiza
                Catch ex As Exception
                    TranAbort()
                Finally
                    TranEnd()
                End Try
            End If
            bxPld2 = nxPld
            RetVal = NoAction

        End If
    End Sub

    Private Sub cClasifPEP_0_ChkEvent_1(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cClasifPEP_0.ChkEvent

        If (ChkStrg = "Ex PEP") Then
            SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            SetObjectValue(cCriterioCdR_0, "Ex PEP")
            cNombrePEP_0.Enabled = "False"
            cParentescoPep_0.Enabled = "False"
        End If
        If (ChkStrg = "Ex PEP Extranjero") Then
            SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            SetObjectValue(cCriterioCdR_0, "Ex PEP Extranjero")
            cNombrePEP_0.Enabled = "False"
            cParentescoPep_0.Enabled = "False"
        End If

        If (ChkStrg = "No PEP") Then
            SetObjectValue(cRiesgoDC_0, "Riesgo Bajo")
            SetObjectValue(cCriterioCdR_0, " ")
            cNombrePEP_0.Enabled = "False"
            cParentescoPep_0.Enabled = "False"
        End If

        If (ChkStrg = "PEP") Then
            SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            SetObjectValue(cCriterioCdR_0, "PEP")
            cNombrePEP_0.Enabled = "False"
            cParentescoPep_0.Enabled = "False"
        End If

        If (ChkStrg = "PEP Extranjero") Then
            SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            SetObjectValue(cCriterioCdR_0, "PEP Extranjero")
            cNombrePEP_0.Enabled = "False"
            cParentescoPep_0.Enabled = "False"
        End If

        If (ChkStrg = "Relacionado PEP") Then
            SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            SetObjectValue(cCriterioCdR_0, "PERSONA RELACIONADA A PEP")
            cNombrePEP_0.Enabled = "True"
            cParentescoPep_0.Enabled = "True"
        End If

    End Sub

    Private Sub cPaisN_0_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cPaisN_0.ChkEvent
        Dim Query As String
        Dim Pais As String
        Pais = ChkStrg
        Query = "select * from xnew_paisbase where new_name = " + SParm(RTrim(Pais))
        Call sql(c1, Query)
        serr1 = SFetch1(c1, bxnew_paisBase)
        If serr1 <> NOTFOUND Then
            If RTrim(bxnew_paisBase.new_RegistroPLD) = "AR" Then
                SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            End If
            If RTrim(bxnew_paisBase.new_RegistroPLD) = "BR" Then
                SetObjectValue(cRiesgoDC_0, "Riesgo Bajo")
            End If
        End If
    End Sub

    Private Sub cPaisdR_0_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cPaisdR_0.ChkEvent
        Dim Query As String
        Dim Pais As String
        Pais = ChkStrg
        Query = "select * from xnew_paisbase where new_name = " + SParm(RTrim(Pais))
        Call sql(c1, Query)
        serr1 = SFetch1(c1, bxnew_paisBase)
        If serr1 <> NOTFOUND Then
            If RTrim(bxnew_paisBase.new_RegistroPLD) = "AR" Then
                SetObjectValue(cRiesgoDC_0, "Riesgo Alto")
            End If
            If RTrim(bxnew_paisBase.new_RegistroPLD) = "BR" Then
                SetObjectValue(cRiesgoDC_0, "Riesgo Bajo")
            End If
        End If
    End Sub

    Private Sub cRiesgoDC_0_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cRiesgoDC_0.ChkEvent
        'Stop
        RiesgoAnterior = bxPld.RiesgoDC
        FechaAnterior = bxPld.Crtd_DateTime
        UsuarioAnterior = bxPld.Crtd_User
        'SetProps("xPedido", PROP_BLANKERR, False)
        bxPld.User1 = " "
        SetObjectValue(cQuienAutorizo_0, " ")
        cQuienAutorizo_0.Blankerr = "True"
        RetVal = ErrNoMess


    End Sub


End Class
