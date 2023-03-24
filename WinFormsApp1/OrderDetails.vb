
Imports System.Data.SqlClient
Public Class OrderDetails
    Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")
    Public Sub populat2()
        Con.Open()
        Dim sql = "select * from Orders1 "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ODGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    Public Sub populat3()
        Con.Open()
        Dim sql = "select * from Orders1 where Date >= DATEADD(day, -30, getdate()) "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ODGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Public Function totalD() As String
        Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")
        Dim GETOrderID As Double
        Con.Open()
        Dim sql = "select  sum (Total) from Orders1 where Date like cast(GETDATE() as Date) "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Dim rdr As SqlDataReader

        Dim tbl = New DataTable()
        rdr = cmd.ExecuteReader()
        While rdr.Read
            GETOrderID = rdr(0)
        End While
        Con.Close()
        Return GETOrderID


    End Function

    Public Function totalM() As String
        Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")
        Dim GETOrderID As Double
        Con.Open()
        Dim sql = "select  sum (Total) from Orders1 where Date >= DATEADD(day, -30, getdate()) "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Dim rdr As SqlDataReader

        Dim tbl = New DataTable()
        rdr = cmd.ExecuteReader()
        While rdr.Read
            GETOrderID = rdr(0)
        End While
        Con.Close()
        Return GETOrderID


    End Function
    Private Sub OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populat2()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Con.Open()
        Dim sql = "select * from Orders1 where Date like '" & searcho.Texts & "%' or OrderId like '" & searcho.Texts & "%'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)

        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        ODGV.DataSource = ds


        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        populat3()
        Label4.Text = Double.Parse(totalM())
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    ODGV.AllowUserToAddRows = False
    '    Con.Open()
    '    For i As Integer = 0 To ODGV.SelectedRows.Count - 1

    '        Dim query As String

    '        query = "delete from Orders1 where OrderId=" & ODGV.SelectedRows(i).Cells(0).Value.ToString() & " AND ProductId=" & ODGV.SelectedRows(i).Cells(1).Value.ToString() & ""
    '        Dim qury2 As String
    '        qury2 = "update ProductTbl1 set ProdQty=ProdQty + " & ODGV.SelectedRows(i).Cells(4).Value.ToString() & " where ProdId= " & ODGV.SelectedRows(i).Cells(1).Value.ToString() & ""
    '        Dim cmd As SqlCommand
    '        cmd = New SqlCommand(query, Con)
    '        ''cmd.Parameters.AddWithValue("@OrderId", ODGV.SelectedRows(i).Cells(0).Value.ToString())
    '        ''cmd.Parameters.AddWithValue("@ProductId", ODGV.SelectedRows(i).Cells(1).Value.ToString())
    '        cmd.ExecuteNonQuery()

    '        Dim cmd3 As SqlCommand

    '        cmd3 = New SqlCommand(qury2, Con)
    '        cmd3.ExecuteNonQuery()

    '    Next
    '    Con.Close()
    '    populat3()
    'End Sub

    Private Sub bck_Click(sender As Object, e As EventArgs)
        Dim prod = New seller
        prod.Show()
        Me.Hide()
    End Sub


    Private Sub OrderDetails_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Con.Open()
        Dim sql = "select * from Orders1 where  Date like cast(GETDATE() as Date)"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ODGV.DataSource = ds.Tables(0)
        Con.Close()
        Label4.Text = totalD()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub searcho_TextChanged(sender As Object, e As EventArgs) Handles searcho.TextChanged

    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ODGV.AllowUserToAddRows = False
        Con.Open()
        For i As Integer = 0 To ODGV.SelectedRows.Count - 1

            Dim query As String

            query = "delete from Orders1 where OrderId=" & ODGV.SelectedRows(i).Cells(0).Value.ToString() & " AND ProductId=" & ODGV.SelectedRows(i).Cells(1).Value.ToString() & ""
            Dim qury2 As String
            qury2 = "update ProductTbl1 set ProdQty=ProdQty + " & ODGV.SelectedRows(i).Cells(5).Value.ToString() & " where ProdId= " & ODGV.SelectedRows(i).Cells(1).Value.ToString() & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            ''cmd.Parameters.AddWithValue("@OrderId", ODGV.SelectedRows(i).Cells(0).Value.ToString())
            ''cmd.Parameters.AddWithValue("@ProductId", ODGV.SelectedRows(i).Cells(1).Value.ToString())
            cmd.ExecuteNonQuery()

            Dim cmd3 As SqlCommand

            cmd3 = New SqlCommand(qury2, Con)
            cmd3.ExecuteNonQuery()

        Next
        Con.Close()
        populat3()
    End Sub

    Private Sub Guna2GradientTileButton1_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Con.Open()
        Dim sql = "select * from Orders1 where  Date like cast(GETDATE() as Date)"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ODGV.DataSource = ds.Tables(0)
        Con.Close()
        totalall.Text = totalD()
    End Sub

    Private Sub Guna2GradientTileButton1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        populat3()
        totalall.Text = Double.Parse(totalM())
    End Sub

    Private Sub TextBox2__TextChanged(sender As Object, e As EventArgs) Handles searcho._TextChanged
        Con.Open()
        Dim sql = "select * from Orders1 where Date like '" & searcho.Texts & "%' or OrderId like '" & searcho.Texts & "%'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)

        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        ODGV.DataSource = ds


        Con.Close()
    End Sub

    Private Sub bck_Click_1(sender As Object, e As EventArgs)
        Dim prod = New seller
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim prod = New seller
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub OrderDetails_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class