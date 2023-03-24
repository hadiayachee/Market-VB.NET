
Imports System.Data.SqlClient
Public Class Login
    Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If UidTb.Texts = "" Then
            MsgBox("enter ID")
        ElseIf UpassTb.Texts = "" Then
            MsgBox("enter password")
        Else
            Con.Open()
            Dim query = "select * from ADMINTBL where AdminName='" & UidTb.Texts & "' and Adminpass='" & UpassTb.Texts & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("wrong name or password")
            Else
                Dim prod = New Product
                prod.Show()
                Me.Hide()

            End If
            Con.Close()

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim prod = New seller
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UidTb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If UidTb.Texts = "" Then
            MsgBox("enter ID")
        ElseIf UpassTb.Texts = "" Then
            MsgBox("enter password")
        Else
            Con.Open()
            Dim query = "select * from ADMINTBL where AdminName='" & UidTb.Texts & "' and Adminpass='" & UpassTb.Texts & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, Con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("wrong name or password")
            Else
                Dim prod = New Product
                prod.Show()
                Me.Hide()

            End If
            Con.Close()

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress

    End Sub

    Private Sub Guna2GradientTileButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        Dim prod = New seller
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class