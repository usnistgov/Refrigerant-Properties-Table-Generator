VERSION 5.00
Begin VB.Form frmdemo 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Refleak 4.0.1"
   ClientHeight    =   6960
   ClientLeft      =   2280
   ClientTop       =   1710
   ClientWidth     =   8970
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H80000008&
   HelpContextID   =   1271
   Icon            =   "demo.frx":0000
   LinkTopic       =   "Form1"
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   6960
   ScaleWidth      =   8970
   Begin VB.PictureBox Picture1 
      Height          =   975
      Left            =   3000
      Picture         =   "demo.frx":030A
      ScaleHeight     =   915
      ScaleWidth      =   2715
      TabIndex        =   11
      TabStop         =   0   'False
      Top             =   120
      Width           =   2775
   End
   Begin VB.CommandButton Command1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      Caption         =   "&OK"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3600
      TabIndex        =   6
      Top             =   6300
      WhatsThisHelpID =   250
      Width           =   1575
   End
   Begin VB.Image Image2 
      Appearance      =   0  'Flat
      BorderStyle     =   1  'Fixed Single
      Height          =   675
      Left            =   120
      Picture         =   "demo.frx":338A
      Stretch         =   -1  'True
      Top             =   120
      WhatsThisHelpID =   250
      Width           =   1530
   End
   Begin VB.Label Label11 
      Caption         =   "Gaithersburg, MD 20899"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   2160
      TabIndex        =   10
      Top             =   3075
      Width           =   2235
   End
   Begin VB.Label Label10 
      Caption         =   "National Institute of Standards and Technology"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Left            =   2175
      TabIndex        =   9
      Top             =   2835
      Width           =   3945
   End
   Begin VB.Label Label9 
      Caption         =   "Distributed by: Standard Reference Data Program"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   2160
      TabIndex        =   8
      Top             =   2595
      Width           =   5445
   End
   Begin VB.Label Label8 
      Caption         =   "NIST Standard Reference Database 73"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Left            =   2760
      TabIndex        =   7
      Top             =   1440
      Width           =   3255
   End
   Begin VB.Line Line2 
      BorderWidth     =   2
      X1              =   135
      X2              =   8775
      Y1              =   3900
      Y2              =   3885
   End
   Begin VB.Label Label6 
      Appearance      =   0  'Flat
      BackStyle       =   0  'Transparent
      Caption         =   "David A. Didion, Min Soo Kim and Piotr A. Domanski                                                    "
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   285
      Left            =   180
      TabIndex        =   5
      Top             =   3615
      WhatsThisHelpID =   250
      Width           =   4455
   End
   Begin VB.Line Line1 
      BorderWidth     =   2
      X1              =   120
      X2              =   8745
      Y1              =   5070
      Y2              =   5055
   End
   Begin VB.Label Label5 
      Appearance      =   0  'Flat
      BackStyle       =   0  'Transparent
      Caption         =   $"demo.frx":13B14
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1215
      Left            =   180
      TabIndex        =   4
      Top             =   5220
      WhatsThisHelpID =   250
      Width           =   8640
   End
   Begin VB.Label Label4 
      Appearance      =   0  'Flat
      BackStyle       =   0  'Transparent
      Caption         =   $"demo.frx":13CA0
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   1290
      Left            =   180
      TabIndex        =   3
      Top             =   4095
      WhatsThisHelpID =   250
      Width           =   8625
   End
   Begin VB.Label Label3 
      Appearance      =   0  'Flat
      BackStyle       =   0  'Transparent
      Caption         =   "Version 4.0.1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   255
      Left            =   7650
      TabIndex        =   2
      Top             =   3645
      WhatsThisHelpID =   250
      Width           =   1275
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "NIST LEAK AND RECHARGE SIMULATION PROGRAM FOR REFRIGERANT MIXTURES"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   225
      Left            =   1200
      TabIndex        =   1
      Top             =   2040
      WhatsThisHelpID =   250
      Width           =   6840
   End
   Begin VB.Label Label1 
      Appearance      =   0  'Flat
      Caption         =   "NIST REFRIGERANT MIXTURE LEAKAGE  AND RECHARGE SIMULATION PROGRAM"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   300
      Left            =   -12000
      TabIndex        =   0
      Top             =   1680
      WhatsThisHelpID =   250
      Width           =   10620
   End
End
Attribute VB_Name = "frmdemo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const SaveToolbarKey = 1
Const SaveToolbarSubKey = "MyToolbar"
Const SaveToolbarVal = "True"
Dim filename As String

Private Sub Command1_Click()
   If initialopening = True Then
      frmdemo.Hide
   Else
      Unload frmdemo
   End If
   refselected = False
   molemassfrac = "Mole Fraction"
   leak.Show
   initialopening = False
End Sub


Private Sub Form_Load()
   Dim testnum As Double
   Dim testnumstring As String
   Dim chrposnum As Integer
'*** Code added by HelpWriter ***
   Call SetAppHelp(Me.hWnd)
   '  SetAppHelp Me.hWnd
'***********************************

'exedir = CurDir
   initialopening = True
   exedir = App.path
   frmdemo.Left = 0.5 * (Screen.Width - frmdemo.Width)
   frmdemo.Top = 0.5 * (Screen.Height - frmdemo.Height)
   NewOrPre = 1
   ChDir (App.path)
   calcVQ = False
   leak.cmdCalcVQ.Enabled = False
   hrf = "DEF"
   internat = False
   testnum = 0.2
   FileNew = False
   testnumstring = CStr(testnum)
   chrposnum = InStr(1, testnumstring, ",")
   If (chrposnum > 0) Then internat = True
   leak.mnuinfo.Enabled = False
   vqfracviewed = False
   leak.cmdanal.Enabled = False
End Sub

Sub Form_Unload(Cancel As Integer)
   If leak.Visible = False And output.Visible = False And initialopening = True Then
      End
   End If
End Sub
