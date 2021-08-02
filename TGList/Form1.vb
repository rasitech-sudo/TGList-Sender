Imports System.Net
Public Class Form1

    Dim sent As Integer
    Dim done As Integer
    Dim Errors As Integer
    Dim rlist As Integer
    Dim s As Integer
    Dim clone As Integer
    Dim bc As Integer
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
            bc = 0
            Timer1.Interval = NumericUpDown1.Value
            Timer1.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If bc = 0 Then
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

            Else
                If TextBox5.Text = "sendMessage" Then
                    Try
                        Label10.Text = "Status : Sending..."
                        Dim IP As New WebClient
                        IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendMessage?text=" & TextBox7.Text & "&chat_id=" & ListBox3.SelectedItem)
                        ListBox4.Items.Add("Success!")
                        Label10.Text = "Status : Success!"
                        Label12.Text = "Chat ID : " & ListBox3.SelectedItem
                        Label11.Text = "Method : " & TextBox5.Text
                        rlist -= 1
                        Label9.Text = "Remainder : " & rlist
                        s += 1
                        Label13.Text = "Success : " & s
                        sent += 1
                        Label8.Text = "Sent : " & sent
                        ListBox3.SelectedIndex += 1
                        ListBox4.SelectedIndex += 1
                        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                            Timer1.Stop()
                            done += 1
                            Label15.Text = "Done : " & done
                            ListBox4.Items.Add("Done...")
                            Label10.Text = "Status : Done..."
                        End If
                    Catch ex As Exception
                        Timer1.Stop()
                        Errors += 1
                        Label14.Text = "Error : " & Errors
                        ListBox4.Items.Add("Error!")
                        Label10.Text = "Status : Error!"
                    End Try
                ElseIf TextBox5.Text = "sendPhoto" Then
                    Try
                        Label10.Text = "Status : Sending..."
                        Dim IP As New WebClient
                        IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendPhoto?photo=" & TextBox7.Text & "&chat_id=" & ListBox3.SelectedItem & "&caption=" & TextBox7.Text)
                        ListBox4.Items.Add("Success!")
                        Label10.Text = "Status : Success!"
                        Label11.Text = "Method : " & TextBox5.Text
                        Label12.Text = "Chat ID : " & ListBox3.SelectedItem
                        rlist -= 1
                        Label9.Text = "Remainder : " & rlist
                        s += 1
                        Label13.Text = "Success : " & s
                        sent += 1
                        Label8.Text = "Sent : " & sent
                        ListBox3.SelectedIndex += 1
                        ListBox4.SelectedIndex += 1
                        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                            Timer1.Stop()
                            done += 1
                            Label15.Text = "Done : " & done
                            ListBox4.Items.Add("Done...")
                            Label10.Text = "Status : Done..."
                        End If
                    Catch ex As Exception
                        Timer1.Stop()
                        Errors += 1
                        Label14.Text = "Error : " & Errors
                        ListBox4.Items.Add("Error!")
                        Label10.Text = "Status : Error!"
                    End Try
                ElseIf TextBox5.Text = "sendAudio" Then
                    Try
                        Label10.Text = "Status : Sending..."
                        Dim IP As New WebClient
                        IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendAudio?audio=" & TextBox7.Text & "&chat_id=" & ListBox3.SelectedItem & "&caption=" & TextBox7.Text)
                        ListBox4.Items.Add("Success!")
                        Label10.Text = "Status : Success!"
                        Label11.Text = "Method : " & TextBox5.Text
                        Label12.Text = "Chat ID : " & ListBox3.SelectedItem
                        rlist -= 1
                        Label9.Text = "Remainder : " & rlist
                        s += 1
                        Label13.Text = "Success : " & s
                        sent += 1
                        Label8.Text = "Sent : " & sent
                        ListBox3.SelectedIndex += 1
                        ListBox4.SelectedIndex += 1
                        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                            Timer1.Stop()
                            done += 1
                            Label15.Text = "Done : " & done
                            ListBox4.Items.Add("Done...")
                            Label10.Text = "Status : Done..."
                        End If
                    Catch ex As Exception
                        Timer1.Stop()
                        Errors += 1
                        Label14.Text = "Error : " & Errors
                        ListBox4.Items.Add("Error!")
                        Label10.Text = "Status : Error!"
                    End Try
                ElseIf TextBox5.Text = "sendDocument" Then
                    Try
                        Label10.Text = "Status : Sending..."
                        Dim IP As New WebClient
                        IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendDocument?document=" & TextBox7.Text & "&chat_id=" & ListBox3.SelectedItem & "&caption=" & TextBox7.Text)
                        ListBox4.Items.Add("Success!")
                        Label10.Text = "Status : Success!"
                        Label11.Text = "Method : " & TextBox5.Text
                        Label12.Text = "Chat ID : " & ListBox3.SelectedItem
                        rlist -= 1
                        Label9.Text = "Remainder : " & rlist
                        s += 1
                        Label13.Text = "Success : " & s
                        sent += 1
                        Label8.Text = "Sent : " & sent
                        ListBox3.SelectedIndex += 1
                        ListBox4.SelectedIndex += 1
                        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                            Timer1.Stop()
                            done += 1
                            Label15.Text = "Done : " & done
                            ListBox4.Items.Add("Done...")
                            Label10.Text = "Status : Done..."
                        End If
                    Catch ex As Exception
                        Timer1.Stop()
                        Errors += 1
                        Label14.Text = "Error : " & Errors
                        ListBox4.Items.Add("Error!")
                        Label10.Text = "Status : Error!"
                    End Try
                ElseIf TextBox5.Text = "sendVideo" Then
                    Try
                        Label10.Text = "Status : Sending..."
                        Dim IP As New WebClient
                        IP.DownloadString("https://api.telegram.org/bot" & TextBox2.Text & "/sendVideo?video=" & TextBox7.Text & "&chat_id=" & ListBox3.SelectedItem & "&caption=" & TextBox7.Text)
                        ListBox4.Items.Add("Success!")
                        Label10.Text = "Status : Success!"
                        Label11.Text = "Method : " & TextBox5.Text
                        Label12.Text = "Chat ID : " & ListBox3.SelectedItem
                        rlist -= 1
                        Label9.Text = "Remainder : " & rlist
                        s += 1
                        Label13.Text = "Success : " & s
                        sent += 1
                        Label8.Text = "Sent : " & sent
                        ListBox3.SelectedIndex += 1
                        ListBox4.SelectedIndex += 1
                        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                            Timer1.Stop()
                            done += 1
                            Label15.Text = "Done : " & done
                            ListBox4.Items.Add("Done...")
                            Label10.Text = "Status : Done..."
                        End If
                    Catch ex As Exception
                        Timer1.Stop()
                        Errors += 1
                        Label14.Text = "Error : " & Errors
                        ListBox4.Items.Add("Error!")
                        Label10.Text = "Status : Error!"
                    End Try

                End If

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim fo As Form = New Form1
            fo.Text = "TGList Sender - Rasi Tech V4.0 (Clone " & clone & " )"
            fo.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Label6.Text = "Total : "
            Label8.Text = "Remainder : "
            Label9.Text = "Sent : "
            Label10.Text = "Status : "
            Label11.Text = "Method : "
            Label12.Text = "Chat ID : "
            Label13.Text = "Success : "
            Label14.Text = "Error : "
            Label15.Text = "Done : "
            sent = 0
            done = 0
            Errors = 0
            s = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bc = 0
        clone += 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Size = New Size(1290, 489)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            bc = 1
            Timer1.Interval = NumericUpDown1.Value
            Timer1.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try

            Timer1.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            OpenFileDialog1.ShowDialog()
            TextBox6.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox3.Items.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            For X As Integer = 0 To TextBox6.Lines.Count - 1
                ListBox3.Items.Add(TextBox6.Lines(X))
            Next
            ListBox1.SelectedIndex = 0
            Label6.Text = "Total : " & ListBox3.Items.Count - 1
            rlist = ListBox3.Items.Count - 1
            Label9.Text = "Remainder : " & rlist
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Process.Start("https://t.me/RasiTechCCG")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub FoClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Paste()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox3.Paste()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        splash.Close()
    End Sub
End Class
