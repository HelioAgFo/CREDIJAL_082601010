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
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Update1 = New Interop.SAF.SAFUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cStatus_0 = New Interop.SAF.SAFCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cName_0 = New Interop.SAF.SAFMaskedText()
        Me.cCustid_0 = New Interop.SAF.SAFMaskedText()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cClave_0 = New Interop.SAF.SAFMaskedText()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cQuienAutorizo_0 = New Interop.SAF.SAFMaskedText()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cRiesgoDC_0 = New Interop.SAF.SAFCombo()
        Me.cClasifPEP_0 = New Interop.SAF.SAFCombo()
        Me.cManEfec_0 = New Interop.SAF.SAFCheck()
        Me.cParentescoPep_0 = New Interop.SAF.SAFMaskedText()
        Me.cActividadPrep_0 = New Interop.SAF.SAFMaskedText()
        Me.cDestinodC_01 = New Interop.SAF.SAFCombo()
        Me.cPaisdR_0 = New Interop.SAF.SAFMaskedText()
        Me.cNumeroSFE_0 = New Interop.SAF.SAFMaskedText()
        Me.cCriterioCdR_0 = New Interop.SAF.SAFMaskedText()
        Me.cPaisN_0 = New Interop.SAF.SAFMaskedText()
        Me.cNombrePEP_0 = New Interop.SAF.SAFMaskedText()
        Me.cDetalledCPEP_0 = New Interop.SAF.SAFMaskedText()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cMontoEfeMen_0 = New Interop.SAF.SAFFloat()
        Me.cNumeroEdMM_0 = New Interop.SAF.SAFFloat()
        Me.cMontoEstMM_0 = New Interop.SAF.SAFFloat()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cStatus_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cName_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cCustid_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cClave_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cQuienAutorizo_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cRiesgoDC_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cClasifPEP_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cManEfec_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cParentescoPep_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cActividadPrep_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cDestinodC_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cPaisdR_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cNumeroSFE_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cCriterioCdR_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cPaisN_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cNombrePEP_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cDetalledCPEP_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cMontoEfeMen_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cNumeroEdMM_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cMontoEstMM_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Enabled = True
        Me.Update1.Location = New System.Drawing.Point(220, 238)
        Me.Update1.Margin = New System.Windows.Forms.Padding(4)
        Me.Update1.Name = "Update1"
        Me.Update1.OcxState = CType(resources.GetObject("Update1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Update1.Size = New System.Drawing.Size(33, 33)
        Me.Update1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cStatus_0)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cName_0)
        Me.GroupBox1.Controls.Add(Me.cCustid_0)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cClave_0)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1335, 92)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Informacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(880, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Status"
        '
        'cStatus_0
        '
        Me.cStatus_0.Location = New System.Drawing.Point(730, 21)
        Me.cStatus_0.Name = "cStatus_0"
        Me.cStatus_0.OcxState = CType(resources.GetObject("cStatus_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cStatus_0.Size = New System.Drawing.Size(194, 24)
        Me.cStatus_0.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'cName_0
        '
        Me.cName_0.Location = New System.Drawing.Point(450, 21)
        Me.cName_0.Name = "cName_0"
        Me.cName_0.OcxState = CType(resources.GetObject("cName_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cName_0.Size = New System.Drawing.Size(194, 24)
        Me.cName_0.TabIndex = 2
        '
        'cCustid_0
        '
        Me.cCustid_0.Location = New System.Drawing.Point(63, 23)
        Me.cCustid_0.Name = "cCustid_0"
        Me.cCustid_0.OcxState = CType(resources.GetObject("cCustid_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cCustid_0.Size = New System.Drawing.Size(93, 24)
        Me.cCustid_0.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clave"
        '
        'cClave_0
        '
        Me.cClave_0.Location = New System.Drawing.Point(250, 21)
        Me.cClave_0.Name = "cClave_0"
        Me.cClave_0.OcxState = CType(resources.GetObject("cClave_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cClave_0.Size = New System.Drawing.Size(93, 24)
        Me.cClave_0.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cQuienAutorizo_0)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cRiesgoDC_0)
        Me.GroupBox2.Controls.Add(Me.cClasifPEP_0)
        Me.GroupBox2.Controls.Add(Me.cManEfec_0)
        Me.GroupBox2.Controls.Add(Me.cParentescoPep_0)
        Me.GroupBox2.Controls.Add(Me.cActividadPrep_0)
        Me.GroupBox2.Controls.Add(Me.cDestinodC_01)
        Me.GroupBox2.Controls.Add(Me.cPaisdR_0)
        Me.GroupBox2.Controls.Add(Me.cNumeroSFE_0)
        Me.GroupBox2.Controls.Add(Me.cCriterioCdR_0)
        Me.GroupBox2.Controls.Add(Me.cPaisN_0)
        Me.GroupBox2.Controls.Add(Me.cNombrePEP_0)
        Me.GroupBox2.Controls.Add(Me.cDetalledCPEP_0)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1337, 257)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PLD(Prevencion y lavado de dinero)"
        '
        'cQuienAutorizo_0
        '
        Me.cQuienAutorizo_0.Location = New System.Drawing.Point(600, 45)
        Me.cQuienAutorizo_0.Name = "cQuienAutorizo_0"
        Me.cQuienAutorizo_0.OcxState = CType(resources.GetObject("cQuienAutorizo_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cQuienAutorizo_0.Size = New System.Drawing.Size(200, 24)
        Me.cQuienAutorizo_0.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(560, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 17)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "¿Quien Autorizo?"
        '
        'cRiesgoDC_0
        '
        Me.cRiesgoDC_0.Location = New System.Drawing.Point(600, 20)
        Me.cRiesgoDC_0.Name = "cRiesgoDC_0"
        Me.cRiesgoDC_0.OcxState = CType(resources.GetObject("cRiesgoDC_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cRiesgoDC_0.Size = New System.Drawing.Size(200, 24)
        Me.cRiesgoDC_0.TabIndex = 16
        '
        'cClasifPEP_0
        '
        Me.cClasifPEP_0.Location = New System.Drawing.Point(211, 20)
        Me.cClasifPEP_0.Name = "cClasifPEP_0"
        Me.cClasifPEP_0.OcxState = CType(resources.GetObject("cClasifPEP_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cClasifPEP_0.Size = New System.Drawing.Size(200, 24)
        Me.cClasifPEP_0.TabIndex = 15
        '
        'cManEfec_0
        '
        Me.cManEfec_0.Location = New System.Drawing.Point(600, 180)
        Me.cManEfec_0.Name = "cManEfec_0"
        Me.cManEfec_0.OcxState = CType(resources.GetObject("cManEfec_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cManEfec_0.Size = New System.Drawing.Size(200, 24)
        Me.cManEfec_0.TabIndex = 14
        '
        'cParentescoPep_0
        '
        Me.cParentescoPep_0.Location = New System.Drawing.Point(600, 100)
        Me.cParentescoPep_0.Name = "cParentescoPep_0"
        Me.cParentescoPep_0.OcxState = CType(resources.GetObject("cParentescoPep_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cParentescoPep_0.Size = New System.Drawing.Size(200, 24)
        Me.cParentescoPep_0.TabIndex = 11
        '
        'cActividadPrep_0
        '
        Me.cActividadPrep_0.Location = New System.Drawing.Point(211, 95)
        Me.cActividadPrep_0.Name = "cActividadPrep_0"
        Me.cActividadPrep_0.OcxState = CType(resources.GetObject("cActividadPrep_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cActividadPrep_0.Size = New System.Drawing.Size(200, 24)
        Me.cActividadPrep_0.TabIndex = 7
        '
        'cDestinodC_01
        '
        Me.cDestinodC_01.Location = New System.Drawing.Point(1119, 23)
        Me.cDestinodC_01.Name = "cDestinodC_01"
        Me.cDestinodC_01.OcxState = CType(resources.GetObject("cDestinodC_01.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cDestinodC_01.Size = New System.Drawing.Size(200, 24)
        Me.cDestinodC_01.TabIndex = 14
        Me.cDestinodC_01.Visible = False
        '
        'cPaisdR_0
        '
        Me.cPaisdR_0.Location = New System.Drawing.Point(600, 150)
        Me.cPaisdR_0.Name = "cPaisdR_0"
        Me.cPaisdR_0.OcxState = CType(resources.GetObject("cPaisdR_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cPaisdR_0.Size = New System.Drawing.Size(200, 24)
        Me.cPaisdR_0.TabIndex = 13
        '
        'cNumeroSFE_0
        '
        Me.cNumeroSFE_0.Location = New System.Drawing.Point(600, 125)
        Me.cNumeroSFE_0.Name = "cNumeroSFE_0"
        Me.cNumeroSFE_0.OcxState = CType(resources.GetObject("cNumeroSFE_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cNumeroSFE_0.Size = New System.Drawing.Size(200, 24)
        Me.cNumeroSFE_0.TabIndex = 12
        '
        'cCriterioCdR_0
        '
        Me.cCriterioCdR_0.Location = New System.Drawing.Point(600, 75)
        Me.cCriterioCdR_0.Name = "cCriterioCdR_0"
        Me.cCriterioCdR_0.OcxState = CType(resources.GetObject("cCriterioCdR_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cCriterioCdR_0.Size = New System.Drawing.Size(200, 24)
        Me.cCriterioCdR_0.TabIndex = 10
        '
        'cPaisN_0
        '
        Me.cPaisN_0.Location = New System.Drawing.Point(211, 120)
        Me.cPaisN_0.Name = "cPaisN_0"
        Me.cPaisN_0.OcxState = CType(resources.GetObject("cPaisN_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cPaisN_0.Size = New System.Drawing.Size(201, 24)
        Me.cPaisN_0.TabIndex = 8
        '
        'cNombrePEP_0
        '
        Me.cNombrePEP_0.Location = New System.Drawing.Point(211, 70)
        Me.cNombrePEP_0.Name = "cNombrePEP_0"
        Me.cNombrePEP_0.OcxState = CType(resources.GetObject("cNombrePEP_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cNombrePEP_0.Size = New System.Drawing.Size(200, 24)
        Me.cNombrePEP_0.TabIndex = 6
        '
        'cDetalledCPEP_0
        '
        Me.cDetalledCPEP_0.Location = New System.Drawing.Point(211, 45)
        Me.cDetalledCPEP_0.Name = "cDetalledCPEP_0"
        Me.cDetalledCPEP_0.OcxState = CType(resources.GetObject("cDetalledCPEP_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cDetalledCPEP_0.Size = New System.Drawing.Size(200, 24)
        Me.cDetalledCPEP_0.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(560, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 17)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Manejo del Efectivo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(560, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 17)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Pais de Residencia "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(560, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Numero Serie Firm Elect"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(560, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Parentesco PEP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pais de Nacimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(560, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Criterio Clas Riesgo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Actividad Preponderante"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(560, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Riesgos del cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nombre PEP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Detalle de cargo PEP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Clasificacion PEP"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cMontoEfeMen_0)
        Me.GroupBox3.Controls.Add(Me.cNumeroEdMM_0)
        Me.GroupBox3.Controls.Add(Me.cMontoEstMM_0)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 373)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1335, 151)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Perfil Transaccional"
        '
        'cMontoEfeMen_0
        '
        Me.cMontoEfeMen_0.Location = New System.Drawing.Point(322, 70)
        Me.cMontoEfeMen_0.Name = "cMontoEfeMen_0"
        Me.cMontoEfeMen_0.OcxState = CType(resources.GetObject("cMontoEfeMen_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cMontoEfeMen_0.Size = New System.Drawing.Size(261, 24)
        Me.cMontoEfeMen_0.TabIndex = 17
        '
        'cNumeroEdMM_0
        '
        Me.cNumeroEdMM_0.Location = New System.Drawing.Point(322, 43)
        Me.cNumeroEdMM_0.Name = "cNumeroEdMM_0"
        Me.cNumeroEdMM_0.OcxState = CType(resources.GetObject("cNumeroEdMM_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cNumeroEdMM_0.Size = New System.Drawing.Size(261, 24)
        Me.cNumeroEdMM_0.TabIndex = 16
        '
        'cMontoEstMM_0
        '
        Me.cMontoEstMM_0.Location = New System.Drawing.Point(322, 15)
        Me.cMontoEstMM_0.Name = "cMontoEstMM_0"
        Me.cMontoEstMM_0.OcxState = CType(resources.GetObject("cMontoEstMM_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cMontoEstMM_0.Size = New System.Drawing.Size(261, 24)
        Me.cMontoEstMM_0.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Monto efectivo mensual"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(293, 17)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Numero estimado de movimientos mensuales"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(282, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Monto estimado de movimientos mensuales"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1361, 536)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Update1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "PLD Cliente (08.260.10)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cStatus_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cName_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cCustid_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cClave_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cQuienAutorizo_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cRiesgoDC_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cClasifPEP_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cManEfec_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cParentescoPep_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cActividadPrep_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cDestinodC_01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cPaisdR_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cNumeroSFE_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cCriterioCdR_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cPaisN_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cNombrePEP_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cDetalledCPEP_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cMontoEfeMen_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cNumeroEdMM_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cMontoEstMM_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Update1 As Interop.SAF.SAFUpdate
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cCustid_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cClave_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cName_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cStatus_0 As Interop.SAF.SAFCombo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cDetalledCPEP_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cNombrePEP_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cPaisN_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cCriterioCdR_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cNumeroSFE_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cPaisdR_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cDestinodC_01 As Interop.SAF.SAFCombo
    Friend WithEvents cMontoEstMM_0 As Interop.SAF.SAFFloat
    Friend WithEvents cNumeroEdMM_0 As Interop.SAF.SAFFloat
    Friend WithEvents cMontoEfeMen_0 As Interop.SAF.SAFFloat
    Friend WithEvents cActividadPrep_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cParentescoPep_0 As Interop.SAF.SAFMaskedText
    Friend WithEvents cManEfec_0 As Interop.SAF.SAFCheck
    Friend WithEvents cClasifPEP_0 As Interop.SAF.SAFCombo
    Friend WithEvents cRiesgoDC_0 As Interop.SAF.SAFCombo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cQuienAutorizo_0 As Interop.SAF.SAFMaskedText


End Class
