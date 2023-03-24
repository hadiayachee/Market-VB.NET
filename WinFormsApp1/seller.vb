Imports System.Data.SqlClient

Public Class seller

    Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")

    Public Sub populate()
        Con.Open()
        Dim sql = "select * from ProductTbl1 where ProdQty !=0 "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGrdv.DataSource = ds.Tables(0)


        Con.Close()

    End Sub
    'Private Sub Fill()
    '    Con.Open()
    '    Dim sql = "select * from ProductTbl "
    '    Dim cmd As SqlCommand
    '    cmd = New SqlCommand(sql, Con)
    '    Dim adapter As SqlDataAdapter
    '    adapter = New SqlDataAdapter(cmd)
    '    Dim tbl = New DataTable()
    '    adapter.Fill(tbl)
    '    Comproduct.DataSource = tbl
    '    Comproduct.DisplayMember = "ProdName"
    '    Comproduct.ValueMember = "ProdName"
    '    Con.Close()
    'End Sub


    Shared Function Ordernew() As String
        Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")
        Dim GETOrderID As Integer
        Con.Open()
        Dim sql = "select TOP(1) OrderId+1 from Orders1 order by OrderId desc "
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
    Public Function OrderQTY() As String
        Dim Con As New SqlConnection("Data Source=.;Initial Catalog=Market2;Integrated Security=True")
        Dim GETOrderQTY As Integer
        Con.Open()
        Dim sql = "select  ProdQty from ProductTbl1 where ProdId=" & idhide.Text & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Dim rdr As SqlDataReader

        Dim tbl = New DataTable()
        rdr = cmd.ExecuteReader()
        While rdr.Read
            GETOrderQTY = rdr(0)
        End While
        Con.Close()
        Return GETOrderQTY


    End Function

    Dim price = 0
    Dim qty = 0
    Private Sub Fitchprice()
        Con.Open()
        Dim sql = "select * from ProductTbl1 where ProdName='" & CODE1.Texts & "' "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Dim rdr As SqlDataReader


        Dim tbl = New DataTable()
        rdr = cmd.ExecuteReader()
        While rdr.Read
            qty = rdr(3)
            price = rdr(2)
            ProdPrice.Texts = price
            ProdQty.Texts = qty
        End While
        Con.Close()
    End Sub
    Private Sub seller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill()
    End Sub

    Private Sub ProductDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BILLDGV.CellContentClick

    End Sub
    Dim i = 0, totaal = 0, totallera = 0
    Public Property MySqlDbType As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim prod = New Login
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod = New Login
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        populate()

    End Sub

    Private Sub DataGrdv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrdv.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGrdv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrdv.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selecetdrows As DataGridViewRow
        selecetdrows = DataGrdv.Rows(index)
        idhide.Text = selecetdrows.Cells(0).Value.ToString()
        CODE1.Texts = selecetdrows.Cells(2).Value.ToString()
        ProdPrice.Texts = selecetdrows.Cells(3).Value.ToString()
        TextBox1.Texts = selecetdrows.Cells(1).Value.ToString()
        'ProdQty.Text = selecetdrows.Cells(3).Value.ToString()
        ProdQty.Texts = 1
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)



        Con.Open()
        Dim sql = "select * from ProductTbl1 where ProdName like '" & TextBox2.Texts & "%'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)

        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        DataGrdv.DataSource = ds


        Con.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim i As Integer = BILLDGV.SelectedRows(0).Index
        BILLDGV.Rows.RemoveAt(i)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CODE1.Texts = ""
        ProdPrice.Texts = ""
        ProdQty.Texts = ""
        TextBox1.Texts = ""
    End Sub



    Private Sub BILLDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BILLDGV.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selecetdrows As DataGridViewRow
        selecetdrows = BILLDGV.Rows(index)
        CODE1.Texts = selecetdrows.Cells(3).Value.ToString()
        ProdPrice.Texts = selecetdrows.Cells(4).Value.ToString()
        ProdQty.Texts = selecetdrows.Cells(5).Value.ToString()
        TextBox1.Texts = selecetdrows.Cells(2).Value.ToString()
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)

    '    BILLDGV.AllowUserToAddRows = False
    '    Con.Open()
    '    For i As Integer = 0 To BILLDGV.Rows.Count - 1

    '        Dim query As String

    '        query = "insert into Orders1 (OrderId,ProductId,ProdName,Price,Qty,Total,Date) values(" & BILLDGV.Rows(i).Cells(0).Value.ToString() & "," & BILLDGV.Rows(i).Cells(1).Value.ToString() & ",'" & BILLDGV.Rows(i).Cells(2).Value.ToString() & "','" & BILLDGV.Rows(i).Cells(3).Value.ToString() & "','" & BILLDGV.Rows(i).Cells(4).Value.ToString() & "'," & BILLDGV.Rows(i).Cells(5).Value.ToString() & ",'" & BILLDGV.Rows(i).Cells(6).Value.ToString() & "')"
    '        Dim qury2 As String
    '        qury2 = "update ProductTbl1 set ProdQty=ProdQty-" & BILLDGV.Rows(i).Cells(4).Value.ToString() & " where ProdId= " & BILLDGV.Rows(i).Cells(1).Value.ToString() & ""
    '        Dim cmd As SqlCommand

    '        cmd = New SqlCommand(query, Con)
    '        cmd.ExecuteNonQuery()

    '        Dim cmd2 As SqlCommand

    '        cmd2 = New SqlCommand(qury2, Con)
    '        cmd2.ExecuteNonQuery()
    '    Next

    '    Con.Close()
    '    MsgBox("Data Saved")




    'End Sub

    Private Sub order_Click(sender As Object, e As EventArgs)
        Dim prod = New OrderDetails
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub editg_Click(sender As Object, e As EventArgs)
        Dim index As Integer

        Dim newDataRow As DataGridViewRow

        newDataRow = BILLDGV.Rows(index)

        newDataRow.Cells(3).Value = ProdPrice.Texts
        newDataRow.Cells(4).Value = ProdQty.Texts
        newDataRow.Cells(5).Value = Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts)
    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles order.Click
        Dim prod = New OrderDetails
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub RjTextBox1__TextChanged(sender As Object, e As EventArgs) Handles TextBox2._TextChanged

        Con.Open()
        Dim sql = "select * from ProductTbl1 where ProdName like '" & TextBox2.Texts & "%'or ProdCode like '" & TextBox2.Texts & "%'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)

        Dim ds As DataTable
        ds = New DataTable
        adapter.Fill(ds)
        DataGrdv.DataSource = ds


        Con.Close()
    End Sub

    Private Sub Guna2GradientTileButton1_Click_1(sender As Object, e As EventArgs) Handles ADDBILL.Click

        If ProdPrice.Texts = "" Or ProdQty.Texts = "" Or TXTLERA.Texts = "" Then
            MsgBox("ENTER QTY OR PRICE OR LERA")
        ElseIf Double.Parse(ProdQty.Texts) > Double.Parse(OrderQTY()) Then
            MsgBox("ERROR QTY")

        Else

            Dim i As Integer = DataGrdv.SelectedRows(0).Index
            DataGrdv.Rows.RemoveAt(i)

            Dim rnum As Integer = BILLDGV.Rows.Add()

            BILLDGV.Rows.Item(rnum).Cells("Column1").Value = idhide.Text
            BILLDGV.Rows.Item(rnum).Cells("Column8").Value = TextBox1.Texts
            BILLDGV.Rows.Item(rnum).Cells("Column2").Value = CODE1.Texts
            BILLDGV.Rows.Item(rnum).Cells("Column3").Value = ProdPrice.Texts
            BILLDGV.Rows.Item(rnum).Cells("Column4").Value = ProdQty.Texts
            BILLDGV.Rows.Item(rnum).Cells("Column7").Value = Ordernew()
            BILLDGV.Rows.Item(rnum).Cells("Column6").Value = Date.Now.ToShortDateString()
            BILLDGV.Rows.Item(rnum).Cells("Column5").Value = Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts)
            'totaal = totaal + (Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts))
            'dolar.Text = totaal
            'totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
            'lera.Text = totallera
            totaal = 0
            For index As Integer = 0 To BILLDGV.RowCount - 1
                totaal += BILLDGV.Rows(index).Cells(6).Value
                dolar.Text = totaal
                totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
                lera.Text = totallera
            Next

        End If
    End Sub

    Private Sub Guna2GradientTileButton1_Click_2(sender As Object, e As EventArgs) Handles editg.Click
        Dim index As Integer

        Dim newDataRow As DataGridViewRow

        newDataRow = BILLDGV.Rows(index)

        newDataRow.Cells(4).Value = ProdPrice.Texts
        newDataRow.Cells(5).Value = ProdQty.Texts
        newDataRow.Cells(6).Value = Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts)
        'totaal = totaal + (Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts))
        'dolar.Text = totaal
        'totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
        'lera.Text = totallera
        totaal = 0
        For i As Integer = 0 To BILLDGV.RowCount - 1
            totaal += BILLDGV.Rows(i).Cells(6).Value
            dolar.Text = totaal
            totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
            lera.Text = totallera
        Next
    End Sub

    Private Sub Guna2GradientTileButton1_Click_3(sender As Object, e As EventArgs) Handles Button2.Click
        CODE1.Texts = ""
        ProdPrice.Texts = ""
        ProdQty.Texts = ""
    End Sub

    Private Sub Guna2GradientTileButton1_Click_4(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = BILLDGV.SelectedRows(0).Index
        BILLDGV.Rows.RemoveAt(i)
        totaal = 0
        For j As Integer = 0 To BILLDGV.RowCount - 1
            totaal += BILLDGV.Rows(j).Cells(5).Value
            dolar.Text = totaal
            totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
            lera.Text = totallera
        Next
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProdPrice__TextChanged(sender As Object, e As EventArgs) Handles ProdPrice._TextChanged

    End Sub

    Private Sub TXTLERA_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientTileButton1_Click_5(sender As Object, e As EventArgs) Handles Button4.Click
        BILLDGV.AllowUserToAddRows = False
        Con.Open()
        For i As Integer = 0 To BILLDGV.Rows.Count - 1

            Dim query As String

            query = "insert into Orders1 (OrderId,ProductId,ProdCode,ProdName,Price,Qty,Total,Date) values(" & BILLDGV.Rows(i).Cells(0).Value.ToString() & "," & BILLDGV.Rows(i).Cells(1).Value.ToString() & ",'" & BILLDGV.Rows(i).Cells(2).Value.ToString() & "','" & BILLDGV.Rows(i).Cells(3).Value.ToString() & "','" & BILLDGV.Rows(i).Cells(4).Value.ToString() & "'," & BILLDGV.Rows(i).Cells(5).Value.ToString() & ",'" & BILLDGV.Rows(i).Cells(6).Value.ToString() & "','" & BILLDGV.Rows(i).Cells(7).Value.ToString() & "')"
            Dim qury2 As String
            qury2 = "update ProductTbl1 set ProdQty=ProdQty-" & BILLDGV.Rows(i).Cells(5).Value.ToString() & " where ProdId= " & BILLDGV.Rows(i).Cells(1).Value.ToString() & ""
            Dim cmd As SqlCommand

            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            Dim cmd2 As SqlCommand

            cmd2 = New SqlCommand(qury2, Con)
            cmd2.ExecuteNonQuery()
        Next

        Con.Close()
        MsgBox("DATA SAVED")
        Dim prod = New seller
        prod.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2GradientTileButton1_Click_6(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        totaal = 0
        totallera = 0
        For index As Integer = 0 To BILLDGV.RowCount - 2
            BILLDGV.Rows(index).Cells(6).Value = BILLDGV.Rows(index).Cells(6).Value - (BILLDGV.Rows(index).Cells(6).Value * Double.Parse(sale.Texts / 100))

            'totaal += BILLDGV.Rows(i).Cells(6).Value
            '    dolar.Text = totaal
            '    totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
            '    lera.Text = totallera

        Next

        totaal = 0
        For j As Integer = 0 To BILLDGV.RowCount - 1
            totaal += BILLDGV.Rows(j).Cells(6).Value
            dolar.Text = totaal
            totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
            lera.Text = totallera
        Next
        'Dim discounted_price As Double
        'Dim discounted_price2 As Double
        'discounted_price = totaal - (totaal * Double.Parse(sale.Texts / 100))
        'dolar.Text = discounted_price
        'discounted_price2 = totallera - (totallera * Double.Parse(sale.Texts / 100))
        'lera.Text = discounted_price2


    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub






    'Private Sub ADDBILL_Click(sender As Object, e As EventArgs)

    '    If ProdPrice.Texts = "" Or ProdQty.Texts = "" Or TXTLERA.Texts = "" Then
    '        MsgBox("enter QTY or Price or Lera")
    '    ElseIf Integer.Parse(ProdQty.Texts) > Integer.Parse(OrderQTY()) Then
    '        MsgBox("ERROR Qty")

    '    Else

    '        Dim i As Integer = DataGrdv.SelectedRows(0).Index
    '        DataGrdv.Rows.RemoveAt(i)

    '        Dim rnum As Integer = BILLDGV.Rows.Add()

    '        BILLDGV.Rows.Item(rnum).Cells("Column1").Value = idhide.Text
    '        BILLDGV.Rows.Item(rnum).Cells("Column2").Value = CODE1.Texts
    '        BILLDGV.Rows.Item(rnum).Cells("Column3").Value = ProdPrice.Texts
    '        BILLDGV.Rows.Item(rnum).Cells("Column4").Value = ProdQty.Texts
    '        BILLDGV.Rows.Item(rnum).Cells("Column7").Value = Ordernew()
    '        BILLDGV.Rows.Item(rnum).Cells("Column6").Value = Date.Now.ToShortDateString()
    '        BILLDGV.Rows.Item(rnum).Cells("Column5").Value = Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts)
    '        totaal = totaal + (Double.Parse(ProdPrice.Texts) * Double.Parse(ProdQty.Texts))
    '        dolar.Text = totaal
    '        totallera = (Double.Parse(totaal) * Double.Parse(TXTLERA.Texts))
    '        lera.Text = totallera

    '    End If

    'End Sub

    Private Sub Comproduct_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Fitchprice()
    End Sub
End Class