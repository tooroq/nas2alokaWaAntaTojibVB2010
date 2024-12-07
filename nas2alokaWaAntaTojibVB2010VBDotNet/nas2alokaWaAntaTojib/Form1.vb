
' www.tooroq.com - Mohamed Hirech - 212658691009
' www.tooroq.com - Mohamed Hirech - 212658691009
' www.tooroq.com - Mohamed Hirech - 212658691009

Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form1

    Public tm As Integer = 15
    Public timeSecond As Integer = tm
    Public countq As Integer = 0

    Public qTrue As Integer = 0
    Public qFalse As Integer = 0

    Public qs As String
    Public a1 As String
    Public a2 As String
    Public a3 As String
    Public a4 As String
    Public sa As String


    ' متغير لتخزين الوقت
    Private customTime As DateTime = New DateTime(2024, 1, 1, 0, 0, 0) ' ابدأ الساعة من تاريخ ووقت معين


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        getNumQestionsInClass()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sa = "1" Then
            trueAnswer()
        Else
            falseAnswer()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If sa = "2" Then
            trueAnswer()
        Else
            falseAnswer()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If sa = "3" Then
            trueAnswer()
        Else
            falseAnswer()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If sa = "4" Then
            trueAnswer()
        Else
            falseAnswer()
        End If

    End Sub


    Public Sub trueAnswer()
        MessageBox.Show("صحيح", "صحيح", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Timer1.Enabled = False
        timeSecond = tm
        selectAnswer()
        qTrue += 1
        Label3.Text = qTrue.ToString
    End Sub

    Public Sub falseAnswer()
        MessageBox.Show("خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        qFalse += 1
        Label4.Text = qFalse.ToString
    End Sub


    Public Sub selectAnswer()
        Timer1.Enabled = True

        countq += 1
        getNumQestionsInClass()

        Button1.Image = CType(My.Resources.btn, Image)
        Button2.Image = CType(My.Resources.btn, Image)
        Button3.Image = CType(My.Resources.btn, Image)
        Button4.Image = CType(My.Resources.btn, Image)

    End Sub


    Public Sub getNumQestionsInClass()

        Dim array As New ClassQestions

        Textq.Text = array.qstionsArr(countq, 3)
        Button1.Text = array.qstionsArr(countq, 4)
        Button2.Text = array.qstionsArr(countq, 5)
        Button3.Text = array.qstionsArr(countq, 6)
        Button4.Text = array.qstionsArr(countq, 7)

        sa = array.qstionsArr(countq, 8)

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If timeSecond = 2 Then

            Button1.BackColor = Color.OrangeRed
            Button2.BackColor = Color.OrangeRed
            Button3.BackColor = Color.OrangeRed
            Button4.BackColor = Color.OrangeRed

            If sa = "1" Then
                Button1.Image = CType(My.Resources.colortrue1, Image)
            ElseIf sa = "2" Then
                Button2.Image = CType(My.Resources.colortrue1, Image)
            ElseIf sa = "3" Then
                Button3.Image = CType(My.Resources.colortrue1, Image)
            ElseIf sa = "4" Then
                Button4.Image = CType(My.Resources.colortrue1, Image)
            End If

        End If

        If timeSecond > 9 Then
            Label1.Text = timeSecond.ToString
        Else
            Label1.Text = "0" + timeSecond.ToString
        End If

        timeSecond -= 1

        If timeSecond = -1 Then
            timeSecond = tm
            selectAnswer()
        End If


        ' زيادة الوقت الخاص بالساعة كل ثانية
        customTime = customTime.AddSeconds(1)
        ' تحديث عرض الوقت في الـ Label
        Label2.Text = customTime.ToString("HH:mm:ss")


    End Sub


    ''''''''''''''
    ' هذه الدالة للاتصال بقواعد بيانات Mysql أو استدعاء المصفوفات من ملف PHP
    ' هذه غير شغالة بالبرنامج يمكن استخدامها إذا كنت تريد جلب الأسئلة من خلال الانترنت
    ''' <summary>
    ''' '''''''''''
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub loadDataInternetMysql()
        Dim PostData = "user_name=" & "1"
        Dim request As WebRequest = WebRequest.Create("http://qodorate.com/vb2010/test.php")

        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(PostData)
        request.ContentType = "application/x-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()

        Dim array As String() = responseFromServer.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

        qs = array(0)
        a1 = array(1)
        a2 = array(2)
        a3 = array(3)
        a4 = array(4)
        sa = array(5)

        Textq.Text = qs
        Button1.Text = a1
        Button2.Text = a2
        Button3.Text = a3
        Button4.Text = a4

        reader.Close()
        dataStream.Close()
        response.Close()
        MsgBox(array(3))

    End Sub









End Class
