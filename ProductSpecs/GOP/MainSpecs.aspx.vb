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
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode like '%" & txtSearchText.Text & "%' order by [Product Description]", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                lstSearchResults.Items.Add(rdr("ProductCode") & " - " & rdr("Product Description"))
            End While
            lstSearchResults.SelectedIndex = -1
        End If

        cmd.Dispose()
        oConn.Dispose()

    End Sub

    Protected Sub lstSearchResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSearchResults.SelectedIndexChanged
        'grab first part of selection
        Dim sProductCode As String
        sProductCode = lstSearchResults.SelectedItem.Text
        sProductCode = sProductCode.Substring(0, sProductCode.IndexOf(" - ")).Trim

        LoadProductCode(sProductCode)
    End Sub

    Protected Sub LoadProductCode(sProductCode As String)
        'load allllll the fields here

        'Select Case PC_ID, ProductCode, [Main Code], [Grade/Brand], [Grade Abbreviation], 
        '    [Cut Type (BI/Bnls)], [Product Description], [Product Description (Alpha)], 
        '    [Pc/Bag], [Bag/Box], [Pc/Box], [Hd/Box], [Weight Classification], [Gross Wt], 
        '    [Net Wt], [Domestic Shelf Life Fresh], [Domestic Shelf Life Frozen], 
        '    [Export Shelf Life Fresh], [Export Shelf LifeFrozen], 
        '    BoxID, Primary_BagId, Secondary_BagID, DTS,
        '    primary_photo, secondary_photo, box_wght_Label_photo,
        '    Box_label_photo, GTIN
        'From dbo.ProductInfo

    End Sub













    Public Shared Function ConnectSQL(db As String) As SqlConnection

        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn

    End Function

End Class