Imports System.IO
Imports System.Data.OleDb
Public Class frmProduct
    Dim i As Integer

    Private Sub ProductBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        CodeTextBox.Enabled = False
        PNameTextBox.Enabled = False
        QtyTextBox.Enabled = False

        MessageBox.Show("Record Saved", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CodeTextBox.Enabled = False
        PNameTextBox.Enabled = False
        QtyTextBox.Enabled = False
7:
        'TODO: This line of code loads data into the 'DataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DataSet1.Product)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim ans As Integer

        ans = MessageBox.Show("Are you sure?", cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = 6 Then
            Me.ProductTableAdapter.DeleteQuery(Val(CodeTextBox.Text))
            MessageBox.Show("Record Deleted", cap, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'CodeTextBox.Enabled = True
        PNameTextBox.Enabled = True
        QtyTextBox.Enabled = True

        'Me.Validate()
        'Me.ProductBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DataSet1)


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        i = Me.ProductTableAdapter.ScalarQuery()

        'CodeTextBox.Enabled = True
        PNameTextBox.Enabled = True
        QtyTextBox.Enabled = True

        CodeTextBox.Focus()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Dim code As String

        code = InputBox("Enter Code")
        If code <> "" Then
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()
                Dim dr As OleDbDataReader
                Dim cmd As New OleDbCommand("select * from Product where Code = " & code & "", con)
                dr = cmd.ExecuteReader
                dr.Read()
                CodeTextBox.Text = dr(0)
                PNameTextBox.Text = dr(1)
                QtyTextBox.Text = dr(2)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        
    End Sub

    Private Sub PNameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNameTextBox.LostFocus
        CodeTextBox.Text = i + 1
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmDatagridView.Show()
    End Sub

    Private Sub PNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNameTextBox.TextChanged

    End Sub
End Class
