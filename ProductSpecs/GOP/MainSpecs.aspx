<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MainSpecs.aspx.vb" Inherits="ProductSpecs.MainSpecs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GOP Product Specification Form</title>
    <link rel="stylesheet" href="GOPStyles.css"/>
</head>

<body>
    <form id="form1" runat="server">
        <div><h1>Greater Omaha Product Specification Form</h1></div>

        <div>Product Code Search Text:&nbsp;&nbsp; <asp:TextBox ID="txtSearchText" runat="server" Width="71px"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" Width="88px" />
            <br /><br />
            <asp:ListBox ID="lstSearchResults" runat="server" Width="50%" BackColor="#CCCCCC" EnableTheming="True" Rows="10" AutoPostBack="True"></asp:ListBox>
            <br /><br />
        </div>

        <div>     
            <asp:Table ID="Table1" runat="server" Width="50%" BorderStyle="Groove">
                <asp:TableRow >
                    <asp:TableCell Width="25%"><asp:Label ID="Label1" runat="server" Text="Product Code: "></asp:Label></asp:TableCell>
                    <asp:TableCell Width="75%"><asp:Label ID="lblProductCode" runat="server"></asp:Label></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Product Name: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="GTIN: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtGTIN" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Product Brand/Grade: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:DropDownList ID="ddlProductGrade" runat="server"></asp:DropDownList></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Cut Type: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtCutType" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Product Description: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>

                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"><h3><asp:Label ID="Label14" runat="server" Text="Packaging Information"></asp:Label></h3></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Manufacturer Product Number: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtManfProdNumber" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>                
                <asp:TableRow>
                    <asp:TableCell><asp:Label runat="server" Text="Weight Classification: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtWeightClass" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>                

                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label15" runat="server" Text="Bag Dimensions: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtBagDimensions" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label6" runat="server" Text="Box Dimensions: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtBoxDimensions" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label16" runat="server" Text="Pieces Per Bag: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtPiecesPerBag" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Bags Per Box: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtBagsPerBox" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label8" runat="server" Text="Bag Tare Weight: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtBagTare" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label9" runat="server" Text="Box Tare Weight: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtBoxTare" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label7" runat="server" Text="Pallet TI - HI: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtPallet" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label10" runat="server" Text="Total Tare Weight: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtTotalTare" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>



                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"><h3><asp:Label ID="Label13" runat="server" Text="Shelf Life"></asp:Label></h3></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label2" runat="server" Text="Domestic Shelf-Life (Fresh): "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtDomSLFresh" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label4" runat="server" Text="Domestic Shelf-Life (Frozen): "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtDomSLFrozen" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label5" runat="server" Text="Export Shelf-Life (Fresh): "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtExportSLFresh" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label11" runat="server" Text="Export Shelf-Life (Frozen): "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtExportSLFrozen" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>


                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                               
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"><h3><asp:Label ID="Label12" runat="server" Text="Images"></asp:Label></h3></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Button ID="btnAddProductImage" runat="server" Text="Add/Update Product Images"  /></asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label17" runat="server" Text="Primary Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgPrimaryPhoto" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label18" runat="server" Text="Secondary Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgSecondaryPhoto" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label19" runat="server" Text="Box Weight Label Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgBoxWeightLabelPhoto" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label20" runat="server" Text="Box Label Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgBoxLabelPhoto" /></asp:TableCell>
                </asp:TableRow>







                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
































<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="ProductCode:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProductCode" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Main_Code:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtMain_Code" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Correlating_IMPS_Number:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtCorrelating_IMPS_Number" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="GTIN:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="GradeBrand:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGradeBrand" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Grade_Abbreviation:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGrade_Abbreviation" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Cut_Type:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtCut_Type" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Microbial_Testing_Required:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtMicrobial_Testing_Required" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="By_Product:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBy_Product" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Raw_MaterialProduct_Derived_From:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtRaw_MaterialProduct_Derived_From" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Fat_Percentage:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtFat_Percentage" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Lean_Percentage:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtLean_Percentage" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Initial_Grind:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtInitial_Grind" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Final_Grind:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtFinal_Grind" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Grind_Classification:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGrind_Classification" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Patty_Classification:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPatty_Classification" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product_DescriptionAlpha:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_DescriptionAlpha" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product_Description:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Description" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product_Description_Alpha:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Description_Alpha" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box_Description:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_Description" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Mixed_Combo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtMixed_Combo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Primary_Bag:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPrimary_Bag" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Secondary_Bag:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSecondary_Bag" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special_Packaging:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Packaging" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product_Film_WholeTop:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Film_WholeTop" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product_Film_Bottom:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Film_Bottom" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special_Label:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Label" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special_Label_Description_Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Label_Description_Box" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special_Label_Description_Package:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Label_Description_Package" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Sticker:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSticker" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Primary_Sticker:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPrimary_Sticker" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Secondary_Sticker:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSecondary_Sticker" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="PattiesPackage:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPattiesPackage" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="PackagesBox:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPackagesBox" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="ChubsBox:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtChubsBox" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="PcBag:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPcBag" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="BagBox:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBagBox" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="PcBox:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPcBox" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="HdBox:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtHdBox" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate_PiecesCombo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_PiecesCombo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate_HeadCombo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_HeadCombo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Weight_Classification:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtWeight_Classification" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Gross_Wt:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGross_Wt" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Net_Wt:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtNet_Wt" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Piece_Gross_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPiece_Gross_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Piece_Net_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPiece_Net_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box_Gross_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_Gross_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box_Net_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_Net_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate_Box_Gross_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Box_Gross_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate_Box_Net_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Box_Net_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate_Combo_Gross_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Combo_Gross_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate_Combo_Net_WtLbs:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Combo_Net_WtLbs" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Domestic_Shelf_Life_Fresh:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtDomestic_Shelf_Life_Fresh" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Domestic_Shelf_Life_Frozen:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtDomestic_Shelf_Life_Frozen" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Export_Shelf_Life_Fresh:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtExport_Shelf_Life_Fresh" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Export_Shelf_LifeFrozen:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtExport_Shelf_LifeFrozen" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="BoxID:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBoxID" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Primary_BagId:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPrimary_BagId" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Secondary_BagID:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSecondary_BagID" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="DTS:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtDTS" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="primary_photo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtprimary_photo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="secondary_photo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtsecondary_photo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="box_wght_Label_photo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtbox_wght_Label_photo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
<asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box_label_photo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_label_photo" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>



            </asp:Table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
