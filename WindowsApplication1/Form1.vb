Option Strict On

Imports System.Reflection
Imports System.IO

Public Class Form1
    'Private InformationBox As New TextBox
    'Private IDBox As New TextBox
    'Private Label11 As New Label
    'Private TextBox5 As New TextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Dim oReader As StreamReader <-- DELETE THIS
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'MY CODE STARTS HERE:
            Dim customerInfo As String
            Using sr = New StreamReader(OpenFileDialog1.FileName, True)
                customerInfo = sr.ReadToEnd()
            End Using 'Close the stream early since we have all data needed

            'Write all lines into a string array
            Dim lines As String() = customerInfo.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            'Get the line where the ID Number is in
            Dim idLine As String = lines.Where(Function(l) l.StartsWith("ID number")).FirstOrDefault()
            Dim id As String = String.Empty
            If Not String.IsNullOrEmpty(idLine) Then
                Dim aIdLine() = idLine.Split(":"c) 'Split the ID line by :
                If aIdLine.Length >= 1 Then
                    id = aIdLine(1) 'This should be the actual ID
                End If
            End If

            'Set UI
            My.Forms.Form1.TextBox5.AppendText(Environment.NewLine & "Opened Customer : " & OpenFileDialog1.FileName & " File")
            InformationBox.Text = customerInfo
            IDBox.Text = id
            Label11.Text = OpenFileDialog1.FileName
        End If
    End Sub

End Class