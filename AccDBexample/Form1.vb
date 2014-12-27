Imports System.IO
Public Class Form1
    Dim cnn As New OleDb.OleDbConnection
    Dim dt As New DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mydatabase.accdb"
        cnn.Open()
        DataGridView1.DataSource = dt
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM table1", cnn)
        da.Fill(dt)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dt.Clear()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM table1", cnn)
        da.Fill(dt)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim temp As New DataTable
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "SELECT Marks FROM table1 WHERE studentName = ?"
        cmd.Parameters.AddWithValue("para1", textboxStdNameGet.Text)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        da.Fill(temp)

        If temp.Rows.Count > 0 Then
            labelMarks.Text = temp.Rows(0).Item("Marks")
        End If

        Button2_Click(sender, e)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO table1(studentName,Marks) VALUES(?,?)"
        cmd.Parameters.AddWithValue("para1", textboxStdNameAdd.Text)
        cmd.Parameters.AddWithValue("para2", textboxMarksAdd.Text)
        cmd.ExecuteNonQuery()

        Button2_Click(sender, e)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "UPDATE table1 SET Marks = ? WHERE studentName = ?"
        cmd.Parameters.AddWithValue("para1", textboxMarksUpdate.Text)
        cmd.Parameters.AddWithValue("para2", textboxStdNameUpdate.Text)
        Dim rows = cmd.ExecuteNonQuery()

        Button2_Click(sender, e)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "DELETE FROM table1 WHERE studentName = ?"
        cmd.Parameters.AddWithValue("para1", textboxStdNameDelete.Text)
        Dim rows = cmd.ExecuteNonQuery()

        Button2_Click(sender, e)

    End Sub
End Class
