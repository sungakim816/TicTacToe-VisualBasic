Public Class TicTacToe
    Dim x_char As String = "X"
    Dim o_char As String = "O"
    Dim current_value As String
    Dim whose_turn As Boolean = True
    Dim is_over As Boolean = False
    Dim is_win As Boolean = False
    Dim move_count As Integer = 0
    Dim x_score As Integer = 0
    Dim o_score As Integer = 0
    Dim ways_to_win(,) As Integer = {
        {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
        {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
        {2, 4, 6}, {0, 4, 8}
    }
    Dim previous_user_input(9) As String
    Dim end_message As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XLabel.Text = "X: " & x_score
        OLabel.Text = "O: " & o_score
    End Sub

    Private Sub ButtonClickEventHandler(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click
        Dim clicked_button As Button = CType(sender, Button)
        If clicked_button.Enabled Then
            If whose_turn Then
                current_value = x_char
            Else
                current_value = o_char
            End If
            clicked_button.Text = current_value
            whose_turn = Not whose_turn
            Dim button_name As String = clicked_button.Name
            previous_user_input.SetValue(current_value, Integer.Parse(button_name(button_name.Length - 1)))
            clicked_button.Enabled = False
            clicked_button.BackColor = Color.LightBlue
            move_count += 1
        End If
        is_win = Check_Winner()
        If is_win And current_value = "X" Then
            is_over = True
            end_message = "Winner: " & current_value
            x_score += 1
            XLabel.Text = "X: " & x_score
        ElseIf is_win And current_value = "O" Then
            is_over = True
            end_message = "Winner: " & current_value
            o_score += 1
            OLabel.Text = "O: " & o_score
        ElseIf Not is_win And move_count >= 9 Then
            is_over = True
            end_message = "Draw"
        End If
        If is_over Then
            MessageBox.Show(end_message)

            Restart()
        End If
    End Sub

    Private Function Check_Winner() As Boolean
        For index = 0 To ways_to_win.GetLength(0) - 1
            Dim cond1 As Boolean = previous_user_input.GetValue(ways_to_win.GetValue(index, 0)) = previous_user_input.GetValue(ways_to_win.GetValue(index, 1))
            Dim cond2 As Boolean = previous_user_input.GetValue(ways_to_win.GetValue(index, 1)) = previous_user_input.GetValue(ways_to_win.GetValue(index, 2))
            Dim cond3 As Boolean = previous_user_input.GetValue(ways_to_win.GetValue(index, 0)) <> ""
            If cond1 And cond2 And cond3 Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Restart()
        is_over = False
        is_win = False
        move_count = 0
        whose_turn = True
        Array.Clear(previous_user_input, 0, previous_user_input.Length)
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType Is GetType(Button) Then
                Dim temp As Button = CType(ctrl, Button)
                temp.BackColor = DefaultBackColor
                temp.Enabled = True
                temp.Text = ""
            End If
        Next
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        Restart()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Application.Restart()
    End Sub
End Class
