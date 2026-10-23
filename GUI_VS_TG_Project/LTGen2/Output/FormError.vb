Imports System.IO
Public Class FormError
    Friend FormCalling As FormMain
    Private StringRed As String = ""
    Private ArrayLines() As String
    Private DiffButtonBottom As Integer
    Private DiffTextBotton As Integer
    Private IntStart As Integer
    Private PathTextFile As String = ""
    Private Sub FormError_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the positon of the buttons and the text respect to the bottom to use it to resize
        DiffButtonBottom = Me.DisplayRectangle.Bottom - Me.CopyBut.Location.Y
        DiffTextBotton = Me.DisplayRectangle.Bottom - Me.ErrorText.Bounds.Bottom
        Try
            Cursor = Windows.Forms.Cursors.WaitCursor

            'YYJ[2020.1119]ltgen2: make a portable version - s
            Dim FileErrorPath As String = ApplicationFolder & "\ERREF.txt"
            'Dim FileErrorPath As String = UserApplicationFolder & "\ERREF.txt"
            'YYJ[2020.1119]ltgen2: make a portable version - e

            Dim StreamReader As New StreamReader(FileErrorPath)
            StringRed = StreamReader.ReadToEnd
            ArrayLines = File.ReadAllLines(FileErrorPath)
            'Me.ErrorText.Text = StringRed
            StringRed = String.Empty
            Dim FontPark As Font = Me.ErrorText.Font
            For i As Integer = 0 To Me.ArrayLines.Length - 1
                ArrayLines(i) = RTrim(ArrayLines(i))
            Next i
            For i As Integer = 0 To Me.ArrayLines.Length - 1
                Me.ErrorText.Text = Me.ErrorText.Text & vbCrLf & ArrayLines(i)
                If i >= 100 And ArrayLines(i) = "" Then Exit For
            Next i
            Me.ErrorText.Font = FontPark
            Me.ActiveControl = Me.CopyBut
            StreamReader.Close()
            Cursor = Windows.Forms.Cursors.Default
        Catch ex As FileNotFoundException
            MsgBox("The file that you are trying to open has not been found.", vbOKOnly)
        Catch ex As FileLoadException
            MsgBox("The file that you are trying to open cannot be load.", vbOKOnly)
        Catch ex As Exception
            MsgBox("An unknown error occurred. Please report it to piotr.domanski@nist.gov.", vbOKOnly)
        End Try
    End Sub
    Private Sub CopyBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyBut.Click
        Clipboard.SetText(Me.ErrorText.Text)
    End Sub
    Friend Sub PrintBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBut.Click
        Try
            Me.PrintDialog1.UseEXDialog = True
            Dim IndexFile As Integer = 0
            If Me.PrintDialog1.ShowDialog() = DialogResult.OK Then
                ' Me.PrintDialog1.Document = Me.PrintDoc
                Me.PrintDoc.DefaultPageSettings.Margins.Top = 50
                Me.PrintDoc.DefaultPageSettings.Margins.Bottom = 50
                Me.PrintDoc.DefaultPageSettings.Margins.Left = 50
                Me.PrintDoc.DefaultPageSettings.Margins.Right = 50
                Me.PrintDoc.Print()
            End If
        Catch ex As FieldAccessException
            MsgBox("The file is open. Please close the file and try again or specify a different file name.", vbOKOnly) : Me.Close()
        Catch ex As SystemException
            MsgBox("A system error occurred. The file could be opened, please close the file and try again or specify a different file name." _
                   & vbCrLf & "Otherwise try to push save and then to print from the text file", vbOKOnly) : Me.Close()
        Catch ex As Exception
            MsgBox("An unknown error occurred. Please report it to piotr.domanski@nist.gov.", vbOKOnly) : Me.Close()
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        ' Static IntStart As Integer
        ' Static IntStart As Integer
        Dim FontHeigh As Integer = Me.ErrorText.Font.Height
        Dim TopMargin As Integer
        Dim LeftMargin As Integer
        Dim TextHeigh As Integer
        Dim LinesPerPage As Integer
        Dim MoltLine As Integer = 0

        TextHeigh = e.MarginBounds.Height
        LeftMargin = e.MarginBounds.Left
        TopMargin = e.MarginBounds.Top

        LinesPerPage = CInt(Math.Round(TextHeigh / (Me.ErrorText.Font.Height + 0.025)))
        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
        For i As Integer = IntStart To Me.ArrayLines.Length - 1
            MoltLine += 1
            e.Graphics.DrawString(ArrayLines(i), Me.ErrorText.Font, Brushes.Black, LeftMargin, FontHeigh * MoltLine + TopMargin)
            If i <> 0 And i Mod (LinesPerPage - 3) = 0 Then
                e.HasMorePages = True  ' Add a page each multiple of LinesPerPage -3
                IntStart = i + 1
                Exit For
            End If
            If i = Me.ArrayLines.Length - 1 Then IntStart = 0
        Next i
    End Sub
    Private Sub SaveBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBut.Click
        If Me.PathTextFile <> "" And Directory.Exists(Me.PathTextFile) Then
            Me.SaveFileDialog1.InitialDirectory = Me.PathTextFile
        Else
            Me.SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        End If
        Me.SaveFileDialog1.FileName = ""
        Me.SaveFileDialog1.DefaultExt = ".txt"
        Me.SaveFileDialog1.Filter = "(*.txt)|*.txt"
        Me.SaveFileDialog1.AddExtension = True
        Me.SaveFileDialog1.OverwritePrompt = True
        Me.SaveFileDialog1.ShowDialog()
        Me.PathTextFile = Directory.GetCurrentDirectory
    End Sub
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Using StreamWriter As New StreamWriter(Me.SaveFileDialog1.FileName)
                StreamWriter.Write(StringRed)
            End Using
        Catch ex As FieldAccessException
            MsgBox("The file is open. Please close the file and try again or specify a different file name.", vbOKOnly) : Me.Close()
        Catch ex As FileLoadException
            MsgBox("The file is open. Please close the file and try again or specify a different file name.", vbOKOnly) : Me.Close()
        Catch ex As Exception
            MsgBox("An unknown error occurred. Please report it to piotr.domanski@nist.gov.", vbOKOnly) : Me.Close()
        End Try
    End Sub
    Private Sub FormError_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For Each Control As Control In Me.Controls
            If TypeOf Control Is Button Then
                Dim PointLocal As New Point
                PointLocal.X = Control.Location.X : PointLocal.Y = Me.DisplayRectangle.Bottom - DiffButtonBottom
                Control.Location = PointLocal
            ElseIf TypeOf Control Is TextBox Then
                Dim height As Integer
                height = Me.DisplayRectangle.Height - DiffTextBotton
                Control.Height = height
            End If
        Next
    End Sub
End Class