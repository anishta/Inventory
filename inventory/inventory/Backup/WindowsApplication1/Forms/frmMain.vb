Imports System.IO
Imports System.Data.OleDb
Imports System.IO.Directory
Public Class frmMain

    Private Sub CustomerWiseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerWiseToolStripMenuItem1.Click
        frmCustomerWise.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim dat As String
        dat = Format(Now, "dd-MM-yyyy")
        Directory.CreateDirectory("C:\Backup\" & dat & "")
        FileCopy("C:\WindowsApplication1\WindowsApplication1\bin\Debug\db1.mdb", "C:\Backup\" & dat & "\db1.mdb")

        End
    End Sub

    Private Sub ProductDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductDetailToolStripMenuItem.Click
        frmProduct.Show()
    End Sub

    Private Sub CustomerDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailToolStripMenuItem.Click
        frmCustomer.Show()
    End Sub

    Private Sub ProductReceivedDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductReceivedDetailToolStripMenuItem.Click
        frmReceived.Show()
    End Sub

    Private Sub ProductIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductIssueToolStripMenuItem.Click
        frmIssue.Show()
    End Sub

    Private Sub ProductWiseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductWiseToolStripMenuItem1.Click
        frmProductWise.Show()
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        frmDateWise.Show()
    End Sub

    Private Sub ProductIssuedReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductIssuedReportsToolStripMenuItem.Click

    End Sub

    Private Sub DateWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateWiseToolStripMenuItem.Click
        frmrDateWise.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim n As Double
        n = Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Dim d As Double

        d = Shell("C:\WINDOWS\NOTEPAD.EXE", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        frmCustomerDetails.Show()
    End Sub

    Private Sub ProductDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductDetailsToolStripMenuItem.Click
        frmProductDetials.Show()
    End Sub
End Class