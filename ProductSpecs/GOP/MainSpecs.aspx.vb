Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager


Public Class MainSpecs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstSearchResults.Items.Clear()

        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode like '%" & txtSearchText.Text & "%' order by description", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                lstSearchResults.Items.Add(rdr("ProductCode") & " - " & rdr("description"))
            End While
        End If
        cmd.Dispose()
        oConn.Dispose()

    End Sub

    Protected Sub lstSearchResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSearchResults.SelectedIndexChanged
        'grab first part of selection
        Dim sProductCode As String
        sProductCode = lstSearchResults.SelectedItem.Text
        sProductCode = sProductCode.Substring(0, sProductCode.IndexOf(" - "))

        LoadProductCode(sProductCode)
    End Sub

    Protected Sub LoadProductCode(sProductCode As String)
        'load allllll the fields here

    End Sub













    Public Shared Function ConnectSQL(db As String) As SqlConnection

        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn

    End Function

End Class