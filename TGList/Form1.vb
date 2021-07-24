Imports System.Net
Public Class Form1

    Dim sent As Integer
    Dim done As Integer
    Dim Errors As Integer
    Dim rlist As Integer
    Dim s As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For X As Integer = 0 To TextBox1.Lines.Count - 1
                ListBox1.Items.Add(TextBox1.Lines(X))
            Next
            ListBox1.SelectedIndex = 0
            Label6.Text = "Total : " & ListBox1.Items.Count - 1
            rlist = ListBox1.Items.Count - 1
            Label9.Text = "Remainder : " & rlist
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Timer1.Interval = NumericUpDown1.Value
            Timer1.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If TextBox5.Text = "sendMessage" Then
                Try
                    Label10.Text = "Status : Sending..."
                    Dim IP As New WebClient
                    IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendMessage?text=" & ListBox1.SelectedItem & "&chat_id=" & TextBox3.Text)
                    ListBox2.Items.Add("Success!")
                    Label10.Text = "Status : Success!"
                    Label12.Text = "Chat ID : " & TextBox3.Text
                    Label11.Text = "Method : " & TextBox5.Text
                    rlist -= 1
                    Label9.Text = "Remainder : " & rlist
                    s += 1
                    Label13.Text = "Success : " & s
                    sent += 1
                    Label8.Text = "Sent : " & sent
                    ListBox1.SelectedIndex += 1
                    ListBox2.SelectedIndex += 1
                    If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                        Timer1.Stop()
                        done += 1
                        Label15.Text = "Done : " & done
                        ListBox2.Items.Add("Done...")
                        Label10.Text = "Status : Done..."
                    End If
                Catch ex As Exception
                    Timer1.Stop()
                    Errors += 1
                    Label14.Text = "Error : " & Errors
                    ListBox2.Items.Add("Error!")
                    Label10.Text = "Status : Error!"
                End Try
            ElseIf TextBox5.Text = "sendPhoto" Then
                Try
                    Label10.Text = "Status : Sending..."
                    Dim IP As New WebClient
                    IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendPhoto?photo=" & ListBox1.SelectedItem & "&chat_id=" & TextBox3.Text & "&caption=" & TextBox4.Text)
                    ListBox2.Items.Add("Success!")
                    Label10.Text = "Status : Success!"
                    Label11.Text = "Method : " & TextBox5.Text
                    Label12.Text = "Chat ID : " & TextBox3.Text
                    rlist -= 1
                    Label9.Text = "Remainder : " & rlist
                    s += 1
                    Label13.Text = "Success : " & s
                    sent += 1
                    Label8.Text = "Sent : " & sent
                    ListBox1.SelectedIndex += 1
                    ListBox2.SelectedIndex += 1
                    If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                        Timer1.Stop()
                        done += 1
                        Label15.Text = "Done : " & done
                        ListBox2.Items.Add("Done...")
                        Label10.Text = "Status : Done..."
                    End If
                Catch ex As Exception
                    Timer1.Stop()
                    Errors += 1
                    Label14.Text = "Error : " & Errors
                    ListBox2.Items.Add("Error!")
                    Label10.Text = "Status : Error!"
                End Try
            ElseIf TextBox5.Text = "sendAudio" Then
                Try
                    Label10.Text = "Status : Sending..."
                    Dim IP As New WebClient
                    IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendAudio?audio=" & ListBox1.SelectedItem & "&chat_id=" & TextBox3.Text & "&caption=" & TextBox4.Text)
                    ListBox2.Items.Add("Success!")
                    Label10.Text = "Status : Success!"
                    Label11.Text = "Method : " & TextBox5.Text
                    Label12.Text = "Chat ID : " & TextBox3.Text
                    rlist -= 1
                    Label9.Text = "Remainder : " & rlist
                    s += 1
                    Label13.Text = "Success : " & s
                    sent += 1
                    Label8.Text = "Sent : " & sent
                    ListBox1.SelectedIndex += 1
                    ListBox2.SelectedIndex += 1
                    If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                        Timer1.Stop()
                        done += 1
                        Label15.Text = "Done : " & done
                        ListBox2.Items.Add("Done...")
                        Label10.Text = "Status : Done..."
                    End If
                Catch ex As Exception
                    Timer1.Stop()
                    Errors += 1
                    Label14.Text = "Error : " & Errors
                    ListBox2.Items.Add("Error!")
                    Label10.Text = "Status : Error!"
                End Try
            ElseIf TextBox5.Text = "sendDocument" Then
                Try
                    Label10.Text = "Status : Sending..."
                    Dim IP As New WebClient
                    IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendDocument?document=" & ListBox1.SelectedItem & "&chat_id=" & TextBox3.Text & "&caption=" & TextBox4.Text)
                    ListBox2.Items.Add("Success!")
                    Label10.Text = "Status : Success!"
                    Label11.Text = "Method : " & TextBox5.Text
                    Label12.Text = "Chat ID : " & TextBox3.Text
                    rlist -= 1
                    Label9.Text = "Remainder : " & rlist
                    s += 1
                    Label13.Text = "Success : " & s
                    sent += 1
                    Label8.Text = "Sent : " & sent
                    ListBox1.SelectedIndex += 1
                    ListBox2.SelectedIndex += 1
                    If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                        Timer1.Stop()
                        done += 1
                        Label15.Text = "Done : " & done
                        ListBox2.Items.Add("Done...")
                        Label10.Text = "Status : Done..."
                    End If
                Catch ex As Exception
                    Timer1.Stop()
                    Errors += 1
                    Label14.Text = "Error : " & Errors
                    ListBox2.Items.Add("Error!")
                    Label10.Text = "Status : Error!"
                End Try
            ElseIf TextBox5.Text = "sendVideo" Then
                Try
                    Label10.Text = "Status : Sending..."
                    Dim IP As New WebClient
                    IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendVideo?video=" & ListBox1.SelectedItem & "&chat_id=" & TextBox3.Text & "&caption=" & TextBox4.Text)
                    ListBox2.Items.Add("Success!")
                    Label10.Text = "Status : Success!"
                    Label11.Text = "Method : " & TextBox5.Text
                    Label12.Text = "Chat ID : " & TextBox3.Text
                    rlist -= 1
                    Label9.Text = "Remainder : " & rlist
                    s += 1
                    Label13.Text = "Success : " & s
                    sent += 1
                    Label8.Text = "Sent : " & sent
                    ListBox1.SelectedIndex += 1
                    ListBox2.SelectedIndex += 1
                    If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                        Timer1.Stop()
                        done += 1
                        Label15.Text = "Done : " & done
                        ListBox2.Items.Add("Done...")
                        Label10.Text = "Status : Done..."
                    End If
                Catch ex As Exception
                    Timer1.Stop()
                    Errors += 1
                    Label14.Text = "Error : " & Errors
                    ListBox2.Items.Add("Error!")
                    Label10.Text = "Status : Error!"
                End Try
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Timer1.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            OpenFileDialog1.ShowDialog()
            TextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
