Imports System.IO
Imports System.Data.OleDb
Public Class frmDatagridView

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If ComboBox1.Text = "Code" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Product where Code = " & TextBox1.Text & "", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView1.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.Text = "Product Name" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Product where PName = '" & TextBox1.Text & "'", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView1.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        TextBox2.Clear()

       
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim adp As New OleDbDataAdapter("select * from Product ", con)
            Dim dr As DataRow
            Dim dt As DataTable
            Dim ds As New DataSet
            adp.Fill(ds)
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                Me.DataGridView1.DataSource = dt
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If ComboBox2.Text = "Code" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where Code = " & TextBox2.Text & "", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ComboBox2.Text = "Name" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where Name = '" & TextBox2.Text & "'", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ComboBox2.Text = "City" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where City = " & TextBox2.Text & "", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ComboBox2.Text = "State" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where State = " & TextBox2.Text & "", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ComboBox2.Text = "Mobile No" Then
            DataGridView2.DataSource = Me.CustomerTableAdapter.getMobile(Val(TextBox2.Text))
        ElseIf ComboBox2.Text = "Phone No" Then
            DataGridView2.DataSource = Me.CustomerTableAdapter.getPhoneNo(Val(TextBox2.Text))
        End If

        TextBox2.Clear()


        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim adp As New OleDbDataAdapter("select * from Customer ", con)
            Dim dr As DataRow
            Dim dt As DataTable
            Dim ds As New DataSet
            adp.Fill(ds)
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                Me.DataGridView2.DataSource = dt
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmDatagridView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Issue1' table. You can move, or remove it, as needed.
        Me.Issue1TableAdapter.Fill(Me.DataSet1.Issue1)
        'TODO: This line of code loads data into the 'DataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DataSet1.Customer)
        'TODO: This line of code loads data into the 'DataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DataSet1.Product)

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If ComboBox1.Text = "Code" Then
            If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "a" And e.KeyChar <= "z" Then
                e.Handled = True
                MessageBox.Show("Please enter Character only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If
        Else
            If e.KeyChar >= "0" And e.KeyChar <= "1" Then
                e.Handled = True
                MessageBox.Show("Please enter Number only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim adp As New OleDbDataAdapter("select * from Product where pname like '" & TextBox1.Text & "%'", con)
            Dim dr As DataRow
            Dim dt As DataTable
            Dim ds As New DataSet
            adp.Fill(ds)
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                Me.DataGridView1.DataSource = dt
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If ComboBox2.Text = "Code" Then
            If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "a" And e.KeyChar <= "z" Then
                e.Handled = True
                MessageBox.Show("Please enter Character only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If

        ElseIf ComboBox2.Text = "Name" Then
            If e.KeyChar >= "0" And e.KeyChar <= "1" Then
                e.Handled = True
                MessageBox.Show("Please enter Number only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If

        ElseIf ComboBox2.Text = "City" Then
            If e.KeyChar >= "0" And e.KeyChar <= "1" Then
                e.Handled = True
                MessageBox.Show("Please enter Number only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If

        ElseIf ComboBox2.Text = "State" Then
            If e.KeyChar >= "0" And e.KeyChar <= "1" Then
                e.Handled = True
                MessageBox.Show("Please enter Number only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If

        ElseIf ComboBox2.Text = "Mobile No" Then
            If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "a" And e.KeyChar <= "z" Then
                e.Handled = True
                MessageBox.Show("Please enter Character only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If
        ElseIf ComboBox2.Text = "Phone No" Then
            If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "a" And e.KeyChar <= "z" Then
                e.Handled = True
                MessageBox.Show("Please enter Character only", cap, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        If ComboBox2.Text = "Name" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where Name like '" & TextBox2.Text & "%'", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ComboBox2.Text = "City" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where City like '" & TextBox2.Text & "%'", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf ComboBox2.Text = "State" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim adp As New OleDbDataAdapter("select * from Customer where State like '" & TextBox2.Text & "%'", con)
                Dim dr As DataRow
                Dim dt As DataTable
                Dim ds As New DataSet
                adp.Fill(ds)
                dt = ds.Tables(0)
                For Each dr In dt.Rows
                    Me.DataGridView2.DataSource = dt
                Next
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
End Class