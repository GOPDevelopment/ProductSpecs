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
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode like '%" & txtSearchText.Text & "%' order by Product_Description, ProductCode", oConn)
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

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Dim oConn As New SqlConnection
        'oConn = ConnectSQL(AppSettings("ConnectionString"))

        'Dim cmd As New SqlCommand
        'cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode like '%" & txtSearchText.Text & "%' order by Product_Description", oConn)
        'Dim rdr As SqlClient.SqlDataReader
        'rdr = cmd.ExecuteReader
        'If rdr.HasRows Then
        '    While rdr.Read()
        '        lstSearchResults.Items.Add(rdr("ProductCode") & " - " & rdr("Product_Description"))
        '    End While
        '    lstSearchResults.SelectedIndex = -1
        'End If

        'cmd.Dispose()
        'oConn.Dispose()


        Dim sSql As String
        sSql = "UPDATE dbo.ProductInfo
                SET ProductCode = @ProductCode, Main_Code = @Main_Code, [Correlating_IMPS_Number_(if_applicable)] = @Correlating_IMPS_Number, GTIN = @GTIN, [Grade/Brand] = @GradeBrand, 
                    Grade_Abbreviation = @Grade_Abbreviation, [Cut_Type_(BI/Bnls)] = @Cut_Type, [Microbial_Testing_Required_(Y/N)] = @Microbial_Testing_Required, [By_Product_(Y/N)] = @By_Product, 
                    [Raw_Material/Product_Derived_From] = @Raw_MaterialProduct_Derived_From, [Fat_%] = @Fat_Percentage, [Lean_%] = @Lean_Percentage, Initial_Grind = @Initial_Grind, 
                    Final_Grind = @Final_Grind, Grind_Classification = @Grind_Classification, Patty_Classification = @Patty_Classification, Product_Description = @Product_Description, 
                    [Product_Description_(Alpha)] = @Product_DescriptionAlpha, Product_Description_Alpha = @Product_Description_Alpha, Box_Description = @Box_Description, 
                    [Mixed_Combo_(Y/N)] = @Mixed_Combo, [Primary_Bag_(Full_Name)] = @Primary_Bag, [Secondary_Bag_(Full_Name)] = @Secondary_Bag, [Special_Packaging_(if_applicable)] = @Special_Packaging, 
                    [Product_Film_(Whole/Top)] = @Product_FilmWholeTop, [Product_Film_(Bottom)] = @Product_FilmBottom, [Special_Label_(Y/N)] = @Special_Label, [Special_Label_Description_(Box)] = @Special_Label_Description_Box, 
                    [Special_Label_Description_(Package)] = @Special_Label_Description_Package, [Sticker_(Y/N)] = @Sticker, Primary_Sticker = @Primary_Sticker, Secondary_Sticker = @Secondary_Sticker, 
                    [Patties/Package] = @PattiesPackage, [Packages/Box] = @PackagesBox, [Chubs/Box] = @ChubsBox, [Pc/Bag] = @PcBag, [Bag/Box] = @BagBox, [Pc/Box] = @PcBox, [Hd/Box] = @HdBox, 
                    [Approximate_Pieces/Combo] = @Approximate_PiecesCombo, [Approximate_Head/Combo] = @Approximate_HeadCombo, Weight_Classification = @Weight_Classification, Gross_Wt = @Gross_Wt, 
                    Net_Wt = @Net_Wt, [Piece_Gross_Wt#_(lbs)] = @Piece_Gross_Wtlbs, [Piece_Net_Wt#_(lbs)] = @Piece_Net_Wtlbs, [Box_Gross_Wt#_(lbs)] = @Box_Gross_Wtlbs, [Box_Net_Wt#_(lbs)] = @Box_Net_Wtlbs, 
                    [Approximate_Box_Gross_Wt#_(lbs)] = @Approximate_Box_Gross_Wtlbs, [Approximate_Box_Net_Wt#_(lbs)] = @Approximate_Box_Net_Wtlbs, [Approximate_Combo_Gross_Wt#_(lbs)] = @Approximate_Combo_Gross_Wtlbs, 
                    [Approximate_Combo_Net_Wt#_(lbs)] = @Approximate_Combo_Net_Wtlbs, Domestic_Shelf_Life_Fresh = @Domestic_Shelf_Life_Fresh, Domestic_Shelf_Life_Frozen = @Domestic_Shelf_Life_Frozen, 
                    Export_Shelf_Life_Fresh = @Export_Shelf_Life_Fresh, Export_Shelf_LifeFrozen = @Export_Shelf_LifeFrozen, BoxID = @BoxID, Primary_BagId = @Primary_BagId, Secondary_BagID = @Secondary_BagID, DTS = @DTS
                WHERE (ProductCode = '" & Session("ProductCode") & "')"

        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand(sSql, oConn)

        cmd.Parameters.AddWithValue("@ProductCode", FixNullString(txtProductCode.Text))
        cmd.Parameters.AddWithValue("@Main_Code", FixNullString(txtMain_Code.Text))
        cmd.Parameters.AddWithValue("@Correlating_IMPS_Number", FixNullString(txtCorrelating_IMPS_Number.Text))
        cmd.Parameters.AddWithValue("@GTIN", FixNullString(txtGTIN.Text))
        cmd.Parameters.AddWithValue("@GradeBrand", FixNullString(txtGradeBrand.Text))
        cmd.Parameters.AddWithValue("@Grade_Abbreviation", FixNullString(txtGrade_Abbreviation.Text))
        cmd.Parameters.AddWithValue("@Cut_Type", FixNullString(txtCut_Type.Text))
        cmd.Parameters.AddWithValue("@Microbial_Testing_Required", FixNullString(txtMicrobial_Testing_Required.Text))
        cmd.Parameters.AddWithValue("@By_Product", FixNullString(txtBy_Product.Text))
        cmd.Parameters.AddWithValue("@Raw_MaterialProduct_Derived_From", FixNullString(txtRaw_MaterialProduct_Derived_From.Text))
        cmd.Parameters.AddWithValue("@Fat_Percentage", FixNullString(txtFat_Percentage.Text))
        cmd.Parameters.AddWithValue("@Lean_Percentage", FixNullString(txtLean_Percentage.Text))
        cmd.Parameters.AddWithValue("@Initial_Grind", FixNullString(txtInitial_Grind.Text))
        cmd.Parameters.AddWithValue("@Final_Grind", FixNullString(txtFinal_Grind.Text))
        cmd.Parameters.AddWithValue("@Grind_Classification", FixNullString(txtGrind_Classification.Text))
        cmd.Parameters.AddWithValue("@Patty_Classification", FixNullString(txtPatty_Classification.Text))
        cmd.Parameters.AddWithValue("@Product_DescriptionAlpha", FixNullString(txtProduct_DescriptionAlpha.Text))
        cmd.Parameters.AddWithValue("@Product_Description", FixNullString(txtProduct_Description.Text))
        cmd.Parameters.AddWithValue("@Product_Description_Alpha", FixNullString(txtProduct_Description_Alpha.Text))
        cmd.Parameters.AddWithValue("@Box_Description", FixNullString(txtBox_Description.Text))
        cmd.Parameters.AddWithValue("@Mixed_Combo", FixNullString(txtMixed_Combo.Text))
        cmd.Parameters.AddWithValue("@Primary_Bag", FixNullString(txtPrimary_Bag.Text))
        cmd.Parameters.AddWithValue("@Secondary_Bag", FixNullString(txtSecondary_Bag.Text))
        cmd.Parameters.AddWithValue("@Special_Packaging", FixNullString(txtSpecial_Packaging.Text))
        cmd.Parameters.AddWithValue("@Product_FilmWholeTop", FixNullString(txtProduct_Film_WholeTop.Text))
        cmd.Parameters.AddWithValue("@Product_FilmBottom", FixNullString(txtProduct_Film_Bottom.Text))
        cmd.Parameters.AddWithValue("@Special_Label", FixNullString(txtSpecial_Label.Text))
        cmd.Parameters.AddWithValue("@Special_Label_Description_Box", FixNullString(txtSpecial_Label_Description_Box.Text))
        cmd.Parameters.AddWithValue("@Special_Label_Description_Package", FixNullString(txtSpecial_Label_Description_Package.Text))
        cmd.Parameters.AddWithValue("@Sticker", FixNullString(txtSticker.Text))
        cmd.Parameters.AddWithValue("@Primary_Sticker", FixNullString(txtPrimary_Sticker.Text))
        cmd.Parameters.AddWithValue("@Secondary_Sticker", FixNullString(txtSecondary_Sticker.Text))
        cmd.Parameters.AddWithValue("@PattiesPackage", FixNullString(txtPattiesPackage.Text))
        cmd.Parameters.AddWithValue("@PackagesBox", FixNullString(txtPackagesBox.Text))
        cmd.Parameters.AddWithValue("@ChubsBox", FixNullString(txtChubsBox.Text))
        cmd.Parameters.AddWithValue("@PcBag", FixNullString(txtPcBag.Text))
        cmd.Parameters.AddWithValue("@BagBox", FixNullString(txtBagBox.Text))
        cmd.Parameters.AddWithValue("@PcBox", FixNullString(txtPcBox.Text))
        cmd.Parameters.AddWithValue("@HdBox", FixNullString(txtHdBox.Text))
        cmd.Parameters.AddWithValue("@Approximate_PiecesCombo", FixNullString(txtApproximate_PiecesCombo.Text))
        cmd.Parameters.AddWithValue("@Approximate_HeadCombo", FixNullString(txtApproximate_HeadCombo.Text))
        cmd.Parameters.AddWithValue("@Weight_Classification", FixNullString(txtWeight_Classification.Text))
        cmd.Parameters.AddWithValue("@Gross_Wt", FixNullString(txtGross_Wt.Text))
        cmd.Parameters.AddWithValue("@Net_Wt", FixNullString(txtNet_Wt.Text))
        cmd.Parameters.AddWithValue("@Piece_Gross_WtLbs", FixNullString(txtPiece_Gross_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Piece_Net_WtLbs", FixNullString(txtPiece_Net_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Box_Gross_WtLbs", FixNullString(txtBox_Gross_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Box_Net_WtLbs", FixNullString(txtBox_Net_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Approximate_Box_Gross_WtLbs", FixNullString(txtApproximate_Box_Gross_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Approximate_Box_Net_WtLbs", FixNullString(txtApproximate_Box_Net_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Approximate_Combo_Gross_WtLbs", FixNullString(txtApproximate_Combo_Gross_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Approximate_Combo_Net_WtLbs", FixNullString(txtApproximate_Combo_Net_WtLbs.Text))
        cmd.Parameters.AddWithValue("@Domestic_Shelf_Life_Fresh", FixNullString(txtDomestic_Shelf_Life_Fresh.Text))
        cmd.Parameters.AddWithValue("@Domestic_Shelf_Life_Frozen", FixNullString(txtDomestic_Shelf_Life_Frozen.Text))
        cmd.Parameters.AddWithValue("@Export_Shelf_Life_Fresh", FixNullString(txtExport_Shelf_Life_Fresh.Text))
        cmd.Parameters.AddWithValue("@Export_Shelf_LifeFrozen", FixNullString(txtExport_Shelf_LifeFrozen.Text))
        cmd.Parameters.AddWithValue("@BoxID", FixNullString(txtBoxID.Text))
        cmd.Parameters.AddWithValue("@Primary_BagId", FixNullString(txtPrimary_BagId.Text))
        cmd.Parameters.AddWithValue("@Secondary_BagID", FixNullString(txtSecondary_BagID.Text))
        cmd.Parameters.AddWithValue("@DTS", FixNullString(txtDTS.Text))
        'cmd.Parameters.AddWithValue("@primary_photo", FixNullString(txtprimary_photo.text))
        'cmd.Parameters.AddWithValue("@secondary_photo", FixNullString(txtsecondary_photo.text))
        'cmd.Parameters.AddWithValue("@box_wght_Label_photo", FixNullString(txtbox_wght_Label_photo.text))
        'cmd.Parameters.AddWithValue("@Box_label_photo", FixNullString(txtBox_label_photo.text))



        cmd.ExecuteNonQuery()
        oConn.Close()

        'save updated/new info added by user
        'MsgBox("Product has been updated", vbOKOnly)

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
        txtProductCode.Text = Session("ProductCode")
        txtProduct_Description.Text = Session("ProductDesc")

        Dim primary_photo As Integer
        Dim secondary_photo As Integer
        Dim box_wght_Label_photo As Integer
        Dim Box_label_photo As Integer


        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))

        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode = '" & Session("ProductCode") & "'", oConn)
        Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                'txtProductCode.Text = FixNull(rdr("ProductCode"))
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
                txtProduct_DescriptionAlpha.Text = FixNull(rdr("Product_Description_(Alpha)"))
                'txtProduct_Description.Text = FixNull(rdr("Product_Description"))
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

                'setting these so they can be manipulated outside the db conn
                primary_photo = FixNullInteger(rdr("primary_photo"))
                secondary_photo = FixNullInteger(rdr("secondary_photo"))
                box_wght_Label_photo = FixNullInteger(rdr("box_wght_Label_photo"))
                Box_label_photo = FixNullInteger(rdr("Box_label_photo"))

            End While
        End If

        rdr.Close()
        cmd.Dispose()




        Dim bytes As Byte()
        Dim sBase64 As String

        imgPrimaryPhoto.AlternateText = "No Primary Photo Selected"
        If primary_photo <> 0 Then
            cmd = New SqlClient.SqlCommand("SELECT Photo FROM Import_images where Import_pk = " & primary_photo, oConn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read
                    bytes = CType(rdr("Photo"), Byte())
                    sBase64 = Convert.ToBase64String(bytes)
                    imgPrimaryPhoto.ImageUrl = "data:Image/png;base64," & sBase64
                    imgPrimaryPhoto.Height = 300
                    imgPrimaryPhoto.Width = 500
                End While
            End If
            rdr.Close()
        End If

        imgSecondaryPhoto.AlternateText = "No Secondary Photo Selected"
        If secondary_photo <> 0 Then
            cmd = New SqlClient.SqlCommand("SELECT Photo FROM Import_images where Import_pk = " & secondary_photo, oConn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read
                    bytes = CType(rdr("Photo"), Byte())
                    sBase64 = Convert.ToBase64String(bytes)
                    imgSecondaryPhoto.ImageUrl = "data:Image/png;base64," & sBase64
                    imgSecondaryPhoto.Height = 300
                    imgSecondaryPhoto.Width = 500
                End While
            End If
            rdr.Close()
        End If

        imgBoxWeightLabelPhoto.AlternateText = "No Box Weight Label Photo Selected"
        If box_wght_Label_photo <> 0 Then
            cmd = New SqlClient.SqlCommand("SELECT Photo FROM Import_images where Import_pk = " & box_wght_Label_photo, oConn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read
                    bytes = CType(rdr("Photo"), Byte())
                    sBase64 = Convert.ToBase64String(bytes)
                    imgBoxWeightLabelPhoto.ImageUrl = "data:Image/png;base64," & sBase64
                    imgBoxWeightLabelPhoto.Height = 300
                    imgBoxWeightLabelPhoto.Width = 500
                End While
            End If
            rdr.Close()
        End If

        imgBoxLabelPhoto.AlternateText = "No Box Label Photo Selected"
        If Box_label_photo <> 0 Then
            cmd = New SqlClient.SqlCommand("SELECT Photo FROM Import_images where Import_pk = " & Box_label_photo, oConn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read
                    bytes = CType(rdr("Photo"), Byte())
                    sBase64 = Convert.ToBase64String(bytes)
                    imgBoxLabelPhoto.ImageUrl = "data:Image/png;base64," & sBase64
                    imgBoxLabelPhoto.Height = 300
                    imgBoxLabelPhoto.Width = 500
                End While
            End If
            rdr.Close()
        End If


        'Dim cmd As New SqlCommand
        Dim iCount As Integer = 1
        Dim sSql As String
        sSql = "SELECT * FROM dbo.Images_Additional INNER JOIN dbo.Import_images ON dbo.Images_Additional.image_import_pk = dbo.Import_images.Import_pk
                                        WHERE  (dbo.Images_Additional.product_code = '" & Session("ProductCode") & "')"
        cmd = New SqlClient.SqlCommand(sSql, oConn)
        'Dim rdr As SqlClient.SqlDataReader
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                bytes = CType(rdr("Photo"), Byte())
                sBase64 = Convert.ToBase64String(bytes)

                Select Case iCount
                    Case 1
                        imgAdditional1.ImageUrl = "data:Image/png;base64," & sBase64
                        imgAdditional1.Height = 300
                        imgAdditional1.Width = 500
                    Case 2
                        imgAdditional2.ImageUrl = "data:Image/png;base64," & sBase64
                        imgAdditional2.Height = 300
                        imgAdditional2.Width = 500
                    Case 3
                        imgAdditional3.ImageUrl = "data:Image/png;base64," & sBase64
                        imgAdditional3.Height = 300
                        imgAdditional3.Width = 500
                    Case 4
                        imgAdditional4.ImageUrl = "data:Image/png;base64," & sBase64
                        imgAdditional4.Height = 300
                        imgAdditional4.Width = 500
                    Case 5
                        imgAdditional5.ImageUrl = "data:Image/png;base64," & sBase64
                        imgAdditional5.Height = 300
                        imgAdditional5.Width = 500
                    Case Else
                        'do nothing
                End Select
                iCount = iCount + 1
            End While
        End If

        For i = iCount + 1 To 5
            Dim tempRow As TableRow = FindTableRowWithText("trAdd" & i)
            tempRow.Visible = False
        Next

        rdr.Close()
        cmd.Dispose()



        oConn.Dispose()

    End Sub











    Private Function FindTableRowWithText(stringText As String) As TableRow

        Dim tablerowControl As TableRow = DirectCast(FindControl(stringText), TableRow)

        If tablerowControl IsNot Nothing Then
        Else
        End If

        Return tablerowControl

    End Function

    Public Shared Function ConnectSQL(db As String) As SqlConnection

        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn

    End Function

End Class