Imports System.IO
Imports System.Data.OleDb
Public Class frmCustomer
    Dim i As Integer
    Private Sub CustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

        CodeTextBox.Enabled = False
        NameTextBox.Enabled = False
        AddressTextBox.Enabled = False
        CityTextBox.Enabled = False
        StateTextBox.Enabled = False
        Phone_NoTextBox.Enabled = False
        Mobile_NoTextBox.Enabled = False

        MessageBox.Show("Record Saved", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CodeTextBox.Enabled = False
        NameTextBox.Enabled = False
        AddressTextBox.Enabled = False
        CityTextBox.Enabled = False
        StateTextBox.Enabled = False
        Phone_NoTextBox.Enabled = False
        Mobile_NoTextBox.Enabled = False

        'TODO: This line of code loads data into the 'DataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DataSet1.Customer)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        'CodeTextBox.Enabled = True
        NameTextBox.Enabled = True
        AddressTextBox.Enabled = True
        CityTextBox.Enabled = True
        StateTextBox.Enabled = True
        Phone_NoTextBox.Enabled = True
        Mobile_NoTextBox.Enabled = True

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim ans As Integer
        ans = MessageBox.Show("Are you sure?", cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If ans = 6 Then
            Me.CustomerTableAdapter.DeleteQuery(Val(CodeTextBox.Text))
            MessageBox.Show("Record Deleted", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        i = Me.CustomerTableAdapter.ScalarQuery() + 1

        'CodeTextBox.Enabled = True
        NameTextBox.Enabled = True
        AddressTextBox.Enabled = True
        CityTextBox.Enabled = True
        StateTextBox.Enabled = True
        Phone_NoTextBox.Enabled = True
        Mobile_NoTextBox.Enabled = True
    End Sub

    Private Sub NameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameTextBox.LostFocus
        CodeTextBox.Text = i
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmDatagridView.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click



        Dim code As String

        code = InputBox("Enter Code")
        If code <> "" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim dr As OleDbDataReader
                Dim cmd As New OleDbCommand("select * from Customer where Code = " & code & "", con)
                dr = cmd.ExecuteReader
                dr.Read()
                CodeTextBox.Text = dr(0)
                NameTextBox.Text = dr(1)
                AddressTextBox.Text = dr(2)
                CityTextBox.Text = dr(3)
                StateTextBox.Text = dr(4)
                Phone_NoTextBox.Text = dr(5)
                Mobile_NoTextBox.Text = dr(6)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class