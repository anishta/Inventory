Imports System.IO
Imports System.Data.OleDb
Public Class frmIssue
    Dim i, cod, bal As Integer
    Private Sub save()
        Me.Validate()
        Me.Issue1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        bal = Val(BalTextBox.Text) - Val(QtyTextBox.Text)

        Me.ProductTableAdapter.UpdateQty(bal, cod)
    End Sub
    Private Sub Issue1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Issue1BindingNavigatorSaveItem.Click
        IDTextBox.Enabled = False
        DateDateTimePicker.Enabled = False
        Supplier_NameComboBox.Enabled = False
        PNameComboBox.Enabled = False
        QtyTextBox.Enabled = False
        BillNoTextBox.Enabled = False
        BalTextBox.Enabled = False
        NoteTextBox.Enabled = False
        Call save()
        MessageBox.Show("Record Saved", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IDTextBox.Enabled = False
        DateDateTimePicker.Enabled = False
        Supplier_NameComboBox.Enabled = False
        PNameComboBox.Enabled = False
        QtyTextBox.Enabled = False
        BillNoTextBox.Enabled = False
        BalTextBox.Enabled = False
        NoteTextBox.Enabled = False

        'TODO: This line of code loads data into the 'DataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DataSet1.Product)
        'TODO: This line of code loads data into the 'DataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DataSet1.Customer)
        'TODO: This line of code loads data into the 'DataSet1.Issue1' table. You can move, or remove it, as needed.
        Me.Issue1TableAdapter.Fill(Me.DataSet1.Issue1)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim ans As Integer
        ans = MessageBox.Show("Are you sure?", cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If ans = 6 Then
            Me.Issue1TableAdapter.DeleteQuery(Val(IDTextBox.Text))
            MessageBox.Show("Record Deleted", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'IDTextBox.Enabled = True
        DateDateTimePicker.Enabled = True
        Supplier_NameComboBox.Enabled = True
        PNameComboBox.Enabled = True
        QtyTextBox.Enabled = True
        BillNoTextBox.Enabled = True
        BalTextBox.Enabled = True
        NoteTextBox.Enabled = True
        Call save()

    End Sub

    Private Sub PNameComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        

    End Sub


    Private Sub PNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateDateTimePicker_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.LostFocus
        IDTextBox.Text = i + 1
    End Sub

    Private Sub DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.ValueChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        'IDTextBox.Enabled = True
        DateDateTimePicker.Enabled = True
        Supplier_NameComboBox.Enabled = True
        PNameComboBox.Enabled = True
        QtyTextBox.Enabled = True
        BillNoTextBox.Enabled = True
        BalTextBox.Enabled = True
        NoteTextBox.Enabled = True

        i = Me.Issue1TableAdapter.ScalarQuery()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Supplier_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PNameComboBox_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNameComboBox.LostFocus
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand("select * from Product where PName = '" & PNameComboBox.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            BalTextBox.Text = dr("Qty")
            cod = dr("Code")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PNameComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNameComboBox.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        

        Dim code As String

        code = InputBox("Enter Code", cap)
        If code <> "" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim dr As OleDbDataReader
                Dim cmd As New OleDbCommand("select * from Issue1 where ID = " & code & "", con)
                dr = cmd.ExecuteReader
                dr.Read()
                IDTextBox.Text = dr(0)
                DateDateTimePicker.Value = dr(1)
                Supplier_NameComboBox.Text = dr(2)
                PNameComboBox.Text = dr(3)
                QtyTextBox.Text = dr(4)
                BillNoTextBox.Text = dr(5)
                BalTextBox.Text = dr(6)
                NoteTextBox.Text = dr(7)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class