Public Class Form1
    Dim TotalPlans = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IoCost, TotalCost As Decimal
        IoCost = (TextBox2.Text * TextBox3.Text) + (TextBox4.Text * TextBox5.Text)
        TotalCost = IoCost + TextBox6.Text + TextBox7.Text
        TextBox8.Text = IoCost
        TextBox9.Text = TotalCost
        CosT_PARAMETERTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox8.Text, TextBox6.Text, TextBox7.Text, TextBox9.Text)
        Me.DataSet11.AcceptChanges()
        TotalPlans += 1
        Button3.Enabled = True
        MessageBox.Show("Data Saved", "MESSAGE")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CosT_PARAMETERTableAdapter1.DeleteQuery(Val(TextBox1.Text))
        Me.DataSet11.AcceptChanges()
        TotalPlans -= 1
        If TotalPlans = 0 Then
            Button3.Enabled = False
        End If
        MessageBox.Show("Data Deleted", "MESSAGE")
        TextBox1.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TotalCost
        TotalCost = CosT_PARAMETERTableAdapter1.ScalarQuery()
        TextBox10.Text = TotalCost
    End Sub
End Class
