Imports System.Data.SqlClient
Public Class Product
    Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from ProductTbl1 "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Con.Open()
        Dim query As String
        query = "insert into ProductTbl1 values('" & ProdName.Texts & "'," & ProdPrice.Texts & "," & ProdQty.Texts & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("product added")
        Con.Close()
        populate()



    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If ProdId.Text = "" Then
            MsgBox("select the product to deleted")
        Else
            Con.Open()
            Dim query As String
            query = "delete from ProductTbl1 where ProdId=" & ProdId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("product deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ProdId.Clear()
        ProdName.Texts = ""
        ProdQty.Texts = ""
        ProdPrice.Texts = ""
        code.Texts = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If ProdId.Text = "" Or ProdName.Texts = "" Or ProdQty.Texts = "" Or ProdPrice.Texts = "" Then
            MsgBox("select product to edit")
        Else
            Con.Open()
            Dim query As String
            query = "update  ProductTbl1 set ProdName= '" & ProdName.Texts & "',ProdPrice=" & ProdPrice.Texts & ",ProdQty=" & ProdQty.Texts & " where ProdId=" & ProdId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("product updated")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Con.Open()
        Dim sql = "select * from ProductTbl1 where ProdName like '" & TextBox2.Texts & "%' or ProdId like '" & TextBox2.Texts & "%'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)

        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        ProductDGV.DataSource = ds


        Con.Close()
    End Sub

    Private Sub ProductDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selecetdrows As DataGridViewRow
        selecetdrows = ProductDGV.Rows(index)
        code.Texts = selecetdrows.Cells(1).Value.ToString()
        ProdId.Text = selecetdrows.Cells(0).Value.ToString()
        ProdName.Texts = selecetdrows.Cells(2).Value.ToString()
        ProdQty.Texts = selecetdrows.Cells(4).Value.ToString()
        ProdPrice.Texts = selecetdrows.Cells(3).Value.ToString()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs)
        Dim prod = New Login
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ProdName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdPrice_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdId_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RjTextBox1__TextChanged(sender As Object, e As EventArgs) Handles TextBox2._TextChanged
        Con.Open()
        Dim sql = "select * from ProductTbl1 where ProdName like '" & TextBox2.Texts & "%' or ProdCode like '" & TextBox2.Texts & "%'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)

        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        ProductDGV.DataSource = ds


        Con.Close()
    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim prod = New Login
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim query As String
        query = "insert into ProductTbl1 values('" & code.Texts & "','" & ProdName.Texts & "'," & ProdPrice.Texts & "," & ProdQty.Texts & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("product added")
        Con.Close()
        populate()
    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ProdId.Text = "" Or ProdName.Texts = "" Or ProdQty.Texts = "" Or ProdPrice.Texts = "" Then
            MsgBox("select product to edit")
        Else
            Con.Open()
            Dim query As String
            query = "update  ProductTbl1 set ProdCode='" & code.Texts & "',ProdName= '" & ProdName.Texts & "',ProdPrice=" & ProdPrice.Texts & ",ProdQty=" & ProdQty.Texts & " where ProdId=" & ProdId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("product updated")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Guna2GradientTileButton1_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If ProdId.Text = "" Then
            MsgBox("select the product to deleted")
        Else
            Con.Open()
            Dim query As String
            query = "delete from ProductTbl1 where ProdId=" & ProdId.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("product deleted")
            Con.Close()
            populate()
        End If
    End Sub

    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProdId.Clear()
        ProdName.Texts = ""
        ProdQty.Texts = ""
        ProdPrice.Texts = ""
        code.Texts = ""
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class