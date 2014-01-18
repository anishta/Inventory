Imports System.IO
Imports System.Data.OleDb
Public Class frmReceived
    Dim cod, bal, i As Integer
    Dim dr As DataRow
    Private Sub ReceiptBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceiptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        bal = Val(BalanceTextBox.Text) + Val(QtyTextBox.Text)

        Me.ProductTableAdapter.UpdateQty(bal, cod)

        MessageBox.Show("Record Saved", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)

        IDTextBox.Enabled = False
        DateDateTimePicker.Enabled = False
        SNameComboBox.Enabled = False
        PNameComboBox.Enabled = False
        BillNoTextBox.Enabled = False
        QtyTextBox.Enabled = False
        BalanceTextBox.Enabled = False
        NoteTextBox.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DataSet1.Customer)

        IDTextBox.Enabled = False
        DateDateTimePicker.Enabled = False
        SNameComboBox.Enabled = False
        PNameComboBox.Enabled = False
        BillNoTextBox.Enabled = False
        QtyTextBox.Enabled = False
        BalanceTextBox.Enabled = False
        NoteTextBox.Enabled = False


        'TODO: This line of code loads data into the 'DataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DataSet1.Product)
        'TODO: This line of code loads data into the 'DataSet1.Receipt' table. You can move, or remove it, as needed.
        Me.ReceiptTableAdapter.Fill(Me.DataSet1.Receipt)


    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        DateDateTimePicker.Enabled = True
        SNameComboBox.Enabled = True
        PNameComboBox.Enabled = True
        BillNoTextBox.Enabled = True
        QtyTextBox.Enabled = True
        BalanceTextBox.Enabled = True
        NoteTextBox.Enabled = True

        Me.Validate()
        Me.ReceiptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        bal = Val(BalanceTextBox.Text) + Val(QtyTextBox.Text)

        Me.ProductTableAdapter.UpdateQty(bal, cod)


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        i = Me.ReceiptTableAdapter.ScalarQuery() + 1

        'IDTextBox.Enabled = True
        DateDateTimePicker.Enabled = True
        SNameComboBox.Enabled = True
        PNameComboBox.Enabled = True
        BillNoTextBox.Enabled = True
        QtyTextBox.Enabled = True
        BalanceTextBox.Enabled = True
        NoteTextBox.Enabled = True
        DateDateTimePicker.Focus()

    End Sub



    Private Sub DateDateTimePicker_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.LostFocus
        IDTextBox.Text = i
    End Sub

    Private Sub PNameComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNameComboBox.LostFocus
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim dr As OleDbDataReader
            Dim cmd As New OleDbCommand("select * from Product where PName = '" & PNameComboBox.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            BalanceTextBox.Text = dr("Qty")
            cod = dr("Code")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim code As String

        code = InputBox("Enter Code")
        If code <> "" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim dr As OleDbDataReader
                Dim cmd As New OleDbCommand("select * from Receipt where ID = " & code & "", con)
                dr = cmd.ExecuteReader
                dr.Read()
                IDTextBox.Text = dr(0)
                DateDateTimePicker.Value = dr(1)
                SNameComboBox.Text = dr(2)
                PNameComboBox.Text = dr(3)
                BillNoTextBox.Text = dr(4)
                QtyTextBox.Text = dr(5)
                BalanceTextBox.Text = dr(6)
                NoteTextBox.Text = dr(7)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim ans As String

        ans = MessageBox.Show("Are you sure?", cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = 6 Then
            Me.ReceiptTableAdapter.DeleteQuery(Val(IDTextBox.Text))
            MessageBox.Show("Record Deleted", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class