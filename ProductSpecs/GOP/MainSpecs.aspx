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
                <asp:TableRow><asp:TableCell Width="30%"><asp:Label runat="server" Text="Product Code:  "></asp:Label></asp:TableCell><asp:TableCell HorizontalAlign="Left"><asp:TextBox ID="txtProductCode" runat="server" Width="50%" ></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Main Code:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtMain_Code" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Correlating IMPS Number:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtCorrelating_IMPS_Number" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="GTIN:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGTIN" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Grade/Brand:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGradeBrand" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Grade Abbreviation:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGrade_Abbreviation" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Cut Type:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtCut_Type" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product Description:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Description" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product Description Alpha:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Description_Alpha" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product Description (Alpha):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_DescriptionAlpha" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                
                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow><asp:TableCell ColumnSpan="2"><h3><asp:Label ID="Label14" runat="server" Text="Packaging Information"></asp:Label></h3></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box Description:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_Description" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Mixed Combo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtMixed_Combo" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Primary Bag:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPrimary_Bag" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Secondary Bag:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSecondary_Bag" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special Packaging:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Packaging" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product Film Whole/Top:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Film_WholeTop" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Product Film Bottom:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtProduct_Film_Bottom" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special Label:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Label" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special Label Description Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Label_Description_Box" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Special Label Description Package:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSpecial_Label_Description_Package" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Sticker:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSticker" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Primary Sticker:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPrimary_Sticker" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Secondary Sticker:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSecondary_Sticker" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Patties Per Package:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPattiesPackage" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Packages Per Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPackagesBox" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Chubs Per Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtChubsBox" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Pieces Per Bag:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPcBag" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Bags Per Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBagBox" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Pieces Per Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPcBox" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Head Per Box:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtHdBox" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate Pieces Per Combo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_PiecesCombo" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approximate Head Per Combo:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_HeadCombo" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                                               
                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Weight Classification:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtWeight_Classification" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Gross Weight:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGross_Wt" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Net Weight:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtNet_Wt" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Pieces Per Gross Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPiece_Gross_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Pieces Per Net Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPiece_Net_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box Gross Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_Gross_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box Net Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBox_Net_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approx Box Gross Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Box_Gross_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approx Box NetWeight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Box_Net_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approx Combo Gross Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Combo_Gross_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Approx Combo Net Weight (LBS):  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtApproximate_Combo_Net_WtLbs" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Box ID:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBoxID" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Primary Bag ID:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPrimary_BagId" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Secondary Bag ID:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtSecondary_BagID" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="DTS:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtDTS" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Microbial Testing Required:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtMicrobial_Testing_Required" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="By Product:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtBy_Product" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Raw Material/Product Derived From:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtRaw_MaterialProduct_Derived_From" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Fat Percentage:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtFat_Percentage" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Lean Percentage:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtLean_Percentage" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Initial Grind:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtInitial_Grind" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Final Grind:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtFinal_Grind" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Grind Classification:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtGrind_Classification" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Patty Classification:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtPatty_Classification" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                
                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow><asp:TableCell ColumnSpan="2"><h3><asp:Label ID="Label13" runat="server" Text="Shelf Life"></asp:Label></h3></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Domestic Shelf Life Fresh:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtDomestic_Shelf_Life_Fresh" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Domestic Shelf Life Frozen:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtDomestic_Shelf_Life_Frozen" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Export Shelf Life Fresh:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtExport_Shelf_Life_Fresh" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Export Shelf Life Frozen:  "></asp:Label></asp:TableCell><asp:TableCell><asp:TextBox ID="txtExport_Shelf_LifeFrozen" runat="server" Width="50%"></asp:TextBox></asp:TableCell></asp:TableRow>
                
                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell ColumnSpan="2" HorizontalAlign="Center"><asp:Button runat="server" Text="Update Info" ID="btnUpdate" Font-Size="XX-Large"/></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

            </asp:Table>




            <asp:Table ID="Table2" runat="server" Width="50%" BorderStyle="Groove">                               
                <asp:TableRow><asp:TableCell ColumnSpan="2"><h3><asp:Label ID="Label12" runat="server" Text="Images"></asp:Label></h3></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Button ID="btnAddProductImage" runat="server" Text="Add/Update Product Images"  /></asp:TableCell></asp:TableRow>

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


                <asp:TableRow ID="trAdd1">
                    <asp:TableCell><asp:Label ID="Label1" runat="server" Text="Additional Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgAdditional1" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="trAdd2">
                    <asp:TableCell><asp:Label ID="Label2" runat="server" Text="Additional Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgAdditional2" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="trAdd3">
                    <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Additional Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgAdditional3" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="trAdd4">
                    <asp:TableCell><asp:Label ID="Label4" runat="server" Text="Additional Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgAdditional4" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="trAdd5">
                    <asp:TableCell><asp:Label ID="Label5" runat="server" Text="Additional Photo: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Image runat="server" ID="imgAdditional5" /></asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
