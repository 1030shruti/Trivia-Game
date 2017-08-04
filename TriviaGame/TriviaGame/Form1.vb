Public Class Form1
    Dim x As Integer

    Dim Score As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If RadioButton1.Checked And x = 1 Then
            MsgBox("Correct")
            Score = Score + 1
        ElseIf RadioButton3.Checked And x = 2 Then
            MsgBox("Correct")
            Score = Score + 1

        ElseIf RadioButton2.Checked And x = 3 Then
            MsgBox("Correct")
            Score = Score + 1
        ElseIf RadioButton4.Checked And x = 4 Then
            MsgBox("Correct")
            Score = Score + 1

        ElseIf RadioButton3.Checked And x = 5 Then
            MsgBox("Correct")
            Score = Score + 1

        ElseIf RadioButton1.Checked And x = 6 Then
            MsgBox("Correct")
            Score = Score + 1

        ElseIf RadioButton2.Checked And x = 7 Then
            MsgBox("Correct")
            Score = Score + 1

        Else MsgBox("Incorrect")



        End If
        Label2.Text = "Score: " & Score
        Panel1.Enabled = False

    End Sub

    Private Sub Q1_Click(sender As Object, e As EventArgs) Handles Q1.Click
        Panel1.Enabled = True
        Label1.Text = "How many days are there in a year?"
        RadioButton1.Text = "365"
        RadioButton2.Text = "400"
        RadioButton3.Text = "364"
        RadioButton4.Text = "360"
        x = 1
        Q1.Enabled = False


    End Sub

    Private Sub Q2_Click(sender As Object, e As EventArgs) Handles Q2.Click
        Panel1.Enabled = True
        Label1.Text = "When is Valentine's Day?"
        RadioButton1.Text = "Feb. 27th"
        RadioButton2.Text = "March 12th"
        RadioButton3.Text = "Feb. 14"
        RadioButton4.Text = "Jan. 14"

        x = 2
        Q2.Enabled = False

    End Sub

    Private Sub Q3_Click(sender As Object, e As EventArgs) Handles Q3.Click
        Panel1.Enabled = True
        Label1.Text = "WHat Holiday is on the 24th of December?"
        RadioButton1.Text = "Christmas"
        RadioButton2.Text = "Christmas Eve"
        RadioButton3.Text = "Halloween"
        RadioButton4.Text = "New Year's Eve"
        x = 3
        Q3.Enabled = False
    End Sub

    Private Sub Q4_Click(sender As Object, e As EventArgs) Handles Q4.Click
        Panel1.Enabled = True
        Label1.Text = "What happens on October 30th? "
        RadioButton1.Text = "Halloween"
        RadioButton2.Text = "First Day of Fall"
        RadioButton3.Text = "Easter"
        RadioButton4.Text = "Mischief Night"
        x = 4
        Q4.Enabled = False
    End Sub

    Private Sub Q5_Click(sender As Object, e As EventArgs) Handles Q5.Click
        Panel1.Enabled = True
        Label1.Text = "What is the difference between Cyber Monday and Black Friday?"
        RadioButton1.Text = " Nothing"
        RadioButton2.Text = " Black Friday is an online sale and Cyber Monday is an in-store sale."
        RadioButton3.Text = "Black Friday is an in-store sale and cyber monday is an online sale"
        RadioButton4.Text = "On black friday, the sale is only in the morning; on cyber monday the sale is only in the afternoon."
        x = 5
        Q5.Enabled = False

    End Sub

    Private Sub Q6_Click(sender As Object, e As EventArgs) Handles Q6.Click
        Panel1.Enabled = True
        Label1.Text = "What day represents that YOU have gone a full circle  around the Sun?"
        RadioButton1.Text = "Your Birthday"
        RadioButton2.Text = "New Year's"
        RadioButton3.Text = "Halloween"
        RadioButton4.Text = "Christmas"
        x = 6
        Q6.Enabled = False
    End Sub

    Private Sub Q7_Click(sender As Object, e As EventArgs) Handles Q7.Click
        Panel1.Enabled = True
        Label1.Text = "How many times do we have to change the time?"
        RadioButton1.Text = "1"
        RadioButton2.Text = "2"
        RadioButton3.Text = "3"
        RadioButton4.Text = "4"
        x = 7
        Q7.Enabled = False
    End Sub

End Class


