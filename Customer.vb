Imports System.Data.SqlClient
Imports System.Data

Public Class Customer
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim str As String
    Dim getcust As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\SupermarketManagementsystem\SupermarketManagementsystem\market.mdf;Integrated Security=True")
        If (RadioButton1.Checked = True) Then
            str = "Male"
        Else
            str = "Female"
        End If

        com = New SqlCommand("insert into cust(name,gender,addr,mobile,date)values('" & TextBox2.Text & "','" & str & "','" & TextBox8.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("New Customer Infromation Inserted Successfullyy..")
        Hide()
        con.Close()

        TextBox2.Text = ""
        TextBox8.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox8.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\documents\visual studio 2015\Projects\SupermarketManagementsystem\SupermarketManagementsystem\market.mdf;Integrated Security=True")
        con.Open()

        Try
            getcust = "SELECT nextID=MAX(Id)+1 FROM cust"
            com = New SqlCommand(getcust, con)
            dr = com.ExecuteReader()
            If dr.Read() Then

                TextBox1.Text = dr.GetValue(0).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class