Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports System.Data.OleDb

Public Class Form1

    Public adp1 As OleDbDataAdapter
    Public ds As DataSet
    Public q As String
    Public cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\cust.mdb" & ";User Id=admin;Password=;")

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ds = New DataSet
        Dim n As Integer = InputBox("Enter the Cust No : ")
        q = "Select * from payment where custnumber =" & n
        adp1 = New OleDbDataAdapter(q, cn)
        adp1.Fill(ds)
        ds.WriteXmlSchema(System.Environment.CurrentDirectory & "\XSDs\myxsd.xsd")



        Dim rd As New ReportDocument
        rd.Load(System.Environment.CurrentDirectory & "\Reports\CrystalReport1.rpt", OpenReportMethod.OpenReportByTempCopy)
        rd.Database.Tables(0).SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rd
    End Sub
End Class
