Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager


Public Class MainSpecs
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstSearchResults.Items.Clear()

        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode like '%" & txtSearchText.Text & "%' order by Product_Description", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                lstSearchResults.Items.Add(rdr("ProductCode") & " - " & rdr("Product_Description"))
            End While
            lstSearchResults.SelectedIndex = -1
        End If

        cmd.Dispose()
        oConn.Dispose()

    End Sub

    Protected Sub btnAddImages_Click(sender As Object, e As EventArgs) Handles btnAddProductImage.Click
        If Session("ProductCode") <> "" Then
            Response.Redirect("Pictures.aspx")
        Else

        End If

    End Sub
    Protected Sub lstSearchResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSearchResults.SelectedIndexChanged
        'grab first part of selection
        Dim sTemp As String
        Dim sProductCode As String
        Dim sProductName As String

        sTemp = lstSearchResults.SelectedItem.Text
        sProductCode = sTemp.Substring(0, sTemp.IndexOf("-")).Trim
        sProductName = sTemp.Substring(sTemp.IndexOf("-") + 1).Trim

        Session("ProductCode") = sProductCode
        Session("ProductDesc") = sProductName

        LoadProductCode(sProductCode)

    End Sub

    Protected Sub LoadProductCode(sProductCode As String)
        'load allllll the fields here
        lblProductCode.Text = Session("ProductCode")
        txtProductDescription.Text = Session("ProductDesc")

        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode = '" & Session("ProductCode") & "'", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                txtProductCode.Text = FixNull(rdr("ProductCode"))
                txtMain_Code.Text = FixNull(rdr("Main_Code"))
                txtCorrelating_IMPS_Number.Text = FixNull(rdr("Correlating_IMPS_Number_(if_applicable)"))
                txtGTIN.Text = FixNull(rdr("GTIN"))
                txtGradeBrand.Text = FixNull(rdr("Grade/Brand"))
                txtGrade_Abbreviation.Text = FixNull(rdr("Grade_Abbreviation"))
                txtCut_Type.Text = FixNull(rdr("Cut_Type_(BI/Bnls)"))
                txtMicrobial_Testing_Required.Text = FixNull(rdr("Microbial_Testing_Required_(Y/N)"))
                txtBy_Product.Text = FixNull(rdr("By_Product_(Y/N)"))
                txtRaw_MaterialProduct_Derived_From.Text = FixNull(rdr("Raw_Material/Product_Derived_From"))
                txtFat_Percentage.Text = FixNull(rdr("Fat_%"))
                txtLean_Percentage.Text = FixNull(rdr("Lean_%"))
                txtInitial_Grind.Text = FixNull(rdr("Initial_Grind"))
                txtFinal_Grind.Text = FixNull(rdr("Final_Grind"))
                txtGrind_Classification.Text = FixNull(rdr("Grind_Classification"))
                txtPatty_Classification.Text = FixNull(rdr("Patty_Classification"))
                txtProduct_DescriptionAlpha.Text = FixNull(rdr("Product_Description"))
                txtProduct_Description.Text = FixNull(rdr("Product_Description_(Alpha)"))
                txtProduct_Description_Alpha.Text = FixNull(rdr("Product_Description_Alpha"))
                txtBox_Description.Text = FixNull(rdr("Box_Description"))
                txtMixed_Combo.Text = FixNull(rdr("Mixed_Combo_(Y/N)"))
                txtPrimary_Bag.Text = FixNull(rdr("Primary_Bag_(Full_Name)"))
                txtSecondary_Bag.Text = FixNull(rdr("Secondary_Bag_(Full_Name)"))
                txtSpecial_Packaging.Text = FixNull(rdr("Special_Packaging_(if_applicable)"))
                txtProduct_Film_WholeTop.Text = FixNull(rdr("Product_Film_(Whole/Top)"))
                txtProduct_Film_Bottom.Text = FixNull(rdr("Product_Film_(Bottom)"))
                txtSpecial_Label.Text = FixNull(rdr("Special_Label_(Y/N)"))
                txtSpecial_Label_Description_Box.Text = FixNull(rdr("Special_Label_Description_(Box)"))
                txtSpecial_Label_Description_Package.Text = FixNull(rdr("Special_Label_Description_(Package)"))
                txtSticker.Text = FixNull(rdr("Sticker_(Y/N)"))
                txtPrimary_Sticker.Text = FixNull(rdr("Primary_Sticker"))
                txtSecondary_Sticker.Text = FixNull(rdr("Secondary_Sticker"))
                txtPattiesPackage.Text = FixNull(rdr("Patties/Package"))
                txtPackagesBox.Text = FixNull(rdr("Packages/Box"))
                txtChubsBox.Text = FixNull(rdr("Chubs/Box"))
                txtPcBag.Text = FixNull(rdr("Pc/Bag"))
                txtBagBox.Text = FixNull(rdr("Bag/Box"))
                txtPcBox.Text = FixNull(rdr("Pc/Box"))
                txtHdBox.Text = FixNull(rdr("Hd/Box"))
                txtApproximate_PiecesCombo.Text = FixNull(rdr("Approximate_Pieces/Combo"))
                txtApproximate_HeadCombo.Text = FixNull(rdr("Approximate_Head/Combo"))
                txtWeight_Classification.Text = FixNull(rdr("Weight_Classification"))
                txtGross_Wt.Text = FixNull(rdr("Gross_Wt"))
                txtNet_Wt.Text = FixNull(rdr("Net_Wt"))
                txtPiece_Gross_WtLbs.Text = FixNull(rdr("Piece_Gross_Wt#_(lbs)"))
                txtPiece_Net_WtLbs.Text = FixNull(rdr("Piece_Net_Wt#_(lbs)"))
                txtBox_Gross_WtLbs.Text = FixNull(rdr("Box_Gross_Wt#_(lbs)"))
                txtBox_Net_WtLbs.Text = FixNull(rdr("Box_Net_Wt#_(lbs)"))
                txtApproximate_Box_Gross_WtLbs.Text = FixNull(rdr("Approximate_Box_Gross_Wt#_(lbs)"))
                txtApproximate_Box_Net_WtLbs.Text = FixNull(rdr("Approximate_Box_Net_Wt#_(lbs)"))
                txtApproximate_Combo_Gross_WtLbs.Text = FixNull(rdr("Approximate_Combo_Gross_Wt#_(lbs)"))
                txtApproximate_Combo_Net_WtLbs.Text = FixNull(rdr("Approximate_Combo_Net_Wt#_(lbs)"))
                txtDomestic_Shelf_Life_Fresh.Text = FixNull(rdr("Domestic_Shelf_Life_Fresh"))
                txtDomestic_Shelf_Life_Frozen.Text = FixNull(rdr("Domestic_Shelf_Life_Frozen"))
                txtExport_Shelf_Life_Fresh.Text = FixNull(rdr("Export_Shelf_Life_Fresh"))
                txtExport_Shelf_LifeFrozen.Text = FixNull(rdr("Export_Shelf_LifeFrozen"))
                txtBoxID.Text = FixNull(rdr("BoxID"))
                txtPrimary_BagId.Text = FixNull(rdr("Primary_BagId"))
                txtSecondary_BagID.Text = FixNull(rdr("Secondary_BagID"))
                txtDTS.Text = FixNull(rdr("DTS"))
                txtprimary_photo.Text = FixNull(rdr("primary_photo"))
                txtsecondary_photo.Text = FixNull(rdr("secondary_photo"))
                txtbox_wght_Label_photo.Text = FixNull(rdr("box_wght_Label_photo"))
                txtBox_label_photo.Text = FixNull(rdr("Box_label_photo"))

            End While
        End If

        cmd.Dispose()
        oConn.Dispose()

        '      Select  
        '     [ProductCode]
        '    ,[Main_Code]
        '    ,[Correlating_IMPS_Number_(if_applicable)]
        '    ,[GTIN]
        '    ,[Grade/Brand]
        '    ,[Grade_Abbreviation]
        '    ,[Cut_Type_(BI/Bnls)]
        '    ,[Microbial_Testing_Required_(Y/N)]
        '    ,[By_Product_(Y/N)]
        '    ,[Raw_Material/Product_Derived_From]
        '    ,[Fat_%]
        '    ,[Lean_%]
        '    ,[Initial_Grind]
        '    ,[Final_Grind]
        '    ,[Grind_Classification]
        '    ,[Patty_Classification]
        '    ,[Product_Description]
        '    ,[Product_Description_(Alpha)]
        '    ,[Product_Description_Alpha]
        '    ,[Box_Description]
        '    ,[Mixed_Combo_(Y/N)]
        '    ,[Primary_Bag_(Full_Name)]
        '    ,[Secondary_Bag_(Full_Name)]
        '    ,[Special_Packaging_(if_applicable)]
        '    ,[Product_Film_(Whole/Top)]
        '    ,[Product_Film_(Bottom)]
        '    ,[Special_Label_(Y/N)]
        '    ,[Special_Label_Description_(Box)]
        '    ,[Special_Label_Description_(Package)]
        '    ,[Sticker_(Y/N)]
        '    ,[Primary_Sticker]
        '    ,[Secondary_Sticker]
        '    ,[Patties/Package]
        '    ,[Packages/Box]
        '    ,[Chubs/Box]
        '    ,[Pc/Bag]
        '    ,[Bag/Box]
        '    ,[Pc/Box]
        '    ,[Hd/Box]
        '    ,[Approximate_Pieces/Combo]
        '    ,[Approximate_Head/Combo]
        '    ,[Weight_Classification]
        '    ,[Gross_Wt]
        '    ,[Net_Wt]
        '    ,[Piece_Gross_Wt#_(lbs)]
        '    ,[Piece_Net_Wt#_(lbs)]
        '    ,[Box_Gross_Wt#_(lbs)]
        '    ,[Box_Net_Wt#_(lbs)]
        '    ,[Approximate_Box_Gross_Wt#_(lbs)]
        '    ,[Approximate_Box_Net_Wt#_(lbs)]
        '    ,[Approximate_Combo_Gross_Wt#_(lbs)]
        '    ,[Approximate_Combo_Net_Wt#_(lbs)]
        '    ,[Domestic_Shelf_Life_Fresh]
        '    ,[Domestic_Shelf_Life_Frozen]
        '    ,[Export_Shelf_Life_Fresh]
        '    ,[Export_Shelf_LifeFrozen]
        '    ,[BoxID]
        '    ,[Primary_BagId]
        '    ,[Secondary_BagID]
        '    ,[DTS]
        '    ,[primary_photo]
        '    ,[secondary_photo]
        '    ,[box_wght_Label_photo]
        '    ,[Box_label_photo]
        'From [ProductSpec].[dbo].[ProductInfo]

    End Sub













    Public Shared Function ConnectSQL(db As String) As SqlConnection

        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn

    End Function

End Class